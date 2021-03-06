﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllBySubCategoryId(int subCategoryId);
        IDataResult<List<BrandNameDTO>> BrandName();
        IDataResult<List<Product>> GetProductsOfCategory(int categoryId);
        
        IDataResult<List<Product>> GetAllProductsByBrand(string brand);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductsInBasketDTO>> GetProductDetails();
        IResult Add(Product product);
        IResult GetProduct(int productId);
        IResult Update(Product product);
        IDataResult<Product> GetById(int productId);
        IResult TestTransaction(Product product);
    }
}
