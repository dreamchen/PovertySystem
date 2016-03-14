using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace DAL
{
    public class UserDAL
    {
        private string tableColumn = "select u_id,u_account,u_passport,u_name,u_role_id,u_role_name,u_status from user where 1=1";

        public UserModel findUserByCond(UserCondition condition)
        {
            MySQLDataHelper dbHelper = new MySQLDataHelper();
            StringBuilder strBuilder = new StringBuilder(tableColumn);
            if (condition == null)
            {
                return null;
            }
            if (!string.IsNullOrEmpty(condition.U_account))
            {
                strBuilder.Append(" and u_account='" + condition.U_account + "'");
            }
            if (!string.IsNullOrEmpty(condition.U_passport))
            {
                strBuilder.Append(" and u_passport='" + condition.U_passport + "'");
            }

            DataTable dataTable = dbHelper.ExecuteQuery(strBuilder.ToString(), System.Data.CommandType.Text);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                UserModel user = new UserModel();
                user.U_id = dataTable.Rows[0]["u_id"].ToString();
                user.U_account = dataTable.Rows[0]["u_account"].ToString();
                user.U_passport = dataTable.Rows[0]["u_passport"].ToString();
                user.U_name = dataTable.Rows[0]["u_name"].ToString();
                user.U_role_id = dataTable.Rows[0]["u_role_id"].ToString();
                user.U_role_name = dataTable.Rows[0]["u_role_name"].ToString();
                user.U_status = dataTable.Rows[0]["u_status"].ToString();
                return user;
            }
            return null;
        }

        public List<UserModel> findUserListByCond(UserCondition condition)
        {
            MySQLDataHelper dbHelper = new MySQLDataHelper();
            DataTable dataTable = dbHelper.ExecuteQuery("select * from user where u_account='' and passport=''", System.Data.CommandType.Text);

            return null;
        }
    }
}
