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
    public partial class ManageScheduleFragment : UserControl
    {
        header_schedule selectedSchedule = null;
        public ManageScheduleFragment()
        {
            InitializeComponent();
        }

        private void ManageScheduleFragment_Load(object sender, EventArgs e)
        {
            setupDataGridView();
            setupComboBox();
            
        }

        private void setupComboBox()
        {
            AdminNotifier.getAllUserData();
            edtClassId.DataSource = Repository.db.classes.ToList();
            edtSubjectId.DataSource = Repository.db.subjects.ToList();
            edtTeacherId.DataSource = AdminNotifier.listTeacher;
            
        }

        private void setupDataGridView()
        {
            clearField();
            scheduleListDataGridView.Refresh();
            scheduleListDataGridView.ClearSelection();
            AdminNotifier.getAllSchedule();

            scheduleListDataGridView.Rows.Clear();
            foreach (header_schedule item in AdminNotifier.listSchedule)
            {
                scheduleListDataGridView.Rows.Add(
                    item.schedule_id,
                    item.subject.subject_id,
                    item.subject.name,
                    item.teacher_id,
                    Repository.db.users.Find(item.teacher_id).name,
                    item.@class.class_id,
                    item.@class.name
                    );
            }

            
        }

        private header_schedule extractForm()
        {
            header_schedule headerSchedule = new header_schedule();
            headerSchedule.teacher_id = edtTeacherId.SelectedValue.ToString();
            headerSchedule.subject_id = edtSubjectId.SelectedValue.ToString();
            headerSchedule.class_id = edtClassId.SelectedValue.ToString();

            return headerSchedule;
           
        }


        bool formIsValid()
        {
            if (string.IsNullOrEmpty(edtSubjectId.Text))
            {
                MessageBox.Show("Subject Id can't Be empty");
                return false;
            }
            else if (string.IsNullOrEmpty(edtTeacherId.Text))
            {
                MessageBox.Show("Teacher Id can't Be empty");
                return false;
            }
            else if (string.IsNullOrEmpty(edtClassId.Text))
            {
                MessageBox.Show("Class ID can't Be empty");
                return false;
            }
            
            else
            {
                return true;
            }
        }

        private void clearField()
        {
            
            btnInsert.Enabled = true;
            scheduleListDataGridView.ClearSelection();
            selectedSchedule = null;

            lblScheduleId.Text = "";
         edtClassId.SelectedItem= null;
         edtTeacherId.SelectedItem= null;
         edtSubjectId.SelectedItem= null;
        }

        private void bindSelectedScheduleData()
        {
            lblScheduleId.Text = selectedSchedule.schedule_id.ToString();
            
            edtClassId.SelectedValue= selectedSchedule.class_id;
            edtSubjectId.SelectedValue= selectedSchedule.subject_id;
            edtTeacherId.SelectedValue= selectedSchedule.teacher_id;
            
            //dtpSchedule.Value = selectedSchedule.date; TODO
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearField();
        }

     
        private void btnInsert_Click(object sender, EventArgs e)
        {
            addSchedule();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            removeSchedule();
        }

        private void removeSchedule()
        {
            AdminNotifier.removeSchedule(selectedSchedule.schedule_id);
            setupDataGridView(); 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectedSchedule != null)
            {
                updateSchedule();
                
            }
            else
            {
                addSchedule();
            }
        }

        private void updateSchedule()
        {
            header_schedule scheduleModel = extractForm();
            scheduleModel.schedule_id = selectedSchedule.schedule_id;
            
            AdminNotifier.updateSchedule(scheduleModel);
            setupDataGridView();
        }

        private void addSchedule()
        {
            header_schedule scheduleModel = extractForm();
            AdminNotifier.addNewSchedule(scheduleModel);
            setupDataGridView();
        }

 

        private void scheduleListDataGridView_SelectionChanged(object sender, EventArgs e)
        {

            if (scheduleListDataGridView.SelectedRows.Count > 0)
            {
                
                selectedSchedule = new header_schedule();
                foreach (DataGridViewRow row in scheduleListDataGridView.SelectedRows)
                {
                    selectedSchedule.schedule_id=(int) row.Cells["schedule_id"].Value;
                    selectedSchedule.subject_id= row.Cells["subject_id"].Value.ToString();
                    selectedSchedule.teacher_id= row.Cells["teacher_id"].Value.ToString();
                    selectedSchedule.class_id= row.Cells["class_id"].Value.ToString();
                    
                }
               
                bindSelectedScheduleData();

            }
        }
    }
}
