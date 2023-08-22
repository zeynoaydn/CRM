
using Core.Abstract.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System.Collections.Generic;

namespace DataAccess.Concrete
{
    public class EfCitiesDal:EfEntityRepositoryBase<Cities,CustomerRelationshipManagementContext>,ICitiesDal
    {
    }
}
