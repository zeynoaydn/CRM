
using Core.Abstract.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfOfferReportDal: EfEntityRepositoryBase<OfferReport, CustomerRelationshipManagementContext>, IOfferReportDal
    {
    }
}
