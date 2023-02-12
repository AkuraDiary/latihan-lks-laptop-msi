namespace latihan_smk_nusantara_2017.ui.fragment
{
    partial class TeachingScheduleFragment
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.teachingScheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.studentListDataGridView = new System.Windows.Forms.DataGridView();
            this.btnViewSubjectInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.teachingScheduleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(3, 12);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(197, 25);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "Teaching Schedule";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Student List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teachingScheduleDataGridView
            // 
            this.teachingScheduleDataGridView.AllowUserToAddRows = false;
            this.teachingScheduleDataGridView.AllowUserToDeleteRows = false;
            this.teachingScheduleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.teachingScheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teachingScheduleDataGridView.Location = new System.Drawing.Point(8, 40);
            this.teachingScheduleDataGridView.Name = "teachingScheduleDataGridView";
            this.teachingScheduleDataGridView.ReadOnly = true;
            this.teachingScheduleDataGridView.Size = new System.Drawing.Size(1083, 232);
            this.teachingScheduleDataGridView.TabIndex = 7;
            // 
            // studentListDataGridView
            // 
            this.studentListDataGridView.AllowUserToAddRows = false;
            this.studentListDataGridView.AllowUserToDeleteRows = false;
            this.studentListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentListDataGridView.Location = new System.Drawing.Point(8, 330);
            this.studentListDataGridView.Name = "studentListDataGridView";
            this.studentListDataGridView.ReadOnly = true;
            this.studentListDataGridView.Size = new System.Drawing.Size(611, 232);
            this.studentListDataGridView.TabIndex = 8;
            // 
            // btnViewSubjectInfo
            // 
            this.btnViewSubjectInfo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnViewSubjectInfo.FlatAppearance.BorderSize = 0;
            this.btnViewSubjectInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSubjectInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSubjectInfo.ForeColor = System.Drawing.Color.White;
            this.btnViewSubjectInfo.Location = new System.Drawing.Point(426, 643);
            this.btnViewSubjectInfo.Name = "btnViewSubjectInfo";
            this.btnViewSubjectInfo.Size = new System.Drawing.Size(193, 35);
            this.btnViewSubjectInfo.TabIndex = 10;
            this.btnViewSubjectInfo.Text = "View Subject Info";
            this.btnViewSubjectInfo.UseVisualStyleBackColor = false;
            // 
            // TeachingScheduleFragment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnViewSubjectInfo);
            this.Controls.Add(this.studentListDataGridView);
            this.Controls.Add(this.teachingScheduleDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWelcome);
            this.Name = "TeachingScheduleFragment";
            this.Size = new System.Drawing.Size(1110, 755);
            ((System.ComponentModel.ISupportInitialize)(this.teachingScheduleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView teachingScheduleDataGridView;
        private System.Windows.Forms.DataGridView studentListDataGridView;
        private System.Windows.Forms.Button btnViewSubjectInfo;
    }
}
