using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace usingADO.NET
{
    public partial class ManageStudentForm : Form
    {
        private string connectionStrings;
        private SqlConnection conn;
        private SqlCommand cmd;
        private ManageStudents ms;
        private ManageClass mc;

        public ManageStudentForm()
        {
            InitializeComponent();
            init();
            connectDB();
            GetListClass();
            DisplayListStudents(ms.GetListStudent());
        }

        // Khởi tạo các vùng nhớ
        private void init()
        {   
            ms = new ManageStudents();
            mc = new ManageClass();
        }

        // Kêt nối đến database
        private void connectDB()
        {
            connectionStrings = ConfigurationManager.ConnectionStrings["QuanLySinhVien"].ConnectionString;
            conn = new SqlConnection(connectionStrings);
            cmd = conn.CreateCommand();

            conn.Open();
        }

        // Đóng kết nối đến database
        private void closeDB()
        {
            conn.Close();
            conn.Dispose();
        }

        private void execCommand(Action callback)
        {
            connectDB();
            callback();
            closeDB();
        }

        // Lấy danh sách lớp
        private void GetListClass()
        {
            mc.Clear();

            execCommand(() =>
            {
                cmd.CommandText = $"SELECT * FROM Lop";
                SqlDataReader records = cmd.ExecuteReader();
                while (records.Read())
                {
                    Class l = new Class()
                    {
                        ID = (int)records["ID"],
                        TenLop = records["TenLop"].ToString(),
                    };
                    mc.AddClass(l);
                }
            });
            cboClass.DataSource = mc.GetListClass();
            cboClass.ValueMember = "ID";
            cboClass.DisplayMember = "TenLop";
        }

        // Lấy danh sách sinh viên
        private void GetListStudent()
        {
            ms.Clear();

            execCommand(() =>
            {
                cmd.CommandText = $"SELECT * FROM SinhVien";
                SqlDataReader records = cmd.ExecuteReader();
                while (records.Read())
                {
                    Students sd = new Students()
                    {
                        ID = (int)records["ID"],
                        HoTen = records["HoTen"].ToString(),
                        MaLop = (int)records["MaLop"]
                    };
                    ms.AddStudent(sd);
                }
            });
        }

        // Lấy tên lớp của sinh viên
        private string GetClassName(int maLop)
        {
            Class found = mc.FindClassIDClass(maLop);
            if (found != null)
            {
                return found.TenLop;
            }
            return "";
        }

        // Hiển thị danh sách sinh viên lên listview ListStudent
        private void DisplayListStudents(List<Students> list)
        {
            GetListStudent();

            lvListStudent.Items.Clear();

            foreach (var sv in list)
            {
                string[] data = {
                    sv.ID.ToString(),
                    sv.HoTen,
                    GetClassName(sv.MaLop)
                };
                ListViewItem item = new ListViewItem(data);
                lvListStudent.Items.Add(item);
            }
        }

        // Tìm kiếm sinh viên theo tên
        private void FindSDName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                List<Students> founds = ms.FindSDName(name);
                DisplayListStudents(founds);
            }
            else
            {
                DisplayListStudents(ms.GetListStudent());
            }
        }

        // Thêm sinh viên
        private void AddSD()
        {
            string HoTen = txtName.Text;
            int MaLop = int.Parse(cboClass.SelectedValue.ToString());

            execCommand(() =>
            {
                cmd.CommandText =
                    $"INSERT INTO SinhVien (HoTen, MaLop) " +
                    $"VALUES (N'{HoTen}', {MaLop})";

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Thêm sinh viên thành công!");
                    ResetDefault();
                    DisplayListStudents(ms.GetListStudent());
                }
                else
                {
                    MessageBox.Show("Thêm sinh viên không thành công, vui lòng kiểm tra lại thông tin!");
                }
            });

        }

        // Chỉnh sửa sinh viên
        private void UpdateSD(int id)
        {
            string HoTen = txtName.Text;
            int MaLop = int.Parse(cboClass.SelectedValue.ToString());

            execCommand(() =>
            {
                cmd.CommandText =
                    $"UPDATE SinhVien " +
                    $"SET HoTen=N'{HoTen}', MaLop={MaLop} " +
                    $"WHERE ID={id}";

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sửa thông tin sinh viên thành công!");
                    ResetDefault();
                    DisplayListStudents(ms.GetListStudent());
                }
                else
                {
                    MessageBox.Show("Sửa thông tin sinh viên không công, vui lòng kiểm tra lại thông tin!");
                }
            });
        }

        // Set các control về giá trị mặc định
        private void ResetDefault()
        {
            txtID.Text = null;
            txtName.Text = null;
            cboClass.Text = null;
            txtSearch.Text = null;
        }

        // Hiển thị thông tin lên các control
        private void BindingInfoSD(Students sd)
        {
            txtID.Text = sd.ID.ToString();
            txtName.Text = sd.HoTen;
            cboClass.Text = GetClassName(sd.MaLop);
        }

        // Thêm sinh viên nếu sinh viên chưa có và cho sửa sinh viên nếu sinh viên đã có
        private void btnSave_Click(object sender, EventArgs e)
        {
            string mssv = txtID.Text;
            if (string.IsNullOrEmpty(mssv))
            {
                AddSD();
            }
            else
            {
                int id = int.Parse(mssv);
                UpdateSD(id);
            }
        }

        // Tải lại các dữ liệu từ database để hiển thị lên listview
        private void btnReload_Click(object sender, EventArgs e)
        {
            DisplayListStudents(ms.GetListStudent());
        }

        // Set các control về giá trị mặc định
        private void btnDefault_Click(object sender, EventArgs e)
        {
            ResetDefault();
        }

        // Tìm kiếm sinh viên theo tên
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            TextBox owner = sender as TextBox;
            string name = owner.Text;
            FindSDName(name);
        }

        // Click vào item của listview sẽ hiện thị thông tin dòng đó lên các control
        private void lvListStudent_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                ListView owner = sender as ListView;
                int id = int.Parse(owner.SelectedItems[0].Text);
                Students found = ms.FindSDID(id);
                if (found != null)
                {
                    BindingInfoSD(found);
                }
            }
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            if (lvListStudent.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lvListStudent.SelectedItems)
                {
                    lvListStudent.Items.RemoveAt(item.Index);
                }
            }
        }
    }
}
