using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace bt_12_10_4._6
{
    public partial class Form1 : Form
    {
        
        private BindingList<Student> studentList = new BindingList<Student>();

        
        private BindingSource studentBindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            cboGender.Items.AddRange(new string[] { "Nam", "Nữ" });
            cboGender.SelectedIndex = 0;

           
            studentList.Add(new Student("SV01", "Nguyễn Văn An", 20, "Nam", ""));
            studentList.Add(new Student("SV02", "Trần Thị Bích", 21, "Nữ", ""));
            studentList.Add(new Student("SV03", "Lê Hoàng Nam", 19, "Nam", ""));

            
            studentBindingSource.DataSource = studentList;
            dgvStudents.DataSource = studentBindingSource;

            
            ThietLapDataBindings();

            
            studentBindingSource.CurrentChanged += studentBindingSource_CurrentChanged;

           
            DinhDangGridView();

            
            studentBindingSource_CurrentChanged(null, null);
        }

        
        private void ThietLapDataBindings()
        {
            
            txtStudentId.DataBindings.Add("Text", studentBindingSource, "StudentId", true, DataSourceUpdateMode.OnPropertyChanged);
            txtFullName.DataBindings.Add("Text", studentBindingSource, "FullName", true, DataSourceUpdateMode.OnPropertyChanged);
            txtAge.DataBindings.Add("Text", studentBindingSource, "Age", true, DataSourceUpdateMode.OnPropertyChanged);
            cboGender.DataBindings.Add("Text", studentBindingSource, "Gender", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void DinhDangGridView()
        {
            if (dgvStudents.Columns["StudentId"] != null) dgvStudents.Columns["StudentId"].HeaderText = "Mã SV";
            if (dgvStudents.Columns["FullName"] != null) dgvStudents.Columns["FullName"].HeaderText = "Họ Tên";
            if (dgvStudents.Columns["Age"] != null) dgvStudents.Columns["Age"].HeaderText = "Tuổi";
            if (dgvStudents.Columns["Gender"] != null) dgvStudents.Columns["Gender"].HeaderText = "Giới Tính";
            if (dgvStudents.Columns["AvatarPath"] != null) dgvStudents.Columns["AvatarPath"].HeaderText = "Đường Dẫn Ảnh";
        }

        
        private void studentBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (studentBindingSource.Current is Student currentStudent)
            {
                LoadAvatar(currentStudent.AvatarPath);
            }
            else
            {
                LoadAvatar(null);
            }
        }

        
        private void LoadAvatar(string path)
        {
            if (picAvatar.Image != null)
            {
                picAvatar.Image.Dispose();
                picAvatar.Image = null;
            }

            if (!string.IsNullOrEmpty(path) && File.Exists(path))
            {
                try
                {
                    using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        picAvatar.Image = Image.FromStream(stream);
                    }
                }
                catch
                {
                    picAvatar.Image = null;
                }
            }
            else
            {
                picAvatar.Image = null;
            }
        }

        
        private void btnSelectAvatar_Click(object sender, EventArgs e)
        {
            if (studentBindingSource.Current is Student currentStudent)
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "File hình ảnh (*.jpg; *.png; *.bmp)|*.jpg;*.png;*.bmp|Tất cả các file (*.*)|*.*";
                    ofd.Title = "Chọn ảnh đại diện sinh viên";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        currentStudent.AvatarPath = ofd.FileName;
                        LoadAvatar(currentStudent.AvatarPath);
                        studentBindingSource.ResetCurrentItem();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để gán ảnh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student(
                "SV" + (studentList.Count + 1).ToString("D2"),
                "Sinh Viên Mới",
                18,
                "Nam",
                ""
            );

            studentList.Add(newStudent);
            studentBindingSource.MoveLast(); 
            txtStudentId.Focus();
        }

        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            studentBindingSource.EndEdit();
            dgvStudents.Refresh();
            MessageBox.Show("Cập nhật thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (studentBindingSource.Current is Student currentStudent)
            {
                DialogResult dr = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa sinh viên [{currentStudent.FullName}] không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (dr == DialogResult.Yes)
                {
                    studentBindingSource.RemoveCurrent();
                }
            }
            else
            {
                MessageBox.Show("Không có sinh viên nào để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            if (studentList.Count == 0)
            {
                MessageBox.Show("Danh sách sinh viên trống, không thể xuất file!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "File CSV (*.csv)|*.csv|Tất cả các file (*.*)|*.*";
                sfd.Title = "Chọn nơi lưu file CSV";
                sfd.FileName = "DanhSachSinhVien.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        
                        using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                        {
                            
                            sw.WriteLine("Mã SV,Họ Tên,Tuổi,Giới Tính,Đường Dẫn Ảnh");

                            
                            foreach (Student st in studentList)
                            {
                                string line = $"\"{st.StudentId}\",\"{st.FullName}\",{st.Age},\"{st.Gender}\",\"{st.AvatarPath}\"";
                                sw.WriteLine(line);
                            }
                        }

                        MessageBox.Show("Xuất danh sách sinh viên ra file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi ghi file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
