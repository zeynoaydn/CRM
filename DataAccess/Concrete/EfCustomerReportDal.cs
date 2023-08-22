
using Core.Abstract.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfCustomerReportDal: EfEntityRepositoryBase<CustomerReport, CustomerRelationshipManagementContext>, ICustomerReportDal
    {
    }
}
