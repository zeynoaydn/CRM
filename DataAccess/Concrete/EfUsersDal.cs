//using Entities.Concrete;
//using DataAccess.Concrete.EntityFramework;
//using DataAccess.Abstract;
//using Core.Abstract.EntityFramework;
//using System.Collections.Generic;
//using System.Linq;
//using Core.Entities.Concrete;

//namespace DataAccess.Concrete
//{
//    public class EfUsersDal : EfEntityRepositoryBase<Users, CustomerRelationshipManagementContext>, IUsersDal
//    {

//        public List<OperationClaims> GetClaims(Users users)
//        {
//            using (var context = new CustomerRelationshipManagementContext())
//            {
//                var result = from operationClaim in context.OperationClaims
//                             join userOperationClaim in context.UserOperationClaims
//                             on operationClaim.Id equals userOperationClaim.OperationClaimId
//                             where userOperationClaim.UserId == users.Id
//                             select new OperationClaims { Id = operationClaim.Id, Name = operationClaim.Name };
//                return result.ToList();

//            }
//        }

//        //public List<OperationClaims> GetClaims(IUsers users)
//        //{
//        //    using (var context = new CustomerRelationshipManagementContext())
//        //    {
//        //        var result = from operationClaim in context.OperationClaims
//        //                     join userOperationClaim in context.UserOperationClaims
//        //                     on operationClaim.Id equals userOperationClaim.OperationClaimId
//        //                     where userOperationClaim.UserId == users.Id
//        //                     select new OperationClaims { Id = operationClaim.Id, Name = operationClaim.Name };
//        //        return result.ToList();

//        //    }
//        //}
//    }
//}
