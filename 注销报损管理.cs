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

namespace LibraryManagement
{
    public partial class 注销报损管理 : Form
    {
        public 注销报损管理()
        {
            InitializeComponent();
        }
        private DataSet ds = new DataSet();
        private SqlDataAdapter da = new SqlDataAdapter();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 注销报损管理_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(); //创建连接对象
            conn.ConnectionString = "Data Source=.;Initial Catalog=softwareSY;Integrated Security=True;";   //连接字符串
            SqlCommand command = new SqlCommand("select * from DamagedBook", conn);
            da.SelectCommand = command;
            da.Fill(ds, "damagedbook");
            dataGridView1.DataSource = ds.Tables["damagedbook"];
            dataGridView1.Columns["BookNum"].HeaderText = "书目号";
            dataGridView1.Columns["DBReason"].HeaderText = "原因";
            dataGridView1.Columns["DBRegistrar"].HeaderText = "登记人";
            dataGridView1.Columns["Time"].HeaderText = "时间";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            DataRow dr = ds.Tables["damagedbook"].Rows[index];
            //form1.MdiParent = this;
            SqlConnection conn = new SqlConnection(); //创建连接对象
            conn.ConnectionString = "Data Source=.;Initial Catalog=softwareSY;Integrated Security=True;";   //连接字符串
            conn.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandText = "select * from CancelList where BookNum='" + dr[2].ToString() + "'";
            string t = (string)com.ExecuteScalar();
            if (t != null)
            {
                MessageBox.Show("该书已经注销！");
            }
            else
            {
                string user = 主界面.Mainuser;
                Form form1 = new 注销(dr[2].ToString(), user);
                form1.Show();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
