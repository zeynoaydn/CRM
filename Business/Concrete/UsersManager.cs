//using Business.Abstract;
//using Core.Entities.Concrete;
//using DataAccess.Abstract;
//using Entities.Concrete;
//using System.Collections.Generic;

//namespace Business.Concrete
//{
//    public class UsersManager : IUsersService
//    {
//        IUsersDal _usersDal;
//        public UsersManager(IUsersDal usersDal)
//        {
//            _usersDal = usersDal;
//        }
//        public void Add(Users users)
//        {
//            _usersDal.Add(users);
//        }

//        public Users GetByMail(string email)
//        {
//            return _usersDal.Get(p => p.Email == email);
//        }

//        public List<OperationClaims> GetClaim(Users users)
//        {
//            //return _usersDal.GetClaims(users);
//            return _usersDal.GetClaims(users);
//        }
//    }
//}
