
using Core.Abstract.EntityFramework;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
namespace DataAccess.Concrete
{
    public class EfCommunicationReportDal: EfEntityRepositoryBase<CommunicationReport, CustomerRelationshipManagementContext>, ICommunicationReportDal
    {
    }
}
