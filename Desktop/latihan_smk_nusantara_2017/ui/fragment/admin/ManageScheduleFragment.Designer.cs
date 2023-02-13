namespace latihan_smk_nusantara_2017.ui.fragment.admin
{
    partial class ManageScheduleFragment
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
            this.components = new System.ComponentModel.Container();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.edtSubjectId = new System.Windows.Forms.ComboBox();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.scheduleListDataGridView = new System.Windows.Forms.DataGridView();
            this.schedule_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edtDay = new System.Windows.Forms.ComboBox();
            this.edtTime = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpSchedule = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.lblScheduleId = new System.Windows.Forms.Label();
            this.edtTeacherId = new System.Windows.Forms.ComboBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.edtClassId = new System.Windows.Forms.ComboBox();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(636, 654);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 35);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(502, 654);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(128, 35);
            this.btnInsert.TabIndex = 52;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.Location = new System.Drawing.Point(605, 603);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 35);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(319, 654);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(172, 35);
            this.btnSave.TabIndex = 50;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // edtSubjectId
            // 
            this.edtSubjectId.AutoCompleteCustomSource.AddRange(new string[] {
            "laki-laki",
            "perempuan",
            "laki-laki",
            "perempuan"});
            this.edtSubjectId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.edtSubjectId.DataSource = this.subjectBindingSource;
            this.edtSubjectId.DisplayMember = "subject_id";
            this.edtSubjectId.FormattingEnabled = true;
            this.edtSubjectId.Location = new System.Drawing.Point(453, 406);
            this.edtSubjectId.Name = "edtSubjectId";
            this.edtSubjectId.Size = new System.Drawing.Size(274, 21);
            this.edtSubjectId.TabIndex = 70;
            this.edtSubjectId.ValueMember = "subject_id";
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataSource = typeof(latihan_smk_nusantara_2017.data.source.model.subject);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(316, 505);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 60;
            this.label6.Text = "Class ID";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(316, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 58;
            this.label4.Text = "Subject ID";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 57;
            this.label2.Text = "Teacher ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(10, 22);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(186, 25);
            this.lblWelcome.TabIndex = 55;
            this.lblWelcome.Text = "Manage Schedule";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scheduleListDataGridView
            // 
            this.scheduleListDataGridView.AllowUserToAddRows = false;
            this.scheduleListDataGridView.AllowUserToDeleteRows = false;
            this.scheduleListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.scheduleListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.schedule_id,
            this.subject_id,
            this.subject,
            this.teacher_id,
            this.teacher_name,
            this.class_id,
            this.class_name,
            this.date_time});
            this.scheduleListDataGridView.Location = new System.Drawing.Point(15, 60);
            this.scheduleListDataGridView.Name = "scheduleListDataGridView";
            this.scheduleListDataGridView.ReadOnly = true;
            this.scheduleListDataGridView.Size = new System.Drawing.Size(1083, 232);
            this.scheduleListDataGridView.TabIndex = 54;
            this.scheduleListDataGridView.SelectionChanged += new System.EventHandler(this.scheduleListDataGridView_SelectionChanged);
            // 
            // schedule_id
            // 
            this.schedule_id.DataPropertyName = "schedule_id";
            this.schedule_id.HeaderText = "schedule id";
            this.schedule_id.Name = "schedule_id";
            this.schedule_id.ReadOnly = true;
            // 
            // subject_id
            // 
            this.subject_id.DataPropertyName = "subject_id";
            this.subject_id.HeaderText = "subject id";
            this.subject_id.Name = "subject_id";
            this.subject_id.ReadOnly = true;
            this.subject_id.Visible = false;
            // 
            // subject
            // 
            this.subject.HeaderText = "subject";
            this.subject.Name = "subject";
            this.subject.ReadOnly = true;
            // 
            // teacher_id
            // 
            this.teacher_id.DataPropertyName = "teacher_id";
            this.teacher_id.HeaderText = "teacher id";
            this.teacher_id.Name = "teacher_id";
            this.teacher_id.ReadOnly = true;
            // 
            // teacher_name
            // 
            this.teacher_name.DataPropertyName = "teacher_name";
            this.teacher_name.HeaderText = "teacher name";
            this.teacher_name.Name = "teacher_name";
            this.teacher_name.ReadOnly = true;
            // 
            // class_id
            // 
            this.class_id.HeaderText = "class_id";
            this.class_id.Name = "class_id";
            this.class_id.ReadOnly = true;
            this.class_id.Visible = false;
            // 
            // class_name
            // 
            this.class_name.DataPropertyName = "class_name";
            this.class_name.HeaderText = "class name";
            this.class_name.Name = "class_name";
            this.class_name.ReadOnly = true;
            // 
            // date_time
            // 
            this.date_time.DataPropertyName = "date_time";
            this.date_time.HeaderText = "DateTime";
            this.date_time.Name = "date_time";
            this.date_time.ReadOnly = true;
            // 
            // edtDay
            // 
            this.edtDay.AutoCompleteCustomSource.AddRange(new string[] {
            "laki-laki",
            "perempuan"});
            this.edtDay.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.edtDay.FormattingEnabled = true;
            this.edtDay.Location = new System.Drawing.Point(824, 465);
            this.edtDay.Name = "edtDay";
            this.edtDay.Size = new System.Drawing.Size(274, 21);
            this.edtDay.TabIndex = 62;
            this.edtDay.Visible = false;
            // 
            // edtTime
            // 
            this.edtTime.AutoCompleteCustomSource.AddRange(new string[] {
            "laki-laki",
            "perempuan"});
            this.edtTime.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.edtTime.FormattingEnabled = true;
            this.edtTime.Location = new System.Drawing.Point(824, 520);
            this.edtTime.Name = "edtTime";
            this.edtTime.Size = new System.Drawing.Size(274, 21);
            this.edtTime.TabIndex = 63;
            this.edtTime.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(770, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "Day";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(764, 522);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 65;
            this.label3.Text = "Time";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(316, 562);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 66;
            this.label5.Text = "Day";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpSchedule
            // 
            this.dtpSchedule.Location = new System.Drawing.Point(453, 559);
            this.dtpSchedule.Name = "dtpSchedule";
            this.dtpSchedule.Size = new System.Drawing.Size(274, 20);
            this.dtpSchedule.TabIndex = 67;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(316, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 68;
            this.label7.Text = "Schedule Id";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScheduleId
            // 
            this.lblScheduleId.AutoSize = true;
            this.lblScheduleId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduleId.Location = new System.Drawing.Point(450, 370);
            this.lblScheduleId.Name = "lblScheduleId";
            this.lblScheduleId.Size = new System.Drawing.Size(78, 16);
            this.lblScheduleId.TabIndex = 69;
            this.lblScheduleId.Text = "Schedule Id";
            this.lblScheduleId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edtTeacherId
            // 
            this.edtTeacherId.AutoCompleteCustomSource.AddRange(new string[] {
            "laki-laki",
            "perempuan"});
            this.edtTeacherId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.edtTeacherId.DataSource = this.userBindingSource;
            this.edtTeacherId.DisplayMember = "user_id";
            this.edtTeacherId.FormattingEnabled = true;
            this.edtTeacherId.Location = new System.Drawing.Point(453, 449);
            this.edtTeacherId.Name = "edtTeacherId";
            this.edtTeacherId.Size = new System.Drawing.Size(274, 21);
            this.edtTeacherId.TabIndex = 71;
            this.edtTeacherId.ValueMember = "user_id";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(latihan_smk_nusantara_2017.data.source.model.user);
            // 
            // edtClassId
            // 
            this.edtClassId.AutoCompleteCustomSource.AddRange(new string[] {
            "laki-laki",
            "perempuan",
            "laki-laki",
            "perempuan"});
            this.edtClassId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.edtClassId.DataSource = this.classBindingSource;
            this.edtClassId.DisplayMember = "class_id";
            this.edtClassId.FormattingEnabled = true;
            this.edtClassId.Location = new System.Drawing.Point(453, 500);
            this.edtClassId.Name = "edtClassId";
            this.edtClassId.Size = new System.Drawing.Size(274, 21);
            this.edtClassId.TabIndex = 72;
            this.edtClassId.ValueMember = "class_id";
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataSource = typeof(latihan_smk_nusantara_2017.data.source.model.@class);
            // 
            // ManageScheduleFragment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.edtClassId);
            this.Controls.Add(this.edtTeacherId);
            this.Controls.Add(this.lblScheduleId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpSchedule);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edtTime);
            this.Controls.Add(this.edtDay);
            this.Controls.Add(this.edtSubjectId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.scheduleListDataGridView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "ManageScheduleFragment";
            this.Size = new System.Drawing.Size(1110, 755);
            this.Load += new System.EventHandler(this.ManageScheduleFragment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.DataGridView scheduleListDataGridView;
        private System.Windows.Forms.ComboBox edtDay;
        private System.Windows.Forms.ComboBox edtTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpSchedule;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblScheduleId;

        private System.Windows.Forms.ComboBox edtTeacherId;
        private System.Windows.Forms.ComboBox edtSubjectId;
        private System.Windows.Forms.ComboBox edtClassId;
        private System.Windows.Forms.BindingSource classBindingSource;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn schedule_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_time;
    }
}
