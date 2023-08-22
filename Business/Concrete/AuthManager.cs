//using Business.Abstract;
//using Business.Constants;
//using Core.Utilities.Results;
//using Core.Utilities.Security.Hashing;
//using Core.Utilities.Security.JWT;
//using Core.Entities.Concrete;
//using Entities.Dtos;
//using Entities.Concrete;

//namespace Business.Concrete
//{
//    public class AuthManager : IAuthService
//    {
//        private IUsersService _usersService;
//        private ITokenHelper _tokenHelper;

//        public AuthManager(IUsersService usersService, ITokenHelper tokenHelper)
//        {
//            _usersService = usersService;
//            _tokenHelper = tokenHelper;
//        }

//        public IDataResult<AccessToken> CreateAccessToken(Users users)
//        {
//            var claims = _usersService.GetClaim(users);
//            var accessToken = _tokenHelper.CreateToken(users, claims);
//            return new SuccessDataResult<AccessToken>(accessToken, Messages.AccessTokenCreated);
//        }

//        public IDataResult<Users> Login(UserForLoginDto userForLoginDto)
//        {
//            var userToCheck = _usersService.GetByMail(userForLoginDto.Email);
//            if (userToCheck == null)
//            {
//                return new ErrorDataResult<Users>(Messages.UserNotFound);
//            }

//            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
//            {
//                return new ErrorDataResult<Users>(Messages.PasswordError);
//            }

//            return new SuccessDataResult<Users>(userToCheck, Messages.SuccessfulLogin);
//        }

//        public IDataResult<Users> Register(UserForRegisterDto userForRegisterDto, string password)
//        {
//            byte[] passwordHash, passwordSalt;
//            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
//            var users = new Users
//            {
//                Email = userForRegisterDto.Email,
//                Name = userForRegisterDto.Name,
//                Surname = userForRegisterDto.SurName,
//                PasswordHash = passwordHash,
//                PasswordSalt = passwordSalt,
//                Status = true
//            };
//            _usersService.Add(users);
//            return new SuccessDataResult<Users>(users, Messages.UserRegistered);
//        }

//        public IResult UserExits(string email)
//        {
//            if (_usersService.GetByMail(email) != null)
//            {
//                return new ErrorResult(Messages.UserAlreadyExists);
//            }
//            return new SuccessResult();
//        }
//    }
//}
