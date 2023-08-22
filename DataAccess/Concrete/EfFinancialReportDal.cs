
using Core.Abstract.EntityFramework;
using DataAccess.Abstract;
using System;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfFinancialReportDal: EfEntityRepositoryBase<FinancialReport, CustomerRelationshipManagementContext>, IFinancialReportDal
    {
    }
}
