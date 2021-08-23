using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserClaimManager : IUserClaimService
    {
        IUserClaimDal _userClaimDal;

        public UserClaimManager(IUserClaimDal userClaimDal)
        {
            _userClaimDal = userClaimDal;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userClaimDal.GetClaims(user);
        }

        public void Add(User user)
        {
            _userClaimDal.Add(user);
        }

        public User GetByMail(string email)
        {
            return _userClaimDal.Get(u => u.Email == email);
        }
    }
}
