using AutoMapper;
using Business.Abstract;
using Business.Constants;
using Business.Dtos;
using Business.ValidaitonRules.FluentValidation;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Business.Concrete
{
    public class ProductsManager : IProductsService
    {
        private IProductsDal _productsDal;
        public ProductsManager(IProductsDal productsDal)
        {
            _productsDal = productsDal;
        }
        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Products products)
        {
            IResult result = BusinessRules.Run(CheckIfProductNameExists(products.Name));

            if (result != null)
            {
                return result;
            }
            _productsDal.Add(products);
            return new SuccessResult(Messages.ProductAdded);
        }
        private IResult CheckIfProductNameExists(string productName)
        {

            var result = _productsDal.GetAll(p => p.Name == productName).Any();
            if (result)
            {
                return new ErrorResult(Messages.ProductNameAlreadyExists);
            }

            return new SuccessResult();
        }

        public IResult Delete(Products products)
        {
            _productsDal.Delete(products);
            return new SuccessResult(Messages.ProductDeleted);
        }

        //[PerformanceAspect(5)]
        public IDataResult<List<Products>> GetAll()
        {
            //Thread.Sleep(5000);
            return new SuccessDataResult<List<Products>>(_productsDal.GetAll(), Messages.ProductsListed);
        }

        public IDataResult<Products> GetById(int productId)
        {
            return new SuccessDataResult<Products>(_productsDal.Get(p=>p.Id == productId));
        }

        public IResult Update(Products products)
        {
            _productsDal.Update(products);
            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
