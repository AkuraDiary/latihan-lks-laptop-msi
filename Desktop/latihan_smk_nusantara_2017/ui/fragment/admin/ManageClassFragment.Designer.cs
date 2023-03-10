namespace latihan_smk_nusantara_2017.ui.fragment.admin
{
    partial class ManageClassFragment
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
            this.edtClassname = new System.Windows.Forms.ComboBox();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.studentListDataGridView = new System.Windows.Forms.DataGridView();
            this.unenrolled_user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unenrolled_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.participateStudentDataGridView = new System.Windows.Forms.DataGridView();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddToParticipant = new System.Windows.Forms.Button();
            this.btnRemoveFromParticipant = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participateStudentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // edtClassname
            // 
            this.edtClassname.DataSource = this.classBindingSource;
            this.edtClassname.DisplayMember = "name";
            this.edtClassname.FormattingEnabled = true;
            this.edtClassname.Location = new System.Drawing.Point(26, 74);
            this.edtClassname.Name = "edtClassname";
            this.edtClassname.Size = new System.Drawing.Size(219, 21);
            this.edtClassname.TabIndex = 0;
            this.edtClassname.ValueMember = "name";
            this.edtClassname.SelectedIndexChanged += new System.EventHandler(this.edtClassname_SelectedIndexChanged);
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataSource = typeof(latihan_smk_nusantara_2017.data.source.model.@class);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 45;
            this.label4.Tag = "";
            this.label4.Text = "class name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 46;
            this.label1.Tag = "";
            this.label1.Text = "student list";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(686, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 47;
            this.label2.Tag = "";
            this.label2.Text = "participate student";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studentListDataGridView
            // 
            this.studentListDataGridView.AllowUserToAddRows = false;
            this.studentListDataGridView.AllowUserToDeleteRows = false;
            this.studentListDataGridView.AutoGenerateColumns = false;
            this.studentListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.unenrolled_user_id,
            this.unenrolled_name});
            this.studentListDataGridView.DataSource = this.userBindingSource1;
            this.studentListDataGridView.Location = new System.Drawing.Point(26, 141);
            this.studentListDataGridView.Name = "studentListDataGridView";
            this.studentListDataGridView.ReadOnly = true;
            this.studentListDataGridView.Size = new System.Drawing.Size(391, 562);
            this.studentListDataGridView.TabIndex = 48;
            this.studentListDataGridView.SelectionChanged += new System.EventHandler(this.studentListDataGridView_SelectionChanged);
            // 
            // unenrolled_user_id
            // 
            this.unenrolled_user_id.DataPropertyName = "user_id";
            this.unenrolled_user_id.HeaderText = "user_id";
            this.unenrolled_user_id.Name = "unenrolled_user_id";
            this.unenrolled_user_id.ReadOnly = true;
            // 
            // unenrolled_name
            // 
            this.unenrolled_name.DataPropertyName = "name";
            this.unenrolled_name.HeaderText = "name";
            this.unenrolled_name.Name = "unenrolled_name";
            this.unenrolled_name.ReadOnly = true;
            // 
            // userBindingSource1
            // 
            this.userBindingSource1.DataSource = typeof(latihan_smk_nusantara_2017.data.source.model.user);
            // 
            // participateStudentDataGridView
            // 
            this.participateStudentDataGridView.AllowUserToAddRows = false;
            this.participateStudentDataGridView.AllowUserToDeleteRows = false;
            this.participateStudentDataGridView.AutoGenerateColumns = false;
            this.participateStudentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.participateStudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.participateStudentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_id,
            this.name});
            this.participateStudentDataGridView.DataSource = this.userBindingSource;
            this.participateStudentDataGridView.Location = new System.Drawing.Point(689, 141);
            this.participateStudentDataGridView.Name = "participateStudentDataGridView";
            this.participateStudentDataGridView.ReadOnly = true;
            this.participateStudentDataGridView.Size = new System.Drawing.Size(391, 562);
            this.participateStudentDataGridView.TabIndex = 49;
            this.participateStudentDataGridView.SelectionChanged += new System.EventHandler(this.participateStudentDataGridView_SelectionChanged);
            // 
            // user_id
            // 
            this.user_id.DataPropertyName = "user_id";
            this.user_id.HeaderText = "user_id";
            this.user_id.Name = "user_id";
            this.user_id.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(latihan_smk_nusantara_2017.data.source.model.user);
            // 
            // btnAddToParticipant
            // 
            this.btnAddToParticipant.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddToParticipant.FlatAppearance.BorderSize = 0;
            this.btnAddToParticipant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToParticipant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToParticipant.ForeColor = System.Drawing.Color.White;
            this.btnAddToParticipant.Location = new System.Drawing.Point(504, 281);
            this.btnAddToParticipant.Name = "btnAddToParticipant";
            this.btnAddToParticipant.Size = new System.Drawing.Size(91, 35);
            this.btnAddToParticipant.TabIndex = 50;
            this.btnAddToParticipant.Text = ">>";
            this.btnAddToParticipant.UseVisualStyleBackColor = false;
            this.btnAddToParticipant.Click += new System.EventHandler(this.btnAddToParticipant_Click);
            // 
            // btnRemoveFromParticipant
            // 
            this.btnRemoveFromParticipant.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRemoveFromParticipant.FlatAppearance.BorderSize = 0;
            this.btnRemoveFromParticipant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveFromParticipant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFromParticipant.ForeColor = System.Drawing.Color.White;
            this.btnRemoveFromParticipant.Location = new System.Drawing.Point(504, 360);
            this.btnRemoveFromParticipant.Name = "btnRemoveFromParticipant";
            this.btnRemoveFromParticipant.Size = new System.Drawing.Size(91, 35);
            this.btnRemoveFromParticipant.TabIndex = 51;
            this.btnRemoveFromParticipant.Text = "<<";
            this.btnRemoveFromParticipant.UseVisualStyleBackColor = false;
            this.btnRemoveFromParticipant.Click += new System.EventHandler(this.btnRemoveFromParticipant_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(21, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(150, 25);
            this.lblTitle.TabIndex = 52;
            this.lblTitle.Text = "Manage Class";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManageClassFragment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnRemoveFromParticipant);
            this.Controls.Add(this.btnAddToParticipant);
            this.Controls.Add(this.participateStudentDataGridView);
            this.Controls.Add(this.studentListDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edtClassname);
            this.Name = "ManageClassFragment";
            this.Size = new System.Drawing.Size(1110, 755);
            this.Load += new System.EventHandler(this.ManageClassFragment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participateStudentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox edtClassname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView studentListDataGridView;
        private System.Windows.Forms.DataGridView participateStudentDataGridView;
        private System.Windows.Forms.Button btnAddToParticipant;
        private System.Windows.Forms.Button btnRemoveFromParticipant;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.BindingSource classBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn unenrolled_user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn unenrolled_name;
        private System.Windows.Forms.BindingSource userBindingSource1;
    }
}
