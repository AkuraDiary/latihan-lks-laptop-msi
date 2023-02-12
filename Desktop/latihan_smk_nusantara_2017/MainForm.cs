using latihan_smk_nusantara_2017.data;
using latihan_smk_nusantara_2017.ui.notifier;
using latihan_smk_nusantara_2017.ui.pages;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            setupView();
        }

        private void setupView()
        {
            lblWelcome.Text = "Welcome " + Repository.loggedInUser.name ;
            switchMode(Repository.loggedInUser.role_id);
            hideAllFragment();
        }

        private void switchMode(int role)
        {
            switch (role)
            {
                case 1:
                    adminMode();
                    break;
                case 2:
                    teacherMode();
                    break;

                case 3:
                    studentMode();
                    break;

                default:
                    MessageBox.Show("Invalid Role");
                    btnLogout.PerformClick();
                    break;
            }
        }

        #region navigation helper region
        private void hideAllNavPanel()
        {
            navPanelAdmin.Visible= false;
            navPanelGuru.Visible= false;  
            navPanelStudent.Visible= false; 
        }

        private void showNavigation(Panel navPanel) {
            hideAllNavPanel();
            navPanel.Visible= true;
        }

        private void hideAllFragment()
        {
            foreach (UserControl fragmentItem in mainFragmentContainer.Controls)
            {
                fragmentItem.Visible = false;
            }
        }

        private void showFragment(UserControl fragment) {
            hideAllFragment();
            fragment.Visible= true;
        }

        private void adminMode()
        {
            btnEditProfile.Visible= false;
            showNavigation(navPanelAdmin);
        }

        private void studentMode()
        {
            showNavigation(navPanelStudent);
        }

        private void teacherMode()
        {
            showNavigation(navPanelGuru);
        }

        #endregion

        #region button universal click event region
        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            //move to edit profile with logged in data
            this.Hide();
            EditProfile editProfile = new EditProfile();
            editProfile.Show();
        }
       

        private void btnAdminMode_Click(object sender, EventArgs e)
        {
            adminMode();
        }

        private void btnStudentMode_Click(object sender, EventArgs e)
        {
            studentMode();
        }

        private void btnGuruMode_Click(object sender, EventArgs e)
        {
            teacherMode();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //TODO call Logout function
            AuthNotifier.doLogout();
            if (Repository.loggedInUser == null)
            {
                MessageBox.Show("Success Logout");
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            
        }
        #endregion

        #region btn admin nav click
        private void btnManageStudent_Click(object sender, EventArgs e)
        {
            showFragment(manageStudentFragment);
        }

        private void btnManageTeacher_Click(object sender, EventArgs e)
        {
            showFragment(manageTeacherFragment);
        }

        private void btnManageClass_Click(object sender, EventArgs e)
        {
            showFragment(manageClassFragment);
        }

        private void btnManageSchedule_Click(object sender, EventArgs e)
        {
            showFragment(manageScheduleFragment);
        }

        #endregion

        private void btnClassSchedule_Click(object sender, EventArgs e)
        {
            showFragment(classScheduleFragment);
        }

        private void btnTeachingSchedule_Click(object sender, EventArgs e)
        {
            showFragment(teachingScheduleFragment);
        }
    }
}
