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

namespace latihan_smk_nusantara_2017.ui.fragment
{
    public partial class ClassScheduleFragment : UserControl
    {
        subject selectedSubject = null;
        public ClassScheduleFragment()
        {
            InitializeComponent();
        }

        private void ClassScheduleFragment_Load(object sender, EventArgs e)
        {
            setupStudentDataGridView();
        }

        private void setupStudentDataGridView()
        {
            
            classScheduleDataGridView.Refresh();
            classScheduleDataGridView.ClearSelection();
            StudentNotifier.getScheduleData(Repository.loggedInUser.user_id);

            foreach (student_multi_schedule item in StudentNotifier.listSchedule)
            {
                string teacher_id = item.header_schedule.teacher_id;
                string class_id = item.header_schedule.class_id;
                classScheduleDataGridView.Rows.Add(
                    item.header_schedule.subject_id,//subject id,
                    item.header_schedule.subject.name,//subject,
                    Repository.db.classes.Find(class_id).name,//class name,
                    Repository.db.users.Find(teacher_id).name//teacher

                    ) ;

            }

        }

        private void btnViewSubjectInfo_Click(object sender, EventArgs e)
        {
            if (selectedSubject != null)
            {
                string message = selectedSubject.description + "\n\n" +
                    "Composition Assignment\n" +
                    "Assignment : " + selectedSubject.assignment + "\n" +
                    "Mid Exam : " + selectedSubject.mid_exam + "\n" +
                    "Final Exam : " + selectedSubject.final_exam;
                MessageBox.Show(message, selectedSubject.name);
            }
            
        }

        private void classScheduleDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if(classScheduleDataGridView.SelectedRows.Count > 0)
            {
                
                foreach (DataGridViewRow row in classScheduleDataGridView.SelectedRows)
                {
                    selectedSubject = Repository.db.subjects.Find(row.Cells["subject_id"].Value.ToString());

                }

            }
        }
    }
}
