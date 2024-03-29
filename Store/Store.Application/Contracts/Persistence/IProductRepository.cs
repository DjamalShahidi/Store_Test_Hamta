﻿using Microsoft.EntityFrameworkCore;
using Store.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.Contracts.Persistence
{
    public interface IProductRepository : IGenericRepository<Product>
    {
         Task<List<Product>> GetProductByCategoryIdAsync(int categoryId);

        Task<List<Product>> GetListAsyncWithInclude();

    }
}
