using latihan_smk_nusantara_2017.data;
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
    public partial class ManageClassFragment : UserControl
    {
        user selectedEnrolledStudent = null;
        user selectedUnEnroledStudent = null;
        int current_schedule_id;
        public ManageClassFragment()
        {
            InitializeComponent();
        }

        private void ManageClassFragment_Load(object sender, EventArgs e)
        {
            edtClassname.DataSource = Repository.db.classes.ToList();
        }

        @class selectedClass = null;
        private void edtClassname_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedClass = (@class)edtClassname.SelectedItem;
            header_schedule schedule = Repository.db.header_schedule.Where(item => item.class_id == selectedClass.class_id).FirstOrDefault();

               if (schedule != null)
            {
                current_schedule_id = schedule.schedule_id;

                setupEnrolledStudentListDataGridView(current_schedule_id);
            }
            else
            {
               studentListDataGridView.ClearSelection();
                studentListDataGridView.Refresh();
                
                participateStudentDataGridView.ClearSelection();
                participateStudentDataGridView.Refresh();   
                
            }
            
        }

        private void setupStudentListDataGridView(int schedule_id) {

            studentListDataGridView.Refresh();
            studentListDataGridView.ClearSelection();
            TeacherNotifier.getUnEnrolledStudents(schedule_id);
            studentListDataGridView.DataSource = TeacherNotifier.unEnrolledStudents;
        }

        private void setupEnrolledStudentListDataGridView(int schedule_id)
        {
            TeacherNotifier.getEnrolledStudents(schedule_id);
            participateStudentDataGridView.Refresh();
            participateStudentDataGridView.ClearSelection();
            participateStudentDataGridView.DataSource= TeacherNotifier.enrolledStudents;

            setupStudentListDataGridView(schedule_id);
        }

        private void studentListDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (studentListDataGridView.SelectedRows.Count > 0)
            {

                selectedUnEnroledStudent = new user();
                foreach (DataGridViewRow row in studentListDataGridView.SelectedRows)
                {
                    selectedUnEnroledStudent.user_id = row.Cells["unenrolled_user_id"].Value.ToString();

                }
                btnAddToParticipant.Enabled = true;
                btnRemoveFromParticipant.Enabled =false ;


            }
        }

        private void participateStudentDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (participateStudentDataGridView.SelectedRows.Count > 0)
            {

                selectedEnrolledStudent = new user();
                foreach (DataGridViewRow row in participateStudentDataGridView.SelectedRows)
                {
                    selectedEnrolledStudent.user_id = row.Cells["user_id"].Value.ToString();
                
                }
                btnAddToParticipant.Enabled = false;
                btnRemoveFromParticipant.Enabled = true;
            }
        }

        private void btnAddToParticipant_Click(object sender, EventArgs e)
        {
            if (selectedUnEnroledStudent != null)
            {
               
                student_multi_schedule model= new student_multi_schedule();

                model.schedule_id = current_schedule_id;
                model.student_id = selectedUnEnroledStudent.user_id;
                
                Repository.db.student_multi_schedule.Add(model);
                Repository.db.SaveChanges(); //FOREIGN KEY CONFLICT

            }
            setupEnrolledStudentListDataGridView(current_schedule_id);
        }

        private void btnRemoveFromParticipant_Click(object sender, EventArgs e)
        {
            if (selectedEnrolledStudent != null)
            {

                student_multi_schedule studentSchedule = Repository.db.student_multi_schedule.Where(item => item.student_id.Equals(selectedEnrolledStudent.user_id) && item.schedule_id == current_schedule_id).FirstOrDefault();
                Repository.db.student_multi_schedule.Remove(studentSchedule);//.Entry(studentSchedule).State =EntityState.Deleted;
                Repository.db.SaveChanges();
            }
            setupEnrolledStudentListDataGridView(current_schedule_id);
            
        }
    }
}
