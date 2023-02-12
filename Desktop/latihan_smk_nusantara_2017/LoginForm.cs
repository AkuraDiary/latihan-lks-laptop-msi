using latihan_smk_nusantara_2017.data;
using latihan_smk_nusantara_2017.ui.notifier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace latihan_smk_nusantara_2017
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            //TODO DO Login
            if (formIsValid())
            {
                AuthNotifier.doLogin(edtUsername.Text, edtPassword.Text);
                if (Repository.loggedInUser != null)
                {
                    moveToMainForm();
                }
                else
                {
                    MessageBox.Show("Account Not Found");
                }
                
            }
        }

        bool formIsValid()
        {
            if (string.IsNullOrEmpty(edtUsername.Text))
            {
                MessageBox.Show("Username can't Be empty");
                return false;
            }
            else if (string.IsNullOrEmpty(edtPassword.Text))
            {
                MessageBox.Show("Password can't Be empty");
                return false;
            }
            else
            {
                return true;
            }
        }

void        moveToMainForm()
        {
            this.Hide();
            MainForm mainF = new MainForm();
            mainF.Show();
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) {
                btnLogin.PerformClick();
            }
        }
    }
}
