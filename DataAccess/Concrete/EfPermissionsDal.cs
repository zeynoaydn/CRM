
using Core.Abstract.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using DataAccess.Concrete.EntityFramework;


namespace DataAccess.Concrete
{
    public class EfPermissionsDal: EfEntityRepositoryBase<Permissions, CustomerRelationshipManagementContext>, IPermissionsDal
    {
    }
}
