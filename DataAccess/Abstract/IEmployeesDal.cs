
using Core.Abstract;
using Entities.Concrete;


namespace DataAccess.Abstract
{
    public interface IEmployeesDal : IEntityRepository<Employees>
    {
    }
}
