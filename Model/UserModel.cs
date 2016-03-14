using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserModel
    {
        protected string u_id;
        protected string u_account;
        protected string u_passport;
        protected string u_name;
        protected string u_role_id;
        protected string u_role_name;
        protected string u_status;

        public UserModel()
        {

        }

        //用户ID
        public string U_id
        {
            get { return u_id; }
            set { u_id = value; }
        }
        //登录账号
        public string U_account
        {
            get { return u_account; }
            set { u_account = value; }
        }
        //密码
        public string U_passport
        {
            get { return u_passport; }
            set { u_passport = value; }
        }
        //用户名
        public string U_name
        {
            get { return u_name; }
            set { u_name = value; }
        }
        //角色ID
        public string U_role_id
        {
            get { return u_role_id; }
            set { u_role_id = value; }
        }
        //角色名
        public string U_role_name
        {
            get { return u_role_name; }
            set { u_role_name = value; }
        }
        //用户状态
        public string U_status
        {
            get { return u_status; }
            set { u_status = value; }
        }
        public void Reset()
        {
            u_id = null;
            u_account = null;
            u_passport = null;
            u_name = null;
            u_role_id = null;
            u_role_name = null;
            u_status = null;
        }

        public void AssignFrom(UserModel AObj)
        {
            if (AObj == null)
            {
                Reset();
                return;
            }
            u_id = AObj.u_id;
            u_account = AObj.u_account;
            u_passport = AObj.u_passport;
            u_name = AObj.u_name;
            u_role_id = AObj.u_role_id;
            u_role_name = AObj.u_role_name;
            u_status = AObj.u_status;
        }
    }
}
