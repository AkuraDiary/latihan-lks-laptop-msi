namespace latihan_smk_nusantara_2017
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.navPanelGuru = new System.Windows.Forms.Panel();
            this.btnTeachingSchedule = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.mainFragmentContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.teachingScheduleFragment = new latihan_smk_nusantara_2017.ui.fragment.TeachingScheduleFragment();
            this.classScheduleFragment = new latihan_smk_nusantara_2017.ui.fragment.ClassScheduleFragment();
            this.manageScheduleFragment = new latihan_smk_nusantara_2017.ui.fragment.admin.ManageScheduleFragment();
            this.manageClassFragment = new latihan_smk_nusantara_2017.ui.fragment.admin.ManageClassFragment();
            this.manageTeacherFragment = new latihan_smk_nusantara_2017.ui.fragment.admin.ManageTeacherFragment();
            this.manageStudentFragment = new latihan_smk_nusantara_2017.ui.fragment.admin.ManageStudentFragment();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.navPanelStudent = new System.Windows.Forms.Panel();
            this.btnClassSchedule = new System.Windows.Forms.Button();
            this.navPanelAdmin = new System.Windows.Forms.Panel();
            this.btnManageSchedule = new System.Windows.Forms.Button();
            this.btnManageClass = new System.Windows.Forms.Button();
            this.btnManageTeacher = new System.Windows.Forms.Button();
            this.btnManageStudent = new System.Windows.Forms.Button();
            this.btnAdminMode = new System.Windows.Forms.Button();
            this.btnGuruMode = new System.Windows.Forms.Button();
            this.btnStudentMode = new System.Windows.Forms.Button();
            this.navPanelGuru.SuspendLayout();
            this.mainFragmentContainer.SuspendLayout();
            this.navPanelStudent.SuspendLayout();
            this.navPanelAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // navPanelGuru
            // 
            this.navPanelGuru.BackColor = System.Drawing.Color.DodgerBlue;
            this.navPanelGuru.Controls.Add(this.btnTeachingSchedule);
            this.navPanelGuru.Location = new System.Drawing.Point(12, 52);
            this.navPanelGuru.Name = "navPanelGuru";
            this.navPanelGuru.Size = new System.Drawing.Size(216, 714);
            this.navPanelGuru.TabIndex = 0;
            // 
            // btnTeachingSchedule
            // 
            this.btnTeachingSchedule.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTeachingSchedule.FlatAppearance.BorderSize = 0;
            this.btnTeachingSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeachingSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeachingSchedule.ForeColor = System.Drawing.Color.White;
            this.btnTeachingSchedule.Location = new System.Drawing.Point(0, 3);
            this.btnTeachingSchedule.Name = "btnTeachingSchedule";
            this.btnTeachingSchedule.Size = new System.Drawing.Size(216, 35);
            this.btnTeachingSchedule.TabIndex = 6;
            this.btnTeachingSchedule.Text = "Teaching Schedule";
            this.btnTeachingSchedule.UseVisualStyleBackColor = false;
            this.btnTeachingSchedule.Click += new System.EventHandler(this.btnTeachingSchedule_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(165, 25);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Selamat Datang";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(12, 772);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(216, 35);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // mainFragmentContainer
            // 
            this.mainFragmentContainer.Controls.Add(this.teachingScheduleFragment);
            this.mainFragmentContainer.Controls.Add(this.classScheduleFragment);
            this.mainFragmentContainer.Controls.Add(this.manageScheduleFragment);
            this.mainFragmentContainer.Controls.Add(this.manageClassFragment);
            this.mainFragmentContainer.Controls.Add(this.manageTeacherFragment);
            this.mainFragmentContainer.Controls.Add(this.manageStudentFragment);
            this.mainFragmentContainer.Location = new System.Drawing.Point(234, 52);
            this.mainFragmentContainer.Name = "mainFragmentContainer";
            this.mainFragmentContainer.Size = new System.Drawing.Size(1110, 755);
            this.mainFragmentContainer.TabIndex = 6;
            // 
            // teachingScheduleFragment
            // 
            this.teachingScheduleFragment.Location = new System.Drawing.Point(3, 3);
            this.teachingScheduleFragment.Name = "teachingScheduleFragment";
            this.teachingScheduleFragment.Size = new System.Drawing.Size(1110, 755);
            this.teachingScheduleFragment.TabIndex = 5;
            // 
            // classScheduleFragment
            // 
            this.classScheduleFragment.Location = new System.Drawing.Point(3, 764);
            this.classScheduleFragment.Name = "classScheduleFragment";
            this.classScheduleFragment.Size = new System.Drawing.Size(1110, 755);
            this.classScheduleFragment.TabIndex = 4;
            // 
            // manageScheduleFragment
            // 
            this.manageScheduleFragment.Location = new System.Drawing.Point(3, 1525);
            this.manageScheduleFragment.Name = "manageScheduleFragment";
            this.manageScheduleFragment.Size = new System.Drawing.Size(1110, 755);
            this.manageScheduleFragment.TabIndex = 3;
            // 
            // manageClassFragment
            // 
            this.manageClassFragment.Location = new System.Drawing.Point(3, 2286);
            this.manageClassFragment.Name = "manageClassFragment";
            this.manageClassFragment.Size = new System.Drawing.Size(1110, 755);
            this.manageClassFragment.TabIndex = 2;
            // 
            // manageTeacherFragment
            // 
            this.manageTeacherFragment.Location = new System.Drawing.Point(3, 3047);
            this.manageTeacherFragment.Name = "manageTeacherFragment";
            this.manageTeacherFragment.Size = new System.Drawing.Size(1110, 755);
            this.manageTeacherFragment.TabIndex = 1;
            // 
            // manageStudentFragment
            // 
            this.manageStudentFragment.Location = new System.Drawing.Point(3, 3808);
            this.manageStudentFragment.Name = "manageStudentFragment";
            this.manageStudentFragment.Size = new System.Drawing.Size(1110, 755);
            this.manageStudentFragment.TabIndex = 0;
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnEditProfile.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProfile.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnEditProfile.Location = new System.Drawing.Point(1221, 12);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(123, 35);
            this.btnEditProfile.TabIndex = 7;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = false;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // navPanelStudent
            // 
            this.navPanelStudent.BackColor = System.Drawing.Color.DodgerBlue;
            this.navPanelStudent.Controls.Add(this.btnClassSchedule);
            this.navPanelStudent.Location = new System.Drawing.Point(12, 52);
            this.navPanelStudent.Name = "navPanelStudent";
            this.navPanelStudent.Size = new System.Drawing.Size(216, 714);
            this.navPanelStudent.TabIndex = 7;
            // 
            // btnClassSchedule
            // 
            this.btnClassSchedule.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClassSchedule.FlatAppearance.BorderSize = 0;
            this.btnClassSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClassSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassSchedule.ForeColor = System.Drawing.Color.White;
            this.btnClassSchedule.Location = new System.Drawing.Point(0, 3);
            this.btnClassSchedule.Name = "btnClassSchedule";
            this.btnClassSchedule.Size = new System.Drawing.Size(216, 35);
            this.btnClassSchedule.TabIndex = 6;
            this.btnClassSchedule.Text = "Class Schedule";
            this.btnClassSchedule.UseVisualStyleBackColor = false;
            this.btnClassSchedule.Click += new System.EventHandler(this.btnClassSchedule_Click);
            // 
            // navPanelAdmin
            // 
            this.navPanelAdmin.BackColor = System.Drawing.Color.DodgerBlue;
            this.navPanelAdmin.Controls.Add(this.btnManageSchedule);
            this.navPanelAdmin.Controls.Add(this.btnManageClass);
            this.navPanelAdmin.Controls.Add(this.btnManageTeacher);
            this.navPanelAdmin.Controls.Add(this.btnManageStudent);
            this.navPanelAdmin.Location = new System.Drawing.Point(12, 52);
            this.navPanelAdmin.Name = "navPanelAdmin";
            this.navPanelAdmin.Size = new System.Drawing.Size(216, 714);
            this.navPanelAdmin.TabIndex = 8;
            // 
            // btnManageSchedule
            // 
            this.btnManageSchedule.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnManageSchedule.FlatAppearance.BorderSize = 0;
            this.btnManageSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageSchedule.ForeColor = System.Drawing.Color.White;
            this.btnManageSchedule.Location = new System.Drawing.Point(-3, 126);
            this.btnManageSchedule.Name = "btnManageSchedule";
            this.btnManageSchedule.Size = new System.Drawing.Size(216, 35);
            this.btnManageSchedule.TabIndex = 9;
            this.btnManageSchedule.Text = "Manage Schedule";
            this.btnManageSchedule.UseVisualStyleBackColor = false;
            this.btnManageSchedule.Click += new System.EventHandler(this.btnManageSchedule_Click);
            // 
            // btnManageClass
            // 
            this.btnManageClass.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnManageClass.FlatAppearance.BorderSize = 0;
            this.btnManageClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageClass.ForeColor = System.Drawing.Color.White;
            this.btnManageClass.Location = new System.Drawing.Point(0, 85);
            this.btnManageClass.Name = "btnManageClass";
            this.btnManageClass.Size = new System.Drawing.Size(216, 35);
            this.btnManageClass.TabIndex = 8;
            this.btnManageClass.Text = "Manage Class";
            this.btnManageClass.UseVisualStyleBackColor = false;
            this.btnManageClass.Click += new System.EventHandler(this.btnManageClass_Click);
            // 
            // btnManageTeacher
            // 
            this.btnManageTeacher.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnManageTeacher.FlatAppearance.BorderSize = 0;
            this.btnManageTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageTeacher.ForeColor = System.Drawing.Color.White;
            this.btnManageTeacher.Location = new System.Drawing.Point(0, 44);
            this.btnManageTeacher.Name = "btnManageTeacher";
            this.btnManageTeacher.Size = new System.Drawing.Size(216, 35);
            this.btnManageTeacher.TabIndex = 7;
            this.btnManageTeacher.Text = "Manage Teacher";
            this.btnManageTeacher.UseVisualStyleBackColor = false;
            this.btnManageTeacher.Click += new System.EventHandler(this.btnManageTeacher_Click);
            // 
            // btnManageStudent
            // 
            this.btnManageStudent.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnManageStudent.FlatAppearance.BorderSize = 0;
            this.btnManageStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageStudent.ForeColor = System.Drawing.Color.White;
            this.btnManageStudent.Location = new System.Drawing.Point(0, 3);
            this.btnManageStudent.Name = "btnManageStudent";
            this.btnManageStudent.Size = new System.Drawing.Size(216, 35);
            this.btnManageStudent.TabIndex = 6;
            this.btnManageStudent.Text = "Manage Student";
            this.btnManageStudent.UseVisualStyleBackColor = false;
            this.btnManageStudent.Click += new System.EventHandler(this.btnManageStudent_Click);
            // 
            // btnAdminMode
            // 
            this.btnAdminMode.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdminMode.FlatAppearance.BorderSize = 0;
            this.btnAdminMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminMode.ForeColor = System.Drawing.Color.White;
            this.btnAdminMode.Location = new System.Drawing.Point(540, 7);
            this.btnAdminMode.Name = "btnAdminMode";
            this.btnAdminMode.Size = new System.Drawing.Size(98, 35);
            this.btnAdminMode.TabIndex = 9;
            this.btnAdminMode.Text = "Admin";
            this.btnAdminMode.UseVisualStyleBackColor = false;
            this.btnAdminMode.Visible = false;
            this.btnAdminMode.Click += new System.EventHandler(this.btnAdminMode_Click);
            // 
            // btnGuruMode
            // 
            this.btnGuruMode.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuruMode.FlatAppearance.BorderSize = 0;
            this.btnGuruMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuruMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuruMode.ForeColor = System.Drawing.Color.White;
            this.btnGuruMode.Location = new System.Drawing.Point(748, 7);
            this.btnGuruMode.Name = "btnGuruMode";
            this.btnGuruMode.Size = new System.Drawing.Size(98, 35);
            this.btnGuruMode.TabIndex = 11;
            this.btnGuruMode.Text = "Guru";
            this.btnGuruMode.UseVisualStyleBackColor = false;
            this.btnGuruMode.Visible = false;
            this.btnGuruMode.Click += new System.EventHandler(this.btnGuruMode_Click);
            // 
            // btnStudentMode
            // 
            this.btnStudentMode.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnStudentMode.FlatAppearance.BorderSize = 0;
            this.btnStudentMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentMode.ForeColor = System.Drawing.Color.White;
            this.btnStudentMode.Location = new System.Drawing.Point(644, 7);
            this.btnStudentMode.Name = "btnStudentMode";
            this.btnStudentMode.Size = new System.Drawing.Size(98, 35);
            this.btnStudentMode.TabIndex = 12;
            this.btnStudentMode.Text = "Student";
            this.btnStudentMode.UseVisualStyleBackColor = false;
            this.btnStudentMode.Visible = false;
            this.btnStudentMode.Click += new System.EventHandler(this.btnStudentMode_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 819);
            this.Controls.Add(this.btnStudentMode);
            this.Controls.Add(this.btnGuruMode);
            this.Controls.Add(this.btnAdminMode);
            this.Controls.Add(this.navPanelAdmin);
            this.Controls.Add(this.navPanelStudent);
            this.Controls.Add(this.btnEditProfile);
            this.Controls.Add(this.mainFragmentContainer);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.navPanelGuru);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.navPanelGuru.ResumeLayout(false);
            this.mainFragmentContainer.ResumeLayout(false);
            this.navPanelStudent.ResumeLayout(false);
            this.navPanelAdmin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel navPanelGuru;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.FlowLayoutPanel mainFragmentContainer;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnTeachingSchedule;
        private System.Windows.Forms.Panel navPanelStudent;
        private System.Windows.Forms.Button btnClassSchedule;
        private System.Windows.Forms.Panel navPanelAdmin;
        private System.Windows.Forms.Button btnManageStudent;
        private System.Windows.Forms.Button btnManageClass;
        private System.Windows.Forms.Button btnManageTeacher;
        private System.Windows.Forms.Button btnManageSchedule;
        private System.Windows.Forms.Button btnAdminMode;
        private System.Windows.Forms.Button btnGuruMode;
        private System.Windows.Forms.Button btnStudentMode;
        private ui.fragment.TeachingScheduleFragment teachingScheduleFragment;
        private ui.fragment.ClassScheduleFragment classScheduleFragment;
        private ui.fragment.admin.ManageScheduleFragment manageScheduleFragment;
        private ui.fragment.admin.ManageClassFragment manageClassFragment;
        private ui.fragment.admin.ManageTeacherFragment manageTeacherFragment;
        private ui.fragment.admin.ManageStudentFragment manageStudentFragment;
    }
}