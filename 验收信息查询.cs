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
    public partial class 验收信息查询 : Form
    {
        public 验收信息查询()
        {
            InitializeComponent();
        }

        private void 验收信息查询_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(); //创建连接对象
            conn.ConnectionString = "Data Source=.;Initial Catalog=softwareSY;Integrated Security=True;";   //连接字符串
            conn.Open();  //建立连接

            if (conn.State != ConnectionState.Open)
            {
                MessageBox.Show("连接数据库失败");
            }
            //读
            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.CommandText = "select * from AcceptList";
            SqlDataReader reader = com.ExecuteReader();

            //用循环语句读取SQL查询获得的数据集。.
            while (reader.Read())   //读取一条数据

            {
                listBox1.Items.Add(reader[0].ToString());
            }
            reader.Close();
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                SqlConnection conn = new SqlConnection(); //创建连接对象
                try
                {

                    String olnum = listBox1.SelectedItem.ToString();


                    conn.ConnectionString = "Data Source=.;Initial Catalog=softwareSY;Integrated Security=True;";   //连接字符串
                    conn.Open();  //建立连接
                    SqlCommand com = new SqlCommand();
                    com.Connection = conn;
                    com.CommandText = "select * from AcceptList where OLNum='" + olnum + "'";
                    SqlDataReader reader = com.ExecuteReader();
                    reader.Read();
                    // textBox2.Text = reader[2].ToString();书名
                    textBox3.Text = reader[3].ToString();
                    textBox5.Text = reader[2].ToString();
                    textBox6.Text = reader[1].ToString();
                    reader.Close();
                    com.CommandText = "select * from OrderList where OLNum='" + olnum + "'";
                    reader = com.ExecuteReader();
                    reader.Read();
                    textBox2.Text = reader[1].ToString();
                    reader.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "错误信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text.ToString().Trim();
            if (s == null)
            {
                MessageBox.Show("请输入要查询的内容！");
            }
            listBox1.Items.Clear();
            SqlConnection conn = new SqlConnection(); //创建连接对象
            conn.ConnectionString = "Data Source=.;Initial Catalog=softwareSY;Integrated Security=True;";   //连接字符串
            conn.Open();  //建立连接
            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            System.Text.RegularExpressions.Regex r = new System.Text.RegularExpressions.Regex(@"^\d+$");
            if (r.IsMatch(s))
            {
                if (s.Length == 10)
                {
                    com.CommandText = "select OLNum from AcceptList where OLNum='" + s + "'";
                    SqlDataReader reader = com.ExecuteReader();

                    //用循环语句读取SQL查询获得的数据集。.
                    while (reader.Read())   //读取一条数据

                    {
                        listBox1.Items.Add(reader[0].ToString());
                    }
                    reader.Close();
                    conn.Close();
                }
                else if (s.Length == 13)
                {
                    com.CommandText = "select OLNum from AcceptList where OLNum in ( select OLNum from OrderList where ISBN='" + s + "')";
                    SqlDataReader reader = com.ExecuteReader();

                    //用循环语句读取SQL查询获得的数据集。.
                    while (reader.Read())   //读取一条数据

                    {
                        listBox1.Items.Add(reader[0].ToString());
                    }
                    reader.Close();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("数字位数不正确！应为13位ISBN号或10位订单号！");
                }

            }
            else
            {
                com.CommandText = "select OLNum from AcceptList where OLNum in ( select OLNum from OrderList where BookName='" + s + "')";
                SqlDataReader reader = com.ExecuteReader();

                //用循环语句读取SQL查询获得的数据集。.
                while (reader.Read())   //读取一条数据

                {
                    listBox1.Items.Add(reader[0].ToString());
                }
                reader.Close();
                conn.Close();
            }
            this.textBox2.Clear();
            this.textBox3.Clear();
            this.textBox5.Clear();
            this.textBox6.Clear();
        }

    } 
}
    

    

