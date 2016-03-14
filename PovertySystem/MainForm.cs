using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PovertySystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void tsMenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtCity_Click(object sender, EventArgs e)
        {
            this.treeViewCity.Visible = true;
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            this.treeViewCity.Visible = false;
        }
    }
}
