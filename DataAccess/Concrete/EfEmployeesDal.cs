
using Core.Abstract.EntityFramework;
using DataAccess.Abstract;
using System;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfEmployeesDal: EfEntityRepositoryBase<Employees, CustomerRelationshipManagementContext>, IEmployeesDal
    {
    }
}
