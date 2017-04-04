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
    public partial class quanlythuetra : Form
    {
        public string strConnection = @"Data Source=PHUONGLINH\SQLEXPRESS;Initial Catalog=QUANlYKHACHSAN;Integrated Security=True";
        public SqlConnection conn= null;
        public quanlythuetra()
        {
            InitializeComponent();
        }
        private void loadDatadv()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT TENDV FROM SUDUNGDV", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox8.DataSource = dt;
            comboBox8.ValueMember = "TENDV";
            comboBox8.DisplayMember = "TENDV";
        }

        private void loadDatamakh()
        {
            SqlDataAdapter dgvi = new SqlDataAdapter("SELECT MAKH from KHACHHANG", conn);
            DataTable dtnv = new DataTable();
            dgvi.Fill(dtnv);
            comboBox4.DataSource = dtnv;
            comboBox4.ValueMember = "MAKH";
            comboBox4.DisplayMember = "MAKH";
        }
        private void loadDatamadv()
        {
            SqlDataAdapter dgvi = new SqlDataAdapter("SELECT MADV from SUDUNGDV", conn);
            DataTable dtnv = new DataTable();
            dgvi.Fill(dtnv);
            comboBox1.DataSource = dtnv;
            comboBox1.ValueMember = "MADV";
            comboBox1.DisplayMember = "MADV";
        }
        private void loadDatatenkh()
        {
            SqlDataAdapter dgvtnv = new SqlDataAdapter("SELECT TENKH from KHACHHANG", conn);
            DataTable dttennv = new DataTable();
            dgvtnv.Fill(dttennv);
            comboBox7.DataSource = dttennv;
            comboBox7.ValueMember = "TENKH";
            comboBox7.DisplayMember = "TENKH";
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void quanlythuetra_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnection);
            conn.Open();
            loadDatadv();
            loadDatatenkh();
            loadDatamadv();
            loadDatamakh();


            }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("sp_khachhangphieuthue", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@Ma", comboBox4.Text);
            cmd.Parameters.Add(p);
            SqlDataAdapter dg = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dg.Fill(dt);
            comboBox4.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox4.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox7.DataSource = dt;
            comboBox7.DisplayMember = "TENKH";
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox3.Visible = true;
            comboBox8.Visible = true;
            comboBox9.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("sp_loaiphonggiatien", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@Ma", comboBox1.Text);
            cmd.Parameters.Add(p);
            SqlDataAdapter dg = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dg.Fill(dt);
            comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox10.DataSource = dt;
            comboBox10.DisplayMember = "GIATIEN";
        }
    }
}
