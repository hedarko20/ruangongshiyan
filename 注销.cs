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
    public partial class 注销 : Form
    {
        public 注销()
        {
            InitializeComponent();
        }
        private string user;
        private string booknum;
        private string date;
        private string reason;
        public 注销(string num1, string name1)
        {
            InitializeComponent();
            booknum = num1;
            user = name1;


        }
        private void 注销_Load(object sender, EventArgs e)
        {
            textBox1.Text = booknum;
            textBox3.Text = user;
            date = DateTime.Now.ToString();
            textBox4.Text = date;
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reason = textBox2.Text.Trim();
            if (reason == "")
            {
                MessageBox.Show("原因不应为空，请重新输入！");
            }
            else
            {

                DialogResult dx = MessageBox.Show("确认注销吗", "提示", MessageBoxButtons.OKCancel);
                if (dx == DialogResult.OK)
                {
                    SqlConnection conn = new SqlConnection(); //创建连接对象
                    conn.ConnectionString = "Data Source=.;Initial Catalog=softwareSY;Integrated Security=True;";   //连接字符串
                    conn.Open();
                    SqlCommand com = new SqlCommand();
                    com.Connection = conn;
                    com.CommandText = "select * from Book where BookNum='" + booknum + "'";
                    SqlDataReader reader = com.ExecuteReader();
                    string bookname = "";
                    string bookpress = "";
                    string bookAuthor = "";
                    string edition = "";
                    string isbn = "";
                    //用循环语句读取SQL查询获得的数据集。.
                    while (reader.Read())   //读取一条数据

                    {
                        bookname = reader[1].ToString();
                        bookAuthor = reader[2].ToString();
                        bookpress = reader[3].ToString();
                        edition = reader[4].ToString();
                        isbn = reader[5].ToString();
                    }
                    reader.Close();
                    string clnum = "";
                    com.CommandText = "select CLNumber from CancelList";
                    SqlDataReader reader1 = com.ExecuteReader();
                    while (reader1.Read())   //读取一条数据
                    {
                        clnum = reader1[0].ToString();
                    }
                    reader1.Close();
                    if (clnum == "")
                    {
                        clnum = "0000000001";
                    }
                    else
                    {
                        int num = int.Parse(clnum);
                        num += 1;
                        clnum = num.ToString().PadLeft(10, '0');

                    }

                    com.CommandText = "insert into CancelList(CLNumber,CLReason,BookNum,ISBN,BookName,BookPress,BookAuthor,Edition)values('" + clnum + "','" + reason + "','" + booknum + "','" + isbn + "','" + bookname + "','" + bookpress + "','" + bookAuthor + "','" + edition + "')";
                    int t1 = com.ExecuteNonQuery();
                    if (t1 < 1)
                    {
                        MessageBox.Show("注销失败");
                    }
                    else
                    {
                        com.CommandText = "insert into CABook(CLNumber,CLReason,CABRegistrar,CATime)values('" + clnum + "','" + reason + "','" + user + "','" + date + "')";
                        int t2 = com.ExecuteNonQuery();
                        if (t2 < 1)
                        {
                            MessageBox.Show("注销失败");
                        }
                        else
                        {
                            com.CommandText = "delete from BooK where BookNum='" + booknum + "'";
                            int t3 = com.ExecuteNonQuery();
                            if (t3 < 1)
                            {
                                MessageBox.Show("注销失败");
                            }
                            else
                            {
                                MessageBox.Show("注销成功");
                            }
                        }
                    }
                }

                else
                {
                    MessageBox.Show("注销取消");
                }

            }

             
        }

      /*  private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // 注销
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "注销";
            this.Load += new System.EventHandler(this.注销_Load_1);
            this.ResumeLayout(false);

        }*/

        private void 注销_Load_1(object sender, EventArgs e)
        {

        }
    }

  }
    

