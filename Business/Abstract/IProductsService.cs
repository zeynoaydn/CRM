using Business.Dtos;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Abstract
{

    public interface IProductsService
    {
        IDataResult<List<Products>> GetAll();
        IDataResult<Products> GetById(int productId);
        IResult Add(Products products);
        IResult Delete(Products products);
        IResult Update(Products products);
    }
}
