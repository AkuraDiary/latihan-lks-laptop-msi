namespace latihan_smk_nusantara_2017.ui.fragment.admin
{
    partial class ManageTeacherFragment
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
            this.edtGender = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.edtTeacherID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dtpDoB = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.edtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edtAddress = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.edtName = new System.Windows.Forms.TextBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.teachersDataGridView = new System.Windows.Forms.DataGridView();
            this.btnGenerateId = new System.Windows.Forms.Button();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_of_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no_hp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.teachersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // edtGender
            // 
            this.edtGender.AutoCompleteCustomSource.AddRange(new string[] {
            "laki-laki",
            "perempuan"});
            this.edtGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.edtGender.FormattingEnabled = true;
            this.edtGender.Items.AddRange(new object[] {
            "laki-laki",
            "perempuan"});
            this.edtGender.Location = new System.Drawing.Point(454, 413);
            this.edtGender.Name = "edtGender";
            this.edtGender.Size = new System.Drawing.Size(274, 21);
            this.edtGender.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(317, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 51;
            this.label6.Text = "gender";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edtTeacherID
            // 
            this.edtTeacherID.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtTeacherID.Location = new System.Drawing.Point(454, 320);
            this.edtTeacherID.Name = "edtTeacherID";
            this.edtTeacherID.Size = new System.Drawing.Size(274, 25);
            this.edtTeacherID.TabIndex = 50;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(637, 691);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 35);
            this.btnDelete.TabIndex = 49;
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
            this.btnInsert.Location = new System.Drawing.Point(498, 691);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(128, 35);
            this.btnInsert.TabIndex = 48;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dtpDoB
            // 
            this.dtpDoB.Location = new System.Drawing.Point(454, 557);
            this.dtpDoB.Name = "dtpDoB";
            this.dtpDoB.Size = new System.Drawing.Size(274, 20);
            this.dtpDoB.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(317, 606);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "phone number";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edtPhoneNumber
            // 
            this.edtPhoneNumber.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtPhoneNumber.Location = new System.Drawing.Point(454, 602);
            this.edtPhoneNumber.Name = "edtPhoneNumber";
            this.edtPhoneNumber.Size = new System.Drawing.Size(274, 25);
            this.edtPhoneNumber.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(317, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "teacher id";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 557);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "date of birth";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "address";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edtAddress
            // 
            this.edtAddress.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtAddress.Location = new System.Drawing.Point(454, 455);
            this.edtAddress.Multiline = true;
            this.edtAddress.Name = "edtAddress";
            this.edtAddress.Size = new System.Drawing.Size(274, 82);
            this.edtAddress.TabIndex = 41;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.Location = new System.Drawing.Point(606, 640);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 35);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(320, 691);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(172, 35);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // edtName
            // 
            this.edtName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtName.Location = new System.Drawing.Point(454, 363);
            this.edtName.Name = "edtName";
            this.edtName.Size = new System.Drawing.Size(274, 25);
            this.edtName.TabIndex = 37;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(11, 28);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(230, 25);
            this.lblWelcome.TabIndex = 36;
            this.lblWelcome.Text = "Form Manage Teacher";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teachersDataGridView
            // 
            this.teachersDataGridView.AllowUserToAddRows = false;
            this.teachersDataGridView.AllowUserToDeleteRows = false;
            this.teachersDataGridView.AutoGenerateColumns = false;
            this.teachersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.teachersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teachersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_id,
            this.name,
            this.gender,
            this.address,
            this.date_of_birth,
            this.no_hp});
            this.teachersDataGridView.DataSource = this.userBindingSource;
            this.teachersDataGridView.Location = new System.Drawing.Point(16, 66);
            this.teachersDataGridView.Name = "teachersDataGridView";
            this.teachersDataGridView.ReadOnly = true;
            this.teachersDataGridView.Size = new System.Drawing.Size(1083, 232);
            this.teachersDataGridView.TabIndex = 35;
            this.teachersDataGridView.SelectionChanged += new System.EventHandler(this.teachersDataGridView_SelectionChanged);
            // 
            // btnGenerateId
            // 
            this.btnGenerateId.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerateId.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerateId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateId.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerateId.Location = new System.Drawing.Point(734, 315);
            this.btnGenerateId.Name = "btnGenerateId";
            this.btnGenerateId.Size = new System.Drawing.Size(87, 35);
            this.btnGenerateId.TabIndex = 53;
            this.btnGenerateId.Text = "generate";
            this.btnGenerateId.UseVisualStyleBackColor = false;
            this.btnGenerateId.Click += new System.EventHandler(this.btnGenerateId_Click);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(latihan_smk_nusantara_2017.data.source.model.user);
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
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // date_of_birth
            // 
            this.date_of_birth.DataPropertyName = "date_of_birth";
            this.date_of_birth.HeaderText = "date_of_birth";
            this.date_of_birth.Name = "date_of_birth";
            this.date_of_birth.ReadOnly = true;
            // 
            // no_hp
            // 
            this.no_hp.DataPropertyName = "no_hp";
            this.no_hp.HeaderText = "no_hp";
            this.no_hp.Name = "no_hp";
            this.no_hp.ReadOnly = true;
            // 
            // ManageTeacherFragment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGenerateId);
            this.Controls.Add(this.edtGender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.edtTeacherID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dtpDoB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edtPhoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edtAddress);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.edtName);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.teachersDataGridView);
            this.Name = "ManageTeacherFragment";
            this.Size = new System.Drawing.Size(1110, 755);
            this.Load += new System.EventHandler(this.ManageTeacherFragment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teachersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox edtGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edtTeacherID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DateTimePicker dtpDoB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edtPhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtAddress;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox edtName;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.DataGridView teachersDataGridView;
        private System.Windows.Forms.Button btnGenerateId;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_of_birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_hp;
    }
}
