using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public delegate void ThemSLSVDelegate(int SLNam, int SLNu);
    public partial class frmQuanLySinhvien : Form
    {
        public ThemSLSVDelegate ThemSL;
        public frmQuanLySinhvien()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();

            toolStripTextBox1.Text = " 0";
            toolStripTextBox2.Text = " 0";
        }

        private List<SinhVien> sinhVienList = new List<SinhVien>();

        public class SinhVien
        {
            public string MaSV { get; set; }
            public string TenSV { get; set; }
            public string GioiTinh { get; set; }
            public float DiemTB { get; set; }
            public string Khoa { get; set; }
        }
        

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonThem_Click(object sender, EventArgs e)
        {
            frmThongTinSinhVien newForm = new frmThongTinSinhVien();
            newForm.Owner = this;

            newForm.addSV += AddStudent;

            newForm.ShowDialog();
        }

        private void UpdateStudentCount()
        {
            int maleCount = sinhVienList.Count(sv => sv.GioiTinh == "Nam");
            int femaleCount = sinhVienList.Count(sv => sv.GioiTinh == "Nữ");

            toolStripTextBox1.Text = "" + maleCount;
            toolStripTextBox2.Text = "" + femaleCount;
        }
        private void AddStudent(string studentID, string fullName, string gender, string averageScore, string faculty)
        {
            try
            {
                SinhVien newSinhVien = new SinhVien
                {
                    MaSV = studentID,
                    TenSV = fullName,
                    GioiTinh = gender,
                    DiemTB = float.Parse(averageScore),
                    Khoa = faculty
                };

                sinhVienList.Add(newSinhVien);

                dgvQLSV.Rows.Add(sinhVienList.Count, newSinhVien.MaSV, newSinhVien.TenSV, newSinhVien.GioiTinh, newSinhVien.DiemTB, newSinhVien.Khoa);
                UpdateStudentCount();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTongSoSinhVienNu_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi trang Thêm sinh viên?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvQLSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}