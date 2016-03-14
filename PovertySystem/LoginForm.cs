using System;
using System.Drawing;
using System.Windows.Forms;
using Model;
using BLL;
using System.Threading;

namespace PovertySystem
{
    public partial class LoginForm : Form
    {
        private UserBLL userBll = new UserBLL();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Enter(object sender, EventArgs e)
        {
            btnLogin_Click(sender, e);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAccount.Text) || string.IsNullOrWhiteSpace(txtPassport.Text))
            {
                MessageBox.Show("请输入用户名/密码！", "参数异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.btnLogin.Enabled = false;

            this.lblProccess.Text = "   登录中...";
            this.lblProccess.Visible = true;
            string account = this.txtAccount.Text.Trim();
            string passport = this.txtPassport.Text.Trim();
            UserModel user = this.userBll.findUserByAccountAndPassport(account, CommonUtil.encryptMD5(passport));
            if (user == null)
            {
                this.lblProccess.ForeColor = Color.Red;
                this.lblProccess.Image = global::PovertySystem.Properties.Resources.error;
                this.lblProccess.Text = "   用户名/密码错误！";
                this.btnLogin.Enabled = true;
            }
            else
            {
                this.lblProccess.ForeColor = Color.Blue;
                this.lblProccess.Image = global::PovertySystem.Properties.Resources.success;
                this.lblProccess.Text = "   登录成功！";
                this.timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            this.btnLogin.Enabled = true;
            DialogResult = DialogResult.OK;
        }
    }
}
