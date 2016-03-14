using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class UserBLL
    {
        private UserDAL userDal = new UserDAL();

        public UserModel findUserByAccountAndPassport(string account, string passport)
        {
            UserCondition condition = new UserCondition();
            condition.U_account = account;
            condition.U_passport = passport;
            return userDal.findUserByCond(condition);
        }
    }
}
