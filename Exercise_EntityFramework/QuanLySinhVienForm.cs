using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Exercise_EntityFramework
{
    public partial class QuanLySinhVienForm : Form
    {
        QuanLySinhVienEntities db = new QuanLySinhVienEntities();
        public QuanLySinhVienForm()
        {
            InitializeComponent();
            LoadDataStudent();
            AddBinding();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        void AddBinding()
        {
            txtID.DataBindings.Add(new Binding("Text", dtgvListStudent.DataSource, "MaLop", true, DataSourceUpdateMode.Never));
            txtName.DataBindings.Add(new Binding("Text", dtgvListStudent.DataSource, "HoTen", true, DataSourceUpdateMode.Never));
        }

        void LoadDataStudent()
        {
              var result = from c in db.SinhViens select c;
              dtgvListStudent.DataSource = result.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien() { HoTen = txtName.Text, MaLop = Convert.ToInt32(txtID.Text) };
            db.SinhViens.Add(sv);
            db.SaveChanges();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            SinhVien sv = db.SinhViens.Where(p => p.MaLop == id && p.HoTen == txtName.Text).SingleOrDefault();
            db.SinhViens.Remove(sv);
            db.SaveChanges();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadDataStudent();
        }
    }
}
