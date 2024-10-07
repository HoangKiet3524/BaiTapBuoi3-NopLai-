using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using static Bai3.frmQuanLySinhvien;

namespace Bai3
{
    public delegate void ThemSVDelegate(string MaSV, string TenSV, string GioiTinh, string DiemTB, string Khoa );
    public partial class frmThongTinSinhVien : Form
    {
        public ThemSVDelegate addSV;

        public frmThongTinSinhVien()
        {
            InitializeComponent();
            rbNu.Checked = true;

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            cmbKhoa.Items.Add("Quản trị kinh doanh");
            cmbKhoa.Items.Add("Công nghệ thông tin");
            cmbKhoa.Items.Add("Công nghệ ô tô");
            cmbKhoa.Items.Add("Ngôn ngữ Anh");
            cmbKhoa.SelectedIndex = 1;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbNu_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidInput())
                {
                    string MaSV = txtMaSV.Text;
                    string TSV = txtTenSV.Text;
                    
                    string GT = rbNam.Checked ? "Nam" : "Nữ";
                    string DTB = txtDiemTB.Text;
                    string Khoa = cmbKhoa.SelectedItem.ToString();
                    
                    addSV?.Invoke(MaSV, TSV, GT, DTB, Khoa);
                    MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool IsValidInput()
        {
            errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtTenSV.Text) || string.IsNullOrWhiteSpace(txtDiemTB.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtMaSV.Text.Length != 10 || !long.TryParse(txtMaSV.Text, out _))
            {
                MessageBox.Show("Mã số sinh viên không hợp lệ! (Phải là số và dài 10 ký tự.)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(txtMaSV, "Mã số sinh viên không hợp lệ! (Phải là số và dài 10 ký tự)!");
                return false;
            }
            string namePattern = @"^[\p{L} ]+$";
            string nameInput = txtTenSV.Text;

            if (nameInput.Length < 3 || nameInput.Length > 100 || !Regex.IsMatch(nameInput, namePattern))
            {
                errorProvider1.SetError(txtTenSV, "Họ tên sinh viên không hợp lệ! (Phải dài từ 3 đến 100 ký tự, không chứa ký tự đặc biệt hoặc số.)");
                MessageBox.Show("Họ tên sinh viên không hợp lệ! (Phải dài từ 3 đến 100 ký tự, không chứa ký tự đặc biệt hoặc số.)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string scoreInput = txtDiemTB.Text;
            if (!float.TryParse(scoreInput, out float score) || score < 0 || score > 10)
            {
                errorProvider1.SetError(txtDiemTB, "Điểm trung bình không hợp lệ! (Phải nằm trong khoảng từ 0 đến 10.)");
                MessageBox.Show("Điểm trung bình không hợp lệ! (Phải nằm trong khoảng từ 0 đến 10.)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void txtTenSV_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void txtDiemTB_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtMaSV_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi trang Thêm sinh viên?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void grpThongTinSinhVien_Enter(object sender, EventArgs e)
        {

        }
    }
}