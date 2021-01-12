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
    public partial class 采访筛选 : Form
    {  
        private DataSet ds = new DataSet();
        private SqlDataAdapter da = new SqlDataAdapter();
        public 采访筛选()
        {
            InitializeComponent();
        }
     
        private void 采访筛选_Load(object sender, EventArgs e)
        {
           
            SqlConnection conn = new SqlConnection(); //创建连接对象
            conn.ConnectionString = "Data Source=.;Initial Catalog=softwareSY;Integrated Security=True;";   //连接字符串
            SqlCommand command = new SqlCommand("select * from InterInfo", conn);
            da.SelectCommand = command;
            da.Fill(ds, "interinfo");
            dataGridView1.DataSource = ds.Tables["interinfo"];
            dataGridView1.Columns["Bookname"].HeaderText = "书名";
            dataGridView1.Columns["Edition"].HeaderText = "版次";
            dataGridView1.Columns["BookAuthor"].HeaderText = "作者";
            dataGridView1.Columns["BookPress"].HeaderText = "出版社";
            dataGridView1.Columns["ISBN"].HeaderText = "ISBN";
            dataGridView1.Columns["BookAmount"].HeaderText = "推荐次数";
            dataGridView1.Columns["Flag"].HeaderText = "筛选否";
        }
       
        private void button5_Click(object sender, EventArgs e)
        {
            ds.Tables.Clear();
            SqlConnection conn = new SqlConnection(); //创建连接对象
            conn.ConnectionString = "Data Source=.;Initial Catalog=softwareSY;Integrated Security=True;";   //连接字符串
            SqlCommand command = new SqlCommand("select * from InterInfo", conn);
            da.SelectCommand = command;
            da.Fill(ds, "interinfo");
            dataGridView1.DataSource = ds.Tables["interinfo"];
            dataGridView1.Columns["Bookname"].HeaderText = "书名";
            dataGridView1.Columns["Edition"].HeaderText = "版次";
            dataGridView1.Columns["BookAuthor"].HeaderText = "作者";
            dataGridView1.Columns["BookPress"].HeaderText = "出版社";
            dataGridView1.Columns["ISBN"].HeaderText = "ISBN";
            dataGridView1.Columns["BookAmount"].HeaderText = "推荐次数";
            dataGridView1.Columns["Flag"].HeaderText = "筛选否";
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
                if (s.Length == 13)
                {
                    command = new SqlCommand("select * from InterInfo where ISBN='" + s + "'", conn);
                }
                else
                {
                    MessageBox.Show("ISBN号应该为十三位数字！请重新输入！");

                }
                
            }
            else
            {
                    command = new SqlCommand("select * from InterInfo where Bookname='" + s + "'" + "or BookAuthor='" + s + "'", conn);
            }
            
            da.SelectCommand = command;
            ds.Tables.Clear();
            da.Fill(ds, "interinfo");
            dataGridView1.DataSource = ds.Tables["interinfo"];
            dataGridView1.Columns["Bookname"].HeaderText = "书名";
            dataGridView1.Columns["Edition"].HeaderText = "版次";
            dataGridView1.Columns["BookAuthor"].HeaderText = "作者";
            dataGridView1.Columns["BookPress"].HeaderText = "出版社";
            dataGridView1.Columns["ISBN"].HeaderText = "ISBN";
            dataGridView1.Columns["BookAmount"].HeaderText = "推荐次数";
            dataGridView1.Columns["Flag"].HeaderText = "筛选否";
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            int index = dataGridView1.CurrentRow.Index;
            DataRow dr = ds.Tables["interinfo"].Rows[index];
            SqlConnection conn = new SqlConnection(); //创建连接对象
            conn.ConnectionString = "Data Source=.;Initial Catalog=softwareSY;Integrated Security=True;";   //连接字符串
            conn.Open();  //建立连接
            SqlCommand com = new SqlCommand(); 
            com.Connection = conn;
            if(dr[6].ToString().Equals("1"))
            {
                MessageBox.Show("采访信息已经被筛选确认过！");
            }
           else
            {
                com.CommandText = "select * from InterList where Bookname='" + dr[0].ToString() + " 'and Edition='" + dr[1].ToString() + " 'and BookAuthor='" + dr[2].ToString() + " 'and BookPress='" + dr[3].ToString() + "'";
                string t = (string)com.ExecuteScalar();
                if (t==null)
                {
                    //采访信息表中没有该书，需要插入一行新纪录,同时修改采访信息初表的标志位
                    com.CommandText = "insert into InterList(Bookname,Edition,BookAuthor,BookPress,ISBN,BookAmount)values('" + dr[0].ToString() + "','" + dr[1].ToString() + "','" + dr[2].ToString() + "','" + dr[3].ToString() + "','" + dr[4].ToString() + "','" + dr[5].ToString() + "')";
                    int n = com.ExecuteNonQuery();
                    if (n < 1)
                    {
                        MessageBox.Show("添加失败");
                    }
                    else
                    {
                        MessageBox.Show("添加成功");
                        dr.BeginEdit();
                        dr["Flag"] = '1';
                        dr.EndEdit();
                        SqlCommandBuilder cb = new SqlCommandBuilder(da);
                        da.Update(ds, "interinfo");
                        
                    }

                }
                else
                {
                    //采访信息表中已经有该书，只需要更新数目，同时修改采访信息初表的标志位
                    SqlDataReader reader = com.ExecuteReader();
                    reader.Read();
                    int s = int.Parse(reader[5].ToString()) + int.Parse(dr[5].ToString());
                    reader.Close();
                    com.CommandText = "update InterList set BookAmount='" + s.ToString() +"' where Bookname = '" + dr[0].ToString() + " 'and Edition = '" + dr[1].ToString() + " 'and BookAuthor = '" + dr[2].ToString() + " 'and BookPress = '" + dr[3].ToString() + "'";
                    int n = com.ExecuteNonQuery();
                    if (n < 1)
                    {
                        MessageBox.Show("更新失败");
                    }
                    else
                    {
                        MessageBox.Show("更新成功");
                        dr.BeginEdit();
                        dr["Flag"] = '1';
                        dr.EndEdit();
                        SqlCommandBuilder cb = new SqlCommandBuilder(da);
                        da.Update(ds, "interinfo");
                    }

                }
            }
           
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ds.Tables.Clear();
            SqlConnection conn = new SqlConnection(); //创建连接对象
            conn.ConnectionString = "Data Source=.;Initial Catalog=softwareSY;Integrated Security=True;";   //连接字符串
            SqlCommand command = new SqlCommand("select * from InterInfo where Flag='0'", conn);
            da.SelectCommand = command;
            da.Fill(ds, "interinfo");
            dataGridView1.DataSource = ds.Tables["interinfo"];
            dataGridView1.Columns["Bookname"].HeaderText = "书名";
            dataGridView1.Columns["Edition"].HeaderText = "版次";
            dataGridView1.Columns["BookAuthor"].HeaderText = "作者";
            dataGridView1.Columns["BookPress"].HeaderText = "出版社";
            dataGridView1.Columns["ISBN"].HeaderText = "ISBN";
            dataGridView1.Columns["BookAmount"].HeaderText = "推荐次数";
            dataGridView1.Columns["Flag"].HeaderText = "筛选否";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
