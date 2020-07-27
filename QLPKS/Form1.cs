using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPKS.Class;

namespace QLPKS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable tblCL;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.CHITIETTHUEPHONG' table. You can move, or remove it, as needed.
            //this.cHITIETTHUEPHONGTableAdapter.Fill(this.dataSet1.CHITIETTHUEPHONG);
            // TODO: This line of code loads data into the 'dataSet1.KHACH' table. You can move, or remove it, as needed.
            //this.kHACHTableAdapter.Fill(this.dataSet1.KHACH);
            Functions.Connect();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("Bạn có muốn thoát chương trình?", "Thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
            {
                this.Close();//thoát Form
                Application.Exit();//Thoát ứng dụng
            }
        }
        void Loadbang()
        {
            string sql;
            sql = "SELECT * FROM CHITIETHOADON";
            tblCL = Functions.GetDataToTable(sql);
            dataGridView1.DataSource = tblCL;
            dataGridView1.Columns[0].HeaderText = "Số HD";
            dataGridView1.Columns[1].HeaderText = "Số Phòng";
            dataGridView1.Columns[3].HeaderText = "Đon Giá";
            dataGridView1.Columns[3].HeaderText = "Số Ngày";
            dataGridView1.Columns[3].HeaderText = "Số Tiền Trả";
            dataGridView1.Columns[0].Width = 120;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].Width = 120;
            dataGridView1.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp}
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (tblCL.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            textBox1.Text = dataGridView1.CurrentRow.Cells["SOHD"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            textBox1.Enabled = true;
            string sql; //Lưu câu lệnh sql
            if (tblCL.Rows.Count == 0)
            {
                MessageBox.Show("Bạn có muốn thêm thông tin vào trong cơ sở dữ liệu không", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = @"INSERT INTO CHITIETHOADON (SOHD) 
                    VALUES (N'" + textBox1.Text + @"')";
            Class.Functions.RunSQL(sql);
            Loadbang();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblCL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE CHITIETHOADON WHERE SOHD=N'" + dataGridView1.CurrentRow.Cells["SOHD"].Value.ToString() + "'";
                Class.Functions.RunSqlDel(sql);
                Loadbang();
                //ResetValue();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Loadbang();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblCL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBox1.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = ("UPDATE CHITIETHOADON SET SOHD=N'" + textBox1.Text.ToString() + "' WHERE SOHD=N'" + dataGridView1.CurrentRow.Cells["SOHD"].Value.ToString() + "'");
            Class.Functions.RunSQL(sql);
            Loadbang();

         }
    }
}
