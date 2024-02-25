using AutoMapper;
using MediatR;
using Store.Application.Contracts.Persistence;
using Store.Application.DTOs.Product.Validator;
using Store.Application.Mediatr.Feature.Requests.Commands;
using Store.Application.Responses;
using Store.Domain;

namespace Store.Application.Mediatr.Feature.Handlers.Commands
{
    public class AddProductHandler : IRequestHandler<AddProduct, Response>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AddProductHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        public async Task<Response> Handle(AddProduct request, CancellationToken cancellationToken)
        {
            var validator = new AddProductDtoValidator(_unitOfWork);
            var validatorResult = await validator.ValidateAsync(request.Request);

            if (validatorResult.IsValid == false)
            {
                return new Response(validatorResult.Errors.Select(a => a.ErrorMessage));
            }

            var product = _mapper.Map<Product>(request.Request);


            using (var transaction = await _unitOfWork.BeginTransactionAsync(cancellationToken))
            {
                try
                {

                    product = await _unitOfWork.ProductRepository.AddAsync(product);

                    await _unitOfWork.Save(cancellationToken);

                    var productFeatures = new List<ProductFeature>();

                    foreach (var featureId in request.Request.FeatureIds)
                    {
                        productFeatures.Add(new ProductFeature()
                        {
                            FeatureId = featureId,
                            ProductId = product.Id
                        });
                    }

                    productFeatures = await _unitOfWork.ProductFeatureRepository.AddListAsync(productFeatures);
                    await _unitOfWork.Save(cancellationToken);
                    await transaction.CommitAsync(cancellationToken);

                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync(cancellationToken);
                    return new Response($"Fatal error {ex.Message}");

                }
            }

            return new Response();
        }
    }
}
