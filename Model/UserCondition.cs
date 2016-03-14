using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserCondition
    {
        private string u_id;
        private string u_account;
        private string u_passport;

        public string U_id
        {
            get
            {
                return u_id;
            }

            set
            {
                u_id = value;
            }
        }

        public string U_account
        {
            get
            {
                return u_account;
            }

            set
            {
                u_account = value;
            }
        }

        public string U_passport
        {
            get
            {
                return u_passport;
            }

            set
            {
                u_passport = value;
            }
        }
    }
}
