using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using Entity;

namespace QUANLYKHACHSAN
{
    public partial class quanlynv : Form
    {
        public quanlynv()
        {
            InitializeComponent();
        }
        public void showNhan_vien()
        {
            dgvNhan_Vien.DataSource = tblNhan_vien_BUS.loadNhan_vien();
        }
        public void clearData()
        {
            txtMa_NV.Text = "";
            txtTen_NV.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtMK.Text = "";
        }
        public void Enebal()
        {
            txtMa_NV.Enabled = false;
            txtTen_NV.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSDT.Enabled = false;
            rdbNam.Enabled = false;
            rdbNu.Enabled = false;
            txtMK.Enabled = false;
        }
        public void UnEnebal()
        {
            txtMa_NV.Enabled = true;
            txtTen_NV.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;
            rdbNam.Enabled = true;
            rdbNu.Enabled = true;
            txtMK.Enabled = true;
        }
        public void buidingNhan_Vien()
        {
            txtMa_NV.DataBindings.Clear();
            txtMa_NV.DataBindings.Add("Text", dgvNhan_Vien.DataSource, "MANV");
            txtTen_NV.DataBindings.Clear();
            txtTen_NV.DataBindings.Add("Text", dgvNhan_Vien.DataSource, "TENNV");
            rdbNam.DataBindings.Clear();
            rdbNam.DataBindings.Add("Text", dgvNhan_Vien.DataSource, "GIOITINH");
            if (rdbNam.Text == "1")
            {

                rdbNam.Checked = true;

            }
            else
            {
                rdbNu.Checked = true;
            }
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvNhan_Vien.DataSource, "DIACHI");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgvNhan_Vien.DataSource, "SDT");
            txtMK.DataBindings.Clear();
            txtMK.DataBindings.Add("Text", dgvNhan_Vien.DataSource, "MK");
        }

        private void quanlynv_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                UnEnebal();
                clearData();
                btnThem.Text = "Lưu";
                btnSua.Text = "Cannel";
                btnXoa.Enabled = false;
            }
            else if (btnThem.Text == "Lưu")
            {
                btnThem.Text = "Thêm";
                btnSua.Text = "Sửa";
                btnXoa.Enabled = true;
                if (!Catch.cNullTB(txtMa_NV.Text) & !Catch.cNullTB(txtTen_NV.Text) & !Catch.cNullTB(txtDiaChi.Text) & !Catch.cNullTB(txtSDT.Text) & !Catch.cNullTB(txtSDT.Text))
                {
                    try
                    {
                        int manv = Convert.ToInt32(txtMa_NV.Text.Trim());
                        string tennv = txtTen_NV.Text.Trim();
                        string diachi = txtDiaChi.Text.Trim();
                        byte gioitinh = Convert.ToByte(txtMK.Text.Trim());
                        string sdt = txtSDT.Text.Trim();
                        int mk = Convert.ToInt32(txtMK.Text.Trim());

                        tblNhanVien nv = new tblNhanVien(manv, tennv, gioitinh, sdt, diachi, mk);
                        tblNhan_vien_BUS.addNhan_vien(nv);
                        showNhan_vien();
                        buidingNhan_Vien();
                        Enebal();
                    }
                    catch
                    {
                        MessageBox.Show("Loi");
                    }
                }
            }
            else if (btnThem.Text == "Lưu ")
            {
                btnThem.Text = "Thêm";
                btnSua.Text = "Sửa";
                btnXoa.Enabled = true;
                if (!Catch.cNullTB(txtMa_NV.Text) & !Catch.cNullTB(txtTen_NV.Text) & !Catch.cNullTB(txtDiaChi.Text) & !Catch.cNullTB(txtSDT.Text) & !Catch.cNullTB(txtSDT.Text))
                {
                    try
                    {
                        int manv = Convert.ToInt32(txtMa_NV.Text.Trim());
                        string tennv = txtTen_NV.Text.Trim();
                        byte gioitinh = Convert.ToByte(txtMK.Text.Trim());
                        string diachi = txtDiaChi.Text.Trim();
                        string sdt = txtSDT.Text.Trim();
                        int mk = Convert.ToInt32(txtMK.Text.Trim());

                        tblNhanVien nv = new tblNhanVien(manv, tennv, gioitinh, sdt,diachi, mk);
                        tblNhan_vien_BUS.updateNhan_vien(nv);
                        showNhan_vien();
                        buidingNhan_Vien();
                        Enebal();
                    }
                    catch
                    {
                        MessageBox.Show("Loi");
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập dữ liệu");
                }
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "Sửa")
            {
                UnEnebal();
                txtMa_NV.Enabled = false;
                btnThem.Text = "Lưu Sửa";
                btnSua.Text = "Cannel";
                btnXoa.Enabled = false;

            }
            else
            {
                btnThem.Text = "Thêm";
                btnSua.Text = "Sửa";
                btnXoa.Enabled = true;
                Enebal();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!Catch.cNullTB(txtMa_NV.Text))
            {
                int manv = Convert.ToInt32(txtMa_NV.Text);
                tblNhan_vien_BUS.deleteNhan_vien(manv);
                showNhan_vien();
                buidingNhan_Vien();
                Enebal();

            }
            else
            {
                MessageBox.Show("Chưa nhập dữ liệu");
            }
        }

private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

