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
    public partial class TeachingScheduleFragment : UserControl
    {
        subject selectedSubject = null;
        public TeachingScheduleFragment()
        {
            InitializeComponent();
        }

        private void btnViewSubjectInfo_Click(object sender, EventArgs e)
        {
            if (selectedSubject != null)
            {
                MessageBox.Show(selectedSubject.description, selectedSubject.name);
            }

        }

        private void setupTeachingSchedulaDataGridView()
        {
            teachingScheduleDataGridView.ClearSelection();
            teachingScheduleDataGridView.Refresh();

            TeacherNotifier.getTeacherSchedule(Repository.loggedInUser.user_id);
            List<header_schedule> teaching_schedules = TeacherNotifier.teacherSchedules;

            teachingScheduleDataGridView.Rows.Clear();
            foreach (header_schedule item in teaching_schedules)
            {
                teachingScheduleDataGridView.Rows.Add(
                    item.schedule_id,
                    item.subject_id,
                    item.subject.name,
                    item.@class.name
                );
            }
            
        }

        private void setupEnrolledStudentList(int schedule_id)
        {
            studentListDataGridView.ClearSelection();
               studentListDataGridView.Refresh();
            TeacherNotifier.getEnrolledStudents(schedule_id);
            studentListDataGridView.DataSource = TeacherNotifier.enrolledStudents;
        }

        private void teachingScheduleDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (teachingScheduleDataGridView.SelectedRows.Count > 0)
            {

                foreach (DataGridViewRow row in teachingScheduleDataGridView.SelectedRows)
                {
                    selectedSubject = Repository.db.subjects.Find(row.Cells["subject_id"].Value.ToString());
                    setupEnrolledStudentList((int)row.Cells["schedule_id"].Value);
                }

            }
        }

        private void TeachingScheduleFragment_Load(object sender, EventArgs e)
        {
            setupTeachingSchedulaDataGridView();    
        }
    }
}
