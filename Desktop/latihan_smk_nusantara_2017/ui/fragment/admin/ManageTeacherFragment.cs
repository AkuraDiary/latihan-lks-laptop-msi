using latihan_smk_nusantara_2017.data.source.model;
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

namespace latihan_smk_nusantara_2017.ui.fragment.admin
{
    public partial class ManageTeacherFragment : UserControl
    {
        user selectedTeacher = null;
        public ManageTeacherFragment()
        {
            InitializeComponent();
        }

        private void teachersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (teachersDataGridView.SelectedRows.Count > 0)
            {
                btnGenerateId.Enabled = false;
                btnInsert.Enabled = false;
                selectedTeacher = new user();
                foreach (DataGridViewRow row in teachersDataGridView.SelectedRows)
                {
                    selectedTeacher.user_id = row.Cells["user_id"].Value.ToString();
                    selectedTeacher.name = row.Cells["name"].Value.ToString();
                    selectedTeacher.gender = row.Cells["gender"].Value.ToString();
                    selectedTeacher.address = row.Cells["address"].Value.ToString();
                    selectedTeacher.date_of_birth = (DateTime)row.Cells["date_of_birth"].Value;
                    selectedTeacher.no_hp = row.Cells["no_hp"].Value.ToString();

                }
                bindSelectedTeacherDat();

            }
        }

        #region logic
        private void setupTeacherDataGridView()
        {
            clearField();
            teachersDataGridView.Refresh();
            teachersDataGridView.ClearSelection();
            AdminNotifier.getAllUserData();
            teachersDataGridView.DataSource = AdminNotifier.listTeacher;
        }

        private void addTeacher()
        {
            user model = extractForm();
            AdminNotifier.addNewUser(model);
            setupTeacherDataGridView();

        }

        private void removeTeacher()
        {
            AdminNotifier.removeUser(edtTeacherID.Text);
            setupTeacherDataGridView();

        }

        private void updateTeacher()
        {
            user model = extractForm();
            AdminNotifier.updaetUser(model);
            setupTeacherDataGridView();
        }
        #endregion

        #region helperss

        private void bindSelectedTeacherDat()
        {
            edtName.Text = selectedTeacher.name;
            edtGender.Text = selectedTeacher.gender;
            edtAddress.Text = selectedTeacher.address;
            edtTeacherID.Text = selectedTeacher.user_id;
            edtPhoneNumber.Text = selectedTeacher.no_hp;
            dtpDoB.Value = selectedTeacher.date_of_birth;
        }
        private user extractForm()
        {
            user model = new user();

            model.name = edtName.Text;
            model.gender = edtGender.Text;
            model.address = edtAddress.Text;
            model.user_id = edtTeacherID.Text;

            if (selectedTeacher == null)
            {
                model.password = edtTeacherID.Text;
                model.username = edtName.Text;
            }


            model.no_hp = edtPhoneNumber.Text;
            model.date_of_birth = dtpDoB.Value;
            model.role_id = 2; // default role for teacher
            return model;
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
            else if (string.IsNullOrEmpty(edtGender.Text))
            {
                MessageBox.Show("Gender can't Be empty");
                return false;
            }
            else if (string.IsNullOrEmpty(edtTeacherID.Text))
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
            btnGenerateId.Enabled = true;
            btnInsert.Enabled = true;
            teachersDataGridView.ClearSelection();
            selectedTeacher = null;

            edtName.Text = "";
            edtGender.Text = "";
            edtAddress.Text = "";
            edtTeacherID.Text = "";
            edtPhoneNumber.Text = "";
        }

        #endregion


        #region buttonssss
        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearField();
        }

        private void btnGenerateId_Click(object sender, EventArgs e)
        {
            edtTeacherID.Text = Utils.generateIdFor("teacher");
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (formIsValid())
            {
                addTeacher();
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            removeTeacher();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (formIsValid())
            {
                if (selectedTeacher != null)
                {
                    updateTeacher();
                }
                else
                {
                    addTeacher();
                }
            }
            
        }
        #endregion

        private void ManageTeacherFragment_Load(object sender, EventArgs e)
        {
            setupTeacherDataGridView();
        }
    }
}
