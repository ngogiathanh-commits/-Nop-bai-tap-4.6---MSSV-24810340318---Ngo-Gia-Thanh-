namespace bt_12_10_4._6
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            grpInput = new GroupBox();
            btnSelectAvatar = new Button();
            picAvatar = new PictureBox();
            cboGender = new ComboBox();
            txtAge = new TextBox();
            txtFullName = new TextBox();
            txtStudentId = new TextBox();
            lblGender = new Label();
            lblAge = new Label();
            lblFullName = new Label();
            lblStudentId = new Label();
            grpActions = new GroupBox();
            btnExportCsv = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dgvStudents = new DataGridView();
            grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            grpActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // grpInput
            // 
            grpInput.Controls.Add(btnSelectAvatar);
            grpInput.Controls.Add(picAvatar);
            grpInput.Controls.Add(cboGender);
            grpInput.Controls.Add(txtAge);
            grpInput.Controls.Add(txtFullName);
            grpInput.Controls.Add(txtStudentId);
            grpInput.Controls.Add(lblGender);
            grpInput.Controls.Add(lblAge);
            grpInput.Controls.Add(lblFullName);
            grpInput.Controls.Add(lblStudentId);
            grpInput.Location = new Point(12, 12);
            grpInput.Name = "grpInput";
            grpInput.Size = new Size(500, 210);
            grpInput.TabIndex = 0;
            grpInput.TabStop = false;
            grpInput.Text = "Thông tin sinh viên";
            // 
            // btnSelectAvatar
            // 
            btnSelectAvatar.Location = new Point(340, 165);
            btnSelectAvatar.Name = "btnSelectAvatar";
            btnSelectAvatar.Size = new Size(130, 30);
            btnSelectAvatar.TabIndex = 9;
            btnSelectAvatar.Text = "Chọn Ảnh...";
            btnSelectAvatar.UseVisualStyleBackColor = true;
            btnSelectAvatar.Click += btnSelectAvatar_Click;
            // 
            // picAvatar
            // 
            picAvatar.BorderStyle = BorderStyle.FixedSingle;
            picAvatar.Location = new Point(340, 25);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(130, 130);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 8;
            picAvatar.TabStop = false;
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.FormattingEnabled = true;
            cboGender.Location = new Point(100, 155);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(200, 28);
            cboGender.TabIndex = 7;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(100, 115);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(200, 27);
            txtAge.TabIndex = 6;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(100, 72);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(200, 27);
            txtFullName.TabIndex = 5;
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(100, 30);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(200, 27);
            txtStudentId.TabIndex = 4;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(15, 158);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(68, 20);
            lblGender.TabIndex = 3;
            lblGender.Text = "Giới tính:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(15, 118);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(41, 20);
            lblAge.TabIndex = 2;
            lblAge.Text = "Tuổi:";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(15, 75);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(57, 20);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Họ tên:";
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Location = new Point(15, 33);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(54, 20);
            lblStudentId.TabIndex = 0;
            lblStudentId.Text = "Mã SV:";
            // 
            // grpActions
            // 
            grpActions.Controls.Add(btnExportCsv);
            grpActions.Controls.Add(btnDelete);
            grpActions.Controls.Add(btnUpdate);
            grpActions.Controls.Add(btnAdd);
            grpActions.Location = new Point(525, 12);
            grpActions.Name = "grpActions";
            grpActions.Size = new Size(245, 210);
            grpActions.TabIndex = 1;
            grpActions.TabStop = false;
            grpActions.Text = "Chức năng";
            // 
            // btnExportCsv
            // 
            btnExportCsv.Location = new Point(20, 155);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(205, 35);
            btnExportCsv.TabIndex = 3;
            btnExportCsv.Text = "Xuất File CSV";
            btnExportCsv.UseVisualStyleBackColor = true;
            btnExportCsv.Click += btnExportCsv_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(20, 110);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(205, 35);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(20, 68);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(205, 35);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Cập Nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(20, 26);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(205, 35);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm Mới";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(12, 235);
            dgvStudents.MultiSelect = false;
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(758, 255);
            dgvStudents.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 503);
            Controls.Add(dgvStudents);
            Controls.Add(grpActions);
            Controls.Add(grpInput);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Sinh Viên - DataBinding & File CSV";
            Load += Form1_Load;
            grpInput.ResumeLayout(false);
            grpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            grpActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpInput;
        private Label lblStudentId;
        private Label lblGender;
        private Label lblAge;
        private Label lblFullName;
        private ComboBox cboGender;
        private TextBox txtAge;
        private TextBox txtFullName;
        private TextBox txtStudentId;
        private PictureBox picAvatar;
        private Button btnSelectAvatar;
        private GroupBox grpActions;
        private Button btnExportCsv;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dgvStudents;
    }
}