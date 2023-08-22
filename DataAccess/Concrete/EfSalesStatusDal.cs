
using Core.Abstract.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace DataAccess.Concrete
{
    public class EfSalesStatusDal: EfEntityRepositoryBase<SalesStatus, CustomerRelationshipManagementContext>, ISalesStatusDal
    {
    }
}
