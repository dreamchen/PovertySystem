namespace PovertySystem
{
    partial class LoginForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lblAccountText = new System.Windows.Forms.Label();
            this.lblPassportText = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtPassport = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblProccess = new System.Windows.Forms.Label();
            this.picBoxWelcome = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWelcome)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAccountText
            // 
            resources.ApplyResources(this.lblAccountText, "lblAccountText");
            this.lblAccountText.Name = "lblAccountText";
            // 
            // lblPassportText
            // 
            resources.ApplyResources(this.lblPassportText, "lblPassportText");
            this.lblPassportText.Name = "lblPassportText";
            // 
            // txtAccount
            // 
            resources.ApplyResources(this.txtAccount, "txtAccount");
            this.txtAccount.Name = "txtAccount";
            // 
            // txtPassport
            // 
            resources.ApplyResources(this.txtPassport, "txtPassport");
            this.txtPassport.Name = "txtPassport";
            this.txtPassport.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.Enter += new System.EventHandler(this.btnLogin_Enter);
            // 
            // lblProccess
            // 
            this.lblProccess.Image = global::PovertySystem.Properties.Resources.load;
            resources.ApplyResources(this.lblProccess, "lblProccess");
            this.lblProccess.Name = "lblProccess";
            // 
            // picBoxWelcome
            // 
            resources.ApplyResources(this.picBoxWelcome, "picBoxWelcome");
            this.picBoxWelcome.Name = "picBoxWelcome";
            this.picBoxWelcome.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 700;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblProccess);
            this.Controls.Add(this.picBoxWelcome);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassport);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.lblPassportText);
            this.Controls.Add(this.lblAccountText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWelcome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccountText;
        private System.Windows.Forms.Label lblPassportText;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtPassport;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox picBoxWelcome;
        private System.Windows.Forms.Label lblProccess;
        private System.Windows.Forms.Timer timer1;
    }
}

