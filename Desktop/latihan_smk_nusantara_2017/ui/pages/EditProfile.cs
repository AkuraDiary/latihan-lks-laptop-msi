using latihan_smk_nusantara_2017.data;
using latihan_smk_nusantara_2017.data.source.model;
using latihan_smk_nusantara_2017.ui.notifier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace latihan_smk_nusantara_2017.ui.pages
{
    public partial class EditProfile : Form
    {
        Image img;
        user currentUser = Repository.loggedInUser;
        public EditProfile()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearField();
            backToMainForm();
           
        }

        private void backToMainForm()
        {
            //back to main form
            this.Hide();
            MainForm mainform = new MainForm();
            mainform.Show();
        }
        private void picboxImgStudent_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (formIsValid())
            {
                extractForm();
                AdminNotifier.updaetUser(currentUser);
                backToMainForm();
            }
            
        }

        #region helper
        private void bindCurentUserData()
        {
            edtAddress.Text = currentUser.address;
            edtName.Text = currentUser.name;
            edtPhoneNumber.Text = currentUser.no_hp;
            lblStudentId.Text = currentUser.user_id;

            if (currentUser.photo != null)
            {
                MemoryStream imgStream = new MemoryStream(currentUser.photo);
                picboxImgProfile.Image = Image.FromStream(imgStream);

            }
            
        }
        private void extractForm()
        {
            //user userModel = new user();
            
            currentUser.address = edtAddress.Text;
            currentUser.name  = edtName.Text ;
            currentUser.no_hp =  edtPhoneNumber.Text ;

            if (picboxImgProfile.Image != null)
            {
                ImageConverter imageConverter = new ImageConverter();
                currentUser.photo = (byte[])imageConverter.ConvertTo(picboxImgProfile.Image, typeof(byte[]));
            }

            //return userModel;
        }


        bool formIsValid()
        {
            if (string.IsNullOrEmpty(edtName.Text))
            {
                MessageBox.Show("Name can't Be empty");
                return false;
            }
            else if (string.IsNullOrEmpty(edtAddress.Text))
            {
                MessageBox.Show("Address can't Be empty");
                return false;
            }
            else if (string.IsNullOrEmpty(edtPhoneNumber.Text))
            {
                MessageBox.Show("Gender can't Be empty");
                return false;
            }
            else if (string.IsNullOrEmpty(dtpDoB.Text))
            {
                MessageBox.Show("Student can't Be empty, pls generate one");
                return false;
            }
            else if (string.IsNullOrEmpty(edtPhoneNumber.Text))
            {
                MessageBox.Show("Phone Number can't be empty ");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void clearField()
        {
           
            picboxImgProfile.Image= null;
            edtName.Text = "";
            edtPhoneNumber.Text = "";
            edtAddress.Text = "";
            
        }

        #endregion

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string filename = openFileDialog.FileName;
            img = Image.FromFile(filename);
            picboxImgProfile.Image = img;
            
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            bindCurentUserData();
        }
    }
}
