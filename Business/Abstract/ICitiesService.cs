using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICitiesService
    {
        IDataResult<List<Cities>> GetAll();
        IDataResult<Cities> GetById(int citiesid);
        IResult Add(Cities cities);
        IResult Delete(Cities cities);
        IResult Update(Cities cities);
    }
}
