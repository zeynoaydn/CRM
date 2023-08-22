using Business.Abstract;
using Business.Constants;
using Business.ValidaitonRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class CountriesManager : ICountriesService
    {
        private ICountriesDal _countriesDal;
        public CountriesManager(ICountriesDal countriesDal)
        {
            _countriesDal = countriesDal;
        }
        [ValidationAspect(typeof(CountryValidator))]
        public IResult Add(Countries countries)
        {
            IResult result = BusinessRules.Run(CheckIfCountryNameExists(countries.CountryName));

            if (result != null)
            {
                return result;
            }
            _countriesDal.Add(countries);
            return new SuccessResult(Messages.CountryAdded);
        }
        private IResult CheckIfCountryNameExists(string countryName)
        {

            var result = _countriesDal.GetAll(p => p.CountryName == countryName).Any();
            if (result)
            {
                return new ErrorResult(Messages.CountryNameAlreadyExists);
            }

            return new SuccessResult();
        }

        public IResult Delete(Countries countries)
        {
            _countriesDal.Delete(countries);
            return new SuccessResult(Messages.CountryDeleted);
        }

        public IDataResult<List<Countries>> GetAll()
        {
            return new SuccessDataResult<List<Countries>>(_countriesDal.GetAll(), Messages.CountriesListed);
        }

        public IDataResult<Countries> GetById(int countriesid)
        {
            return new SuccessDataResult<Countries>(_countriesDal.Get(p => p.Id == countriesid));
        }

        public IResult Update(Countries countries)
        {
            _countriesDal.Update(countries);
            return new SuccessResult(Messages.CountryUpdated);
        }
    }
}
