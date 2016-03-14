namespace PovertySystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenu_EN = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenu_zh_CN = new System.Windows.Forms.ToolStripMenuItem();
            this.gpBoxSearch = new System.Windows.Forms.GroupBox();
            this.treeViewCity = new System.Windows.Forms.TreeView();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCard = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCard = new System.Windows.Forms.TextBox();
            this.txtNO = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gpBoxFamily = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpBoxFamilyMembers = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.gpBox = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gpBoxSearch.SuspendLayout();
            this.gpBoxFamily.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpBoxFamilyMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.gpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuFile,
            this.tsMenuLanguage});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // tsMenuFile
            // 
            this.tsMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuExit});
            this.tsMenuFile.Name = "tsMenuFile";
            resources.ApplyResources(this.tsMenuFile, "tsMenuFile");
            // 
            // tsMenuExit
            // 
            this.tsMenuExit.Name = "tsMenuExit";
            resources.ApplyResources(this.tsMenuExit, "tsMenuExit");
            this.tsMenuExit.Click += new System.EventHandler(this.tsMenuExit_Click);
            // 
            // tsMenuLanguage
            // 
            this.tsMenuLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenu_EN,
            this.tsMenu_zh_CN});
            this.tsMenuLanguage.Name = "tsMenuLanguage";
            resources.ApplyResources(this.tsMenuLanguage, "tsMenuLanguage");
            // 
            // tsMenu_EN
            // 
            this.tsMenu_EN.Name = "tsMenu_EN";
            resources.ApplyResources(this.tsMenu_EN, "tsMenu_EN");
            // 
            // tsMenu_zh_CN
            // 
            this.tsMenu_zh_CN.Name = "tsMenu_zh_CN";
            resources.ApplyResources(this.tsMenu_zh_CN, "tsMenu_zh_CN");
            // 
            // gpBoxSearch
            // 
            resources.ApplyResources(this.gpBoxSearch, "gpBoxSearch");
            this.gpBoxSearch.Controls.Add(this.btnSearch);
            this.gpBoxSearch.Controls.Add(this.txtNO);
            this.gpBoxSearch.Controls.Add(this.txtCard);
            this.gpBoxSearch.Controls.Add(this.txtName);
            this.gpBoxSearch.Controls.Add(this.lblNo);
            this.gpBoxSearch.Controls.Add(this.lblCard);
            this.gpBoxSearch.Controls.Add(this.lblName);
            this.gpBoxSearch.Controls.Add(this.txtCity);
            this.gpBoxSearch.Controls.Add(this.lblCity);
            this.gpBoxSearch.Name = "gpBoxSearch";
            this.gpBoxSearch.TabStop = false;
            // 
            // treeViewCity
            // 
            resources.ApplyResources(this.treeViewCity, "treeViewCity");
            this.treeViewCity.Name = "treeViewCity";
            this.treeViewCity.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            ((System.Windows.Forms.TreeNode)(resources.GetObject("treeViewCity.Nodes")))});
            // 
            // lblCity
            // 
            resources.ApplyResources(this.lblCity, "lblCity");
            this.lblCity.Name = "lblCity";
            // 
            // txtCity
            // 
            resources.ApplyResources(this.txtCity, "txtCity");
            this.txtCity.Name = "txtCity";
            this.txtCity.Click += new System.EventHandler(this.txtCity_Click);
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // lblCard
            // 
            resources.ApplyResources(this.lblCard, "lblCard");
            this.lblCard.Name = "lblCard";
            // 
            // lblNo
            // 
            resources.ApplyResources(this.lblNo, "lblNo");
            this.lblNo.Name = "lblNo";
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            // 
            // txtCard
            // 
            resources.ApplyResources(this.txtCard, "txtCard");
            this.txtCard.Name = "txtCard";
            // 
            // txtNO
            // 
            resources.ApplyResources(this.txtNO, "txtNO");
            this.txtNO.Name = "txtNO";
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // gpBoxFamily
            // 
            this.gpBoxFamily.Controls.Add(this.label17);
            this.gpBoxFamily.Controls.Add(this.label18);
            this.gpBoxFamily.Controls.Add(this.label13);
            this.gpBoxFamily.Controls.Add(this.label14);
            this.gpBoxFamily.Controls.Add(this.label15);
            this.gpBoxFamily.Controls.Add(this.label16);
            this.gpBoxFamily.Controls.Add(this.label11);
            this.gpBoxFamily.Controls.Add(this.label12);
            this.gpBoxFamily.Controls.Add(this.label9);
            this.gpBoxFamily.Controls.Add(this.label10);
            this.gpBoxFamily.Controls.Add(this.label7);
            this.gpBoxFamily.Controls.Add(this.label6);
            this.gpBoxFamily.Controls.Add(this.label5);
            this.gpBoxFamily.Controls.Add(this.label4);
            this.gpBoxFamily.Controls.Add(this.label3);
            this.gpBoxFamily.Controls.Add(this.label2);
            this.gpBoxFamily.Controls.Add(this.label1);
            this.gpBoxFamily.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.gpBoxFamily, "gpBoxFamily");
            this.gpBoxFamily.Name = "gpBoxFamily";
            this.gpBoxFamily.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // gpBoxFamilyMembers
            // 
            this.gpBoxFamilyMembers.Controls.Add(this.pictureBox3);
            this.gpBoxFamilyMembers.Controls.Add(this.dataGridView1);
            this.gpBoxFamilyMembers.Controls.Add(this.pictureBox2);
            resources.ApplyResources(this.gpBoxFamilyMembers, "gpBoxFamilyMembers");
            this.gpBoxFamilyMembers.Name = "gpBoxFamilyMembers";
            this.gpBoxFamilyMembers.TabStop = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // gpBox
            // 
            this.gpBox.Controls.Add(this.label23);
            this.gpBox.Controls.Add(this.label22);
            this.gpBox.Controls.Add(this.label21);
            this.gpBox.Controls.Add(this.label20);
            this.gpBox.Controls.Add(this.label19);
            this.gpBox.Controls.Add(this.label8);
            resources.ApplyResources(this.gpBox, "gpBox");
            this.gpBox.Name = "gpBox";
            this.gpBox.TabStop = false;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpBox);
            this.Controls.Add(this.gpBoxFamilyMembers);
            this.Controls.Add(this.gpBoxFamily);
            this.Controls.Add(this.treeViewCity);
            this.Controls.Add(this.gpBoxSearch);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpBoxSearch.ResumeLayout(false);
            this.gpBoxSearch.PerformLayout();
            this.gpBoxFamily.ResumeLayout(false);
            this.gpBoxFamily.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpBoxFamilyMembers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.gpBox.ResumeLayout(false);
            this.gpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem tsMenuFile;
        private System.Windows.Forms.ToolStripMenuItem tsMenuLanguage;
        private System.Windows.Forms.ToolStripMenuItem tsMenu_EN;
        private System.Windows.Forms.ToolStripMenuItem tsMenu_zh_CN;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsMenuExit;
        private System.Windows.Forms.GroupBox gpBoxSearch;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TreeView treeViewCity;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtNO;
        private System.Windows.Forms.TextBox txtCard;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox gpBoxFamily;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gpBoxFamilyMembers;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox gpBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label8;
    }
}