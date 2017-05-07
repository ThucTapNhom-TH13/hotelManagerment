using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYKHACHSAN
{
    public partial class Quanlydichvu : Form
    {
        public Quanlydichvu()
        {
            InitializeComponent();
        }

        void enableTextBox(bool madv, bool tendv, bool gia, bool soluong)
        {
            textBox1.Enabled = madv;
            textBox2.Enabled = tendv;
            textBox3.Enabled = gia;
            textBox4.Enabled = soluong;
        }

        void clearTextBox(bool madv, bool tendv, bool gia, bool soluong)
        {
            if (madv)
                textBox1.Text = "";
            if (tendv)
                textBox2.Text = "";
            if (gia)
                textBox3.Text = "";
            if (soluong)
                textBox4.Text = "";
        }

        private void Quanlydichvu_Load(object sender, EventArgs e)
        {
            enableTextBox(false, false, false, false);
            dataGridView1.DataSource = BUS.DichVu_BUS.DichVu_getAll();
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String madv = "", giatien = "", tendv = "", soluong = "";
            int CurrentIndex = dataGridView1.CurrentCell.RowIndex;

            if (dataGridView1.Rows[CurrentIndex].Cells[0].Value != null)
            {
                madv = dataGridView1.Rows[CurrentIndex].Cells[0].Value.ToString();
                textBox1.Text = madv;
            }
            if (dataGridView1.Rows[CurrentIndex].Cells[1].Value != null)
            {
                tendv = dataGridView1.Rows[CurrentIndex].Cells[1].Value.ToString();
                textBox2.Text = tendv;
            }
            if (dataGridView1.Rows[CurrentIndex].Cells[3].Value != null)
            {
                giatien = dataGridView1.Rows[CurrentIndex].Cells[3].Value.ToString();
                textBox3.Text = soluong;
            }
            if (dataGridView1.Rows[CurrentIndex].Cells[2].Value != null)
            {
                soluong = dataGridView1.Rows[CurrentIndex].Cells[2].Value.ToString();
                textBox4.Text = soluong;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text.Equals("Thêm"))
            {
                button1.Text = "Lưu";
                button2.Text = "Hủy";
                clearTextBox(true, true, true, true);
                enableTextBox(false, true, true, true);
            }
            else if (button1.Text.Equals("Hủy"))
            {
                button1.Text = "Thêm";
                button2.Text = "Sửa";
                clearTextBox(true, true, true, true);
                enableTextBox(false, false, false, false);
            }
            else if (button1.Text.Equals("Lưu"))
            {
                try
                {
                    String tendv = textBox2.Text;
                    Int32 soluong = Int32.Parse(textBox4.Text);
                    Double gia = Double.Parse(textBox3.Text);
                    Entity.DichVu dichvu = new Entity.DichVu(tendv, soluong, gia);
                    bool result = BUS.DichVu_BUS.DichVu_add(dichvu);
                    if (result)
                    {
                        clearTextBox(true, true, true, true);
                        enableTextBox(false, false, false, false);
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Thêm thất bại");
                    }
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Dữ liệu không hợp lệ");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text.Equals("Sửa"))
            {
                String madv = textBox1.Text.ToString();
                if (!"".Equals(madv.Trim()))
                {
                    button1.Text = "Hủy";
                    button2.Text = "Lưu";
                    clearTextBox(false, true, true, true);
                    enableTextBox(false, true, true, true);
                }
            }
            else if (button2.Text.Equals("Hủy"))
            {
                button1.Text = "Thêm";
                button2.Text = "Sửa";
                clearTextBox(true, true, true, true);
                enableTextBox(false, false, false, false);
            }
            else if (button2.Text.Equals("Lưu"))
            {
                try {
                    Int32 madv = Int32.Parse(textBox1.Text);
                    String tendv = textBox2.Text;
                    Int32 soluong = Int32.Parse(textBox4.Text);
                    Double gia = Double.Parse(textBox3.Text);
                    Entity.DichVu dichvu = new Entity.DichVu(madv, tendv, soluong, gia);
                    bool result = BUS.DichVu_BUS.DichVu_update(dichvu);
                    if (result)
                    {
                        clearTextBox(true, true, true, true);
                        enableTextBox(false, false, false, false);
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Thêm thất bại");
                    }
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Dữ liệu không hợp lệ");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("Chọn 1 dịch vụ cần xóa");
            }
            else
            {

            }
        }
    }
}
