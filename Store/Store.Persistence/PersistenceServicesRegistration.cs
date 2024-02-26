using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Store.Application.Contracts.Persistence;
using Store.Persistence.Repositories;

namespace Store.Persistence
{
    public static class PersistenceServicesRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<StoreDbContext>(options =>
                  options.UseSqlServer(configuration.GetConnectionString("StoreConnectionString")));

            //services.AddScoped<JWTService>();

            //services.AddIdentityCore<User>(options =>
            //                                {
            //                                    options.Password.RequiredLength = 6;
            //                                    options.Password.RequireDigit = false;
            //                                }
            //                                )
            //        .AddRoles<IdentityRole>()
            //        .AddRoleManager<RoleManager<IdentityRole>>()
            //        .AddEntityFrameworkStores<StoreDbContext>()
            //        .AddUserManager<UserManager<User>>();

            //services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(option =>
            //{
            //    option.TokenValidationParameters = new TokenValidationParameters
            //    {
            //        ValidateIssuerSigningKey = true,
            //        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Key"])),
            //        ValidIssuer = configuration["JWT:Issuer"],
            //        ValidateIssuer = true,
            //        ValidateAudience = false,

            //    };
            //});

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IFeaturesRepository, FeaturesRepository>();

        //    services.AddSwaggerGen

        //    services.AddSwaggerGen(c =>
        //    {
        //        c.SwaggerDoc("1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "test", Version = "1" });
        //        c.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
        //        {
        //            In = Microsoft.OpenApi.Models.ParameterLocation.Header,
        //            Description = "Please enter into field the word 'Bearer' following by space and JWT",
        //            Name = "Authorization",
        //            Type = Microsoft.OpenApi.Models.SecuritySchemeType.ApiKey
        //        });
        //        c.AddSecurityRequirement(new OpenApiSecurityRequirement
        //{
        //    {
        //        new OpenApiSecurityScheme
        //        {
        //            Reference = new OpenApiReference
        //            {
        //                Type = ReferenceType.SecurityScheme,
        //                Id = "Bearer"
        //            }
        //        },
        //        new string[] { }
        //    }
        //});
        //    });
            return services;

        }
    }

}
