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
    public partial class 采访收集 : Form
    {
        public 采访收集()
        {
            InitializeComponent();
        }
        private DataSet ds = new DataSet();
        private SqlDataAdapter da = new SqlDataAdapter();
        private void 采访收集_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(); //创建连接对象
            conn.ConnectionString = "Data Source=.;Initial Catalog=softwareSY;Integrated Security=True;";   //连接字符串
            SqlCommand command = new SqlCommand("select * from InterList", conn);
            da.SelectCommand = command;
            da.Fill(ds, "interlist");
            dataGridView1.DataSource = ds.Tables["interlist"];
            dataGridView1.Columns["Bookname"].HeaderText = "书名";
            dataGridView1.Columns["Edition"].HeaderText = "版次";
            dataGridView1.Columns["BookAuthor"].HeaderText = "作者";
            dataGridView1.Columns["BookPress"].HeaderText = "出版社";
            dataGridView1.Columns["ISBN"].HeaderText = "ISBN";
            dataGridView1.Columns["BookAmount"].HeaderText = "推荐次数";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ds.Tables.Clear();
            SqlConnection conn = new SqlConnection(); //创建连接对象
            conn.ConnectionString = "Data Source=.;Initial Catalog=softwareSY;Integrated Security=True;";   //连接字符串
            SqlCommand command = new SqlCommand("select * from InterList", conn);
            da.SelectCommand = command;
            da.Fill(ds, "interlist");
            dataGridView1.DataSource = ds.Tables["interlist"];
            dataGridView1.Columns["Bookname"].HeaderText = "书名";
            dataGridView1.Columns["Edition"].HeaderText = "版次";
            dataGridView1.Columns["BookAuthor"].HeaderText = "作者";
            dataGridView1.Columns["BookPress"].HeaderText = "出版社";
            dataGridView1.Columns["ISBN"].HeaderText = "ISBN";
            dataGridView1.Columns["BookAmount"].HeaderText = "推荐次数";
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text.ToString().Trim();
            if(s==null)
            {
                MessageBox.Show("请输入要查询的内容！");
            }
           
            SqlConnection conn = new SqlConnection(); //创建连接对象
            conn.ConnectionString = "Data Source=.;Initial Catalog=softwareSY;Integrated Security=True;";   //连接字符串
            SqlCommand command = new SqlCommand();
            System.Text.RegularExpressions.Regex r = new System.Text.RegularExpressions.Regex(@"^\d+$");
            if (r.IsMatch(s))
            {
                if(s.Length==13)
                {
                    command = new SqlCommand("select * from InterList where ISBN='" + s + "'", conn);
                }
                else
                {
                    MessageBox.Show("ISBN号应该为十三位数字！请重新输入！");
                }
               
            } 
            else
            {
                command = new SqlCommand("select * from InterList where Bookname='" + s + "' or BookAuthor='" + s + "'", conn);
            }
            da.SelectCommand = command;
            ds.Tables.Clear();
            da.Fill(ds, "interlist");
            dataGridView1.DataSource = ds.Tables["interlist"];
            dataGridView1.Columns["Bookname"].HeaderText = "书名";
            dataGridView1.Columns["Edition"].HeaderText = "版次";
            dataGridView1.Columns["BookAuthor"].HeaderText = "作者";
            dataGridView1.Columns["BookPress"].HeaderText = "出版社";
            dataGridView1.Columns["ISBN"].HeaderText = "ISBN";
            dataGridView1.Columns["BookAmount"].HeaderText = "推荐次数";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(ds, "interlist");
            }
            catch
            {
                MessageBox.Show("保存失败！");
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            DataRow dr = ds.Tables["interlist"].Rows[index];
            DialogResult dx = MessageBox.Show("确认删除吗","提示",MessageBoxButtons.OKCancel);
            if(dx==DialogResult.OK)
            {
                dr.Delete();
                MessageBox.Show("删除成功");
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(ds, "interlist");
            }
            else
            {
                MessageBox.Show("删除取消");
            }

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
