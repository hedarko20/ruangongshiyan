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
    public partial class 订单管理 : Form
    {
        private DataSet ds = new DataSet();
        private SqlDataAdapter da = new SqlDataAdapter();
        public 订单管理()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

         private void button5_Click(object sender, EventArgs e)
         {
        int index = dataGridView1.CurrentRow.Index;
        DataRow dr = ds.Tables["orderlist"].Rows[index];
        //form1.MdiParent = this;
        string alname = 主界面.Mainuser;
        Form form1 = new 退货(dr[0].ToString(), dr[10].ToString(), alname);
        form1.Show();

        }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 订单管理_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(); //创建连接对象
            conn.ConnectionString = "Data Source=.;Initial Catalog=softwareSY;Integrated Security=True;";   //连接字符串
            SqlCommand command = new SqlCommand("select * from OrderList", conn);
            da.SelectCommand = command;
            da.Fill(ds, "orderlist");
            dataGridView1.DataSource = ds.Tables["orderlist"];
            dataGridView1.Columns["OLNum"].HeaderText = "订单号";
            dataGridView1.Columns["BookName"].HeaderText = "书名";
            dataGridView1.Columns["Edition"].HeaderText = "版本";
            dataGridView1.Columns["BookAuthor"].HeaderText = "作者";
            dataGridView1.Columns["BookPress"].HeaderText = "出版商";
            dataGridView1.Columns["ISBN"].HeaderText = "ISBN";
            dataGridView1.Columns["BookSeller"].HeaderText = "书商";
            dataGridView1.Columns["OLPrice"].HeaderText = "价格";
            dataGridView1.Columns["OLdate"].HeaderText = "日期";
            dataGridView1.Columns["OLName"].HeaderText = "订货人";
            dataGridView1.Columns["OLamount"].HeaderText = "数量";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ds.Tables.Clear();
            SqlConnection conn = new SqlConnection(); //创建连接对象
            conn.ConnectionString = "Data Source=.;Initial Catalog=softwareSY;Integrated Security=True;";   //连接字符串
            SqlCommand command = new SqlCommand("select * from OrderList", conn);
            da.SelectCommand = command;
            da.Fill(ds, "orderlist");
            dataGridView1.DataSource = ds.Tables["orderlist"];
            dataGridView1.Columns["OLNum"].HeaderText = "订单号";
            dataGridView1.Columns["BookName"].HeaderText = "书名";
            dataGridView1.Columns["Edition"].HeaderText = "版本";
            dataGridView1.Columns["BookAuthor"].HeaderText = "作者";
            dataGridView1.Columns["ISBN"].HeaderText = "ISBN";
            dataGridView1.Columns["BookSeller"].HeaderText = "书商";
            dataGridView1.Columns["OLPrice"].HeaderText = "价格";
            dataGridView1.Columns["OLdate"].HeaderText = "日期";
            dataGridView1.Columns["OLName"].HeaderText = "订货人";
            dataGridView1.Columns["OLamount"].HeaderText = "数量";
            dataGridView1.Columns["BookPress"].HeaderText = "出版商";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(ds, "orderlist");
                MessageBox.Show("保存成功！");
            }
            catch
            {
                MessageBox.Show("保存失败！");
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            DataRow dr = ds.Tables["orderlist"].Rows[index];
            DialogResult dx = MessageBox.Show("确认删除吗", "提示", MessageBoxButtons.OKCancel);
            if (dx == DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection(); //创建连接对象
                conn.ConnectionString = "Data Source=.;Initial Catalog=softwareSY;Integrated Security=True;";   //连接字符串
                conn.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = conn;
                com.CommandText = "select * from AcceptList where OLNum='" + dr[0].ToString()+ "'";
                string t = (string)com.ExecuteScalar();
                com.CommandText = "select * from ReturnList where OLNum='" + dr[0].ToString() + "'";
                string t1 = (string)com.ExecuteScalar();
                if (t== null&&t1==null)
                {
                     dr.Delete();
                     MessageBox.Show("删除成功");
                     SqlCommandBuilder cb = new SqlCommandBuilder(da);
                     da.Update(ds, "orderlist");
                }
                else
                {
                    MessageBox.Show("删除失败！因为在退货清单或验收清单中有该订单记录！");
                }
                   
            }
            else
            {
                MessageBox.Show("删除取消");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            int index = dataGridView1.CurrentRow.Index;
            DataRow dr = ds.Tables["orderlist"].Rows[index];
            //form1.MdiParent = this;
             string alname = 主界面.Mainuser;
             Form form1 = new 验收(dr[0].ToString(),dr[10].ToString(),alname);
             form1.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text.ToString().Trim();
            if (s == null)
            {
                MessageBox.Show("请输入要查询的内容！");
            }

            SqlConnection conn = new SqlConnection(); //创建连接对象
            conn.ConnectionString = "Data Source=.;Initial Catalog=softwareSY;Integrated Security=True;";   //连接字符串
            SqlCommand command = new SqlCommand();
            System.Text.RegularExpressions.Regex r = new System.Text.RegularExpressions.Regex(@"^\d+$");
            if (r.IsMatch(s))
            {
                if (s.Length == 10)
                {
                    command = new SqlCommand("select * from OrderList where OLNum='" + s + "'", conn);
                    da.SelectCommand = command;
                    ds.Tables.Clear();
                    da.Fill(ds, "orderlist");
                    dataGridView1.DataSource = ds.Tables["orderlist"];
                    dataGridView1.Columns["OLNum"].HeaderText = "订单号";
                    dataGridView1.Columns["BookName"].HeaderText = "书名";
                    dataGridView1.Columns["Edition"].HeaderText = "版本";
                    dataGridView1.Columns["BookAuthor"].HeaderText = "作者";
                    dataGridView1.Columns["ISBN"].HeaderText = "ISBN";
                    dataGridView1.Columns["BookSeller"].HeaderText = "书商";
                    dataGridView1.Columns["OLPrice"].HeaderText = "价格";
                    dataGridView1.Columns["OLdate"].HeaderText = "日期";
                    dataGridView1.Columns["OLName"].HeaderText = "订货人";
                    dataGridView1.Columns["OLamount"].HeaderText = "数量";
                }
                else
                {
                        MessageBox.Show("订单号应该为十位数字！请重新输入！");
                }
               
            }
            else
            {
                command = new SqlCommand("select * from OrderList where BookName='" + s + "'", conn);
                da.SelectCommand = command;
                ds.Tables.Clear();
                da.Fill(ds, "orderlist");
                dataGridView1.DataSource = ds.Tables["orderlist"];
                dataGridView1.Columns["OLNum"].HeaderText = "订单号";
                dataGridView1.Columns["BookName"].HeaderText = "书名";
                dataGridView1.Columns["Edition"].HeaderText = "版本";
                dataGridView1.Columns["BookAuthor"].HeaderText = "作者";
                dataGridView1.Columns["ISBN"].HeaderText = "ISBN";
                dataGridView1.Columns["BookSeller"].HeaderText = "书商";
                dataGridView1.Columns["OLPrice"].HeaderText = "价格";
                dataGridView1.Columns["OLdate"].HeaderText = "日期";
                dataGridView1.Columns["OLName"].HeaderText = "订货人";
                dataGridView1.Columns["OLamount"].HeaderText = "数量";
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
