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
using System.Text;

namespace Business.Concrete
{
    public class CitiesManager : ICitiesService
    {
        private ICitiesDal _citiesDal;
        public CitiesManager(ICitiesDal citiesDal)
        {
            _citiesDal = citiesDal;
        }
        [ValidationAspect(typeof(CityValidator))]
        public IResult Add(Cities cities)
        {
            IResult result = BusinessRules.Run(CheckIfCityNameExists(cities.CityName));

            if (result != null)
            {
                return result;
            }
            _citiesDal.Add(cities);
            return new SuccessResult(Messages.CityAdded);
        }
        private IResult CheckIfCityNameExists(string countryName)
        {

            var result = _citiesDal.GetAll(p => p.CityName == countryName).Any();
            if (result)
            {
                return new ErrorResult(Messages.CityNameAlreadyExists);
            }

            return new SuccessResult();
        }
        public IResult Delete(Cities cities)
        {
            _citiesDal.Delete(cities);
            return new SuccessResult(Messages.CityDeleted);
        }

        public IDataResult<List<Cities>> GetAll()
        {
            return new SuccessDataResult<List<Cities>>(_citiesDal.GetAll());
        }

        public IDataResult<Cities> GetById(int citiesid)
        {
            return new SuccessDataResult<Cities>(_citiesDal.Get(p => p.Id == citiesid));
        }

        public IResult Update(Cities cities)
        {
            _citiesDal.Update(cities);
            return new SuccessResult(Messages.CityUpdated);
        }
    }
}
