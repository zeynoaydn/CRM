using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;


namespace Business.Abstract
{
    public interface ICountriesService
    {
        IDataResult<List<Countries>> GetAll();
        IDataResult<Countries> GetById(int countriesid);
        IResult Add(Countries countries);
        IResult Delete(Countries countries);
        IResult Update(Countries countries);
    }
}
