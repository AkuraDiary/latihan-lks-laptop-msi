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
    public partial class ManageStudentFragment : UserControl
    {
        user selectedStudent = null;
        public ManageStudentFragment()
        {
            InitializeComponent();
        }

        private void ManageStudentFragment_Load(object sender, EventArgs e)
        {
            setupStudentDataGridView();
        }

      

        private void studentsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (studentsDataGridView.SelectedRows.Count > 0)
            {
                btnGenerateId.Enabled = false;
                btnInsert.Enabled = false;
                selectedStudent = new user();
                foreach (DataGridViewRow row in studentsDataGridView.SelectedRows)
                {
                    selectedStudent.user_id = row.Cells["user_id"].Value.ToString();
                    selectedStudent.name = row.Cells["name"].Value.ToString();
                    selectedStudent.gender = row.Cells["gender"].Value.ToString();
                    selectedStudent.address = row.Cells["address"].Value.ToString();
                    selectedStudent.date_of_birth = (DateTime)row.Cells["date_of_birth"].Value;
                    selectedStudent.no_hp= row.Cells["no_hp"].Value.ToString();
                    
                }
                bindSelectedStudentDat();

            }
        }

        #region logic
        private void setupStudentDataGridView()
        {
            clearField();
            studentsDataGridView.Refresh();
            studentsDataGridView.ClearSelection();
            AdminNotifier.getAllUserData();
            studentsDataGridView.DataSource = AdminNotifier.listStudent;
        }

        private void addStudent()
        {
            user studentModel = extractForm() ;
            AdminNotifier.addNewUser(studentModel);
            setupStudentDataGridView(); 

        }

        private void removeStudent()
        {
            AdminNotifier.removeUser(edtStudentID.Text);
            setupStudentDataGridView();

        }

        private void updateStudent()
        {
            user studentModel = extractForm();
            AdminNotifier.updaetUser(studentModel);
            setupStudentDataGridView();
        }
        #endregion

        #region helperss

        private void bindSelectedStudentDat()
        {
            

            edtName.Text = selectedStudent.name;
            edtGender.Text = selectedStudent.gender;
            edtAddress.Text = selectedStudent.address;
            edtStudentID.Text = selectedStudent.user_id;
            edtPhoneNumber.Text = selectedStudent.no_hp;
            dtpDoB.Value = selectedStudent.date_of_birth;
        }
        private user extractForm()
        {
            user studentModel = new user();

            studentModel.name  = edtName.Text;
            studentModel.gender = edtGender.Text ;
            studentModel.address = edtAddress.Text;
            studentModel.user_id = edtStudentID.Text;

            if(selectedStudent == null)
            {
                studentModel.password = edtStudentID.Text;
                studentModel.username = edtName.Text;
            }
            

            studentModel.no_hp = edtPhoneNumber.Text;
            studentModel.date_of_birth = dtpDoB.Value;
            studentModel.role_id = 3; // default role for student
            return studentModel;
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
            else if (string.IsNullOrEmpty(edtStudentID.Text))
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
            studentsDataGridView.ClearSelection();
            selectedStudent = null;

            edtName.Text = "";
            edtGender.Text = "";
            edtAddress.Text = "";
            edtStudentID.Text = "";
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
            edtStudentID.Text = Utils.generateIdFor("student");
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            addStudent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            removeStudent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectedStudent != null)
            {
                updateStudent();
            }
            else
            {
                addStudent();
            }
        }
        #endregion


    }
}
