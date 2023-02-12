namespace latihan_smk_nusantara_2017.ui.fragment
{
    partial class ClassScheduleFragment
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnViewSubjectInfo = new System.Windows.Forms.Button();
            this.classScheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.subject_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.classScheduleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewSubjectInfo
            // 
            this.btnViewSubjectInfo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnViewSubjectInfo.FlatAppearance.BorderSize = 0;
            this.btnViewSubjectInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSubjectInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSubjectInfo.ForeColor = System.Drawing.Color.White;
            this.btnViewSubjectInfo.Location = new System.Drawing.Point(434, 675);
            this.btnViewSubjectInfo.Name = "btnViewSubjectInfo";
            this.btnViewSubjectInfo.Size = new System.Drawing.Size(193, 35);
            this.btnViewSubjectInfo.TabIndex = 13;
            this.btnViewSubjectInfo.Text = "View Subject Info";
            this.btnViewSubjectInfo.UseVisualStyleBackColor = false;
            // 
            // classScheduleDataGridView
            // 
            this.classScheduleDataGridView.AllowUserToAddRows = false;
            this.classScheduleDataGridView.AllowUserToDeleteRows = false;
            this.classScheduleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.classScheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classScheduleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subject_id,
            this.subject,
            this.class_name,
            this.teacher_name});
            this.classScheduleDataGridView.Location = new System.Drawing.Point(16, 72);
            this.classScheduleDataGridView.Name = "classScheduleDataGridView";
            this.classScheduleDataGridView.ReadOnly = true;
            this.classScheduleDataGridView.Size = new System.Drawing.Size(1083, 331);
            this.classScheduleDataGridView.TabIndex = 12;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(11, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(154, 25);
            this.lblWelcome.TabIndex = 11;
            this.lblWelcome.Text = "View Schedule";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subject_id
            // 
            this.subject_id.HeaderText = "Subject ID";
            this.subject_id.Name = "subject_id";
            this.subject_id.ReadOnly = true;
            // 
            // subject
            // 
            this.subject.HeaderText = "Subject";
            this.subject.Name = "subject";
            this.subject.ReadOnly = true;
            // 
            // class_name
            // 
            this.class_name.HeaderText = "Class";
            this.class_name.Name = "class_name";
            this.class_name.ReadOnly = true;
            // 
            // teacher_name
            // 
            this.teacher_name.HeaderText = "Teacher";
            this.teacher_name.Name = "teacher_name";
            this.teacher_name.ReadOnly = true;
            // 
            // ClassScheduleFragment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnViewSubjectInfo);
            this.Controls.Add(this.classScheduleDataGridView);
            this.Controls.Add(this.lblWelcome);
            this.Name = "ClassScheduleFragment";
            this.Size = new System.Drawing.Size(1110, 755);
            this.Load += new System.EventHandler(this.ClassScheduleFragment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classScheduleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewSubjectInfo;
        private System.Windows.Forms.DataGridView classScheduleDataGridView;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher_name;
    }
}
