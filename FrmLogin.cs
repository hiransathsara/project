using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmploeeMgmtSys
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        // go to Register form
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegister frmRegister = new FrmRegister();
            frmRegister.Show();
        }

        //text boxes clear
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        //show password
        private void chBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxShowPassword.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else {
                txtPassword.UseSystemPasswordChar = true;
            }

        }

        private void lblUserGuide_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btnUserGuide_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmUserGuide frmUserGuide = new FrmUserGuide();
            frmUserGuide.Show();
        }
    }
}
