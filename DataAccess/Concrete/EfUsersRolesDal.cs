
using Core.Abstract.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace DataAccess.Concrete
{
    public class EfUsersRolesDal: EfEntityRepositoryBase<UsersRoles, CustomerRelationshipManagementContext>, IUsersRolesDal
    {
    }
}
