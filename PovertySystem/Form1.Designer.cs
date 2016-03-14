namespace PovertySystem
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("节点5");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("节点6");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("节点1", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("节点2");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("节点3");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("节点7");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("节点8");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("节点4", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("节点0", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode8});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenu_EN = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenu_zh_CN = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtNO = new System.Windows.Forms.TextBox();
            this.txtCard = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblCard = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuFile,
            this.tsMenuLanguage,
            this.windowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(878, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsMenuFile
            // 
            this.tsMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuExit});
            this.tsMenuFile.Name = "tsMenuFile";
            this.tsMenuFile.Size = new System.Drawing.Size(39, 21);
            this.tsMenuFile.Text = "File";
            // 
            // tsMenuExit
            // 
            this.tsMenuExit.Name = "tsMenuExit";
            this.tsMenuExit.Size = new System.Drawing.Size(96, 22);
            this.tsMenuExit.Text = "Exit";
            // 
            // tsMenuLanguage
            // 
            this.tsMenuLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenu_EN,
            this.tsMenu_zh_CN});
            this.tsMenuLanguage.Name = "tsMenuLanguage";
            this.tsMenuLanguage.Size = new System.Drawing.Size(77, 21);
            this.tsMenuLanguage.Text = "Language";
            // 
            // tsMenu_EN
            // 
            this.tsMenu_EN.Name = "tsMenu_EN";
            this.tsMenu_EN.Size = new System.Drawing.Size(152, 22);
            this.tsMenu_EN.Text = "en";
            // 
            // tsMenu_zh_CN
            // 
            this.tsMenu_zh_CN.Name = "tsMenu_zh_CN";
            this.tsMenu_zh_CN.Size = new System.Drawing.Size(152, 22);
            this.tsMenu_zh_CN.Text = "zh_CN";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 28);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点5";
            treeNode1.Text = "节点5";
            treeNode2.Name = "节点6";
            treeNode2.Text = "节点6";
            treeNode3.Name = "节点1";
            treeNode3.Text = "节点1";
            treeNode4.Name = "节点2";
            treeNode4.Text = "节点2";
            treeNode5.Name = "节点3";
            treeNode5.Text = "节点3";
            treeNode6.Name = "节点7";
            treeNode6.Text = "节点7";
            treeNode7.Name = "节点8";
            treeNode7.Text = "节点8";
            treeNode8.Name = "节点4";
            treeNode8.Text = "节点4";
            treeNode9.Name = "节点0";
            treeNode9.Text = "节点0";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9});
            this.treeView1.Size = new System.Drawing.Size(168, 620);
            this.treeView1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtCard);
            this.groupBox1.Controls.Add(this.txtNO);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblCard);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblNo);
            this.groupBox1.Location = new System.Drawing.Point(186, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 54);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜索条件";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(186, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(680, 560);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "结果";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(668, 534);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearch.Location = new System.Drawing.Point(599, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtNO
            // 
            this.txtNO.Location = new System.Drawing.Point(488, 20);
            this.txtNO.Name = "txtNO";
            this.txtNO.Size = new System.Drawing.Size(99, 21);
            this.txtNO.TabIndex = 14;
            // 
            // txtCard
            // 
            this.txtCard.Location = new System.Drawing.Point(263, 20);
            this.txtCard.Name = "txtCard";
            this.txtCard.Size = new System.Drawing.Size(175, 21);
            this.txtCard.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(53, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(145, 21);
            this.txtName.TabIndex = 12;
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNo.Location = new System.Drawing.Point(459, 24);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(23, 12);
            this.lblNo.TabIndex = 11;
            this.lblNo.Text = "NO:";
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCard.Location = new System.Drawing.Point(222, 24);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(35, 12);
            this.lblCard.TabIndex = 10;
            this.lblCard.Text = "Card:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblName.Location = new System.Drawing.Point(12, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 12);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name:";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(67, 21);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 660);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsMenuFile;
        private System.Windows.Forms.ToolStripMenuItem tsMenuExit;
        private System.Windows.Forms.ToolStripMenuItem tsMenuLanguage;
        private System.Windows.Forms.ToolStripMenuItem tsMenu_EN;
        private System.Windows.Forms.ToolStripMenuItem tsMenu_zh_CN;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtCard;
        private System.Windows.Forms.TextBox txtNO;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblNo;
    }
}

