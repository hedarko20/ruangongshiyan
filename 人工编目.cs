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
    public partial class 人工编目 : Form
    {
        public 人工编目()
        {
            InitializeComponent();
        }
        private DataSet ds = new DataSet();
        private SqlDataAdapter da = new SqlDataAdapter();
        private void 人工编目_Load(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(); //创建连接对象
            //conn.ConnectionString = "Data Source=.;Initial Catalog=softwareSY;Integrated Security=True;";   //连接字符串
            //SqlCommand command2 = new SqlCommand("select * from SendBook", conn);
            //da.SelectCommand = command2;
            //da.Fill(ds, "sendbook");
            //dataGridView1.DataSource = ds.Tables["sendbook"];
            //dataGridView1.Columns["BookNum"].HeaderText = "书目号";
            //dataGridView1.Columns["ISBN"].HeaderText = "ISBN号";
            //dataGridView1.Columns["BookID"].HeaderText = "分类号";
            //dataGridView1.Columns["BookName"].HeaderText = "书籍名称";
            //dataGridView1.Columns["BookAuthor"].HeaderText = "作者";
            //dataGridView1.Columns["BookPress"].HeaderText = "出版社";
            //dataGridView1.Columns["Edition"].HeaderText = "版本";
            //this.dataGridView1.Columns["BookNum"].ReadOnly = true;
            //this.dataGridView1.Columns["ISBN"].ReadOnly = true;
            //this.dataGridView1.Columns["Edition"].ReadOnly = true;
            //this.dataGridView1.Columns["BookName"].ReadOnly = true;
            //this.dataGridView1.Columns["BookAuthor"].ReadOnly = true;
            //this.dataGridView1.Columns["BookNum"].ReadOnly = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            //this.textBox2.Clear();
            this.textBox3.Clear();
            this.textBox4.Clear();
            this.textBox5.Clear();
            this.textBox6.Clear();
            this.textBox7.Clear();
        }
        string booknum = "";
        string isbn = "";
        string bookname = "";
        string bookauthor = "";
        string bookpress = "";
        string edition = "";
        string bookid = "";
        private void button1_Click(object sender, EventArgs e)
        {
            booknum = textBox1.Text.ToString().Trim();
            isbn = textBox3.Text.ToString().Trim();
            bookname = textBox4.Text.ToString().Trim();
            bookauthor = textBox5.Text.ToString().Trim();
            bookpress = textBox6.Text.ToString().Trim();
            edition = textBox7.Text.ToString().Trim();
            if (booknum == "" || isbn == "" || bookname == "" || bookauthor == "" || edition == "" || bookpress == "" || bookid == "")
            {
                MessageBox.Show("输入项不允许为空！");
            }
            else
            {
                //检查格式
                System.Text.RegularExpressions.Regex r = new System.Text.RegularExpressions.Regex(@"^\d+$");
                if (r.IsMatch(booknum))
                {
                    if (booknum.Length != 15)
                    {
                        MessageBox.Show("书目号应该为十五位数字！请重新输入！");
                    }
                }
                else
                {
                    MessageBox.Show("书目号应该为十五位数字！请重新输入！");
                }
                if (r.IsMatch(isbn))
                {
                    if (isbn.Length != 13)
                    {
                        MessageBox.Show("ISBN应该为十三位数字！请重新输入！");
                    }

                }
                else
                {
                    MessageBox.Show("ISBN应该为十三位数字！请重新输入！");

                }
                if (r.IsMatch(booknum) && r.IsMatch(isbn) && booknum.Length == 15 && isbn.Length == 13)
                {
                    SqlConnection conn = new SqlConnection(); //创建连接对象
                    conn.ConnectionString = "Data Source=.;Initial Catalog=softwareSY;Integrated Security=True;";   //连接字符串
                    conn.Open();  //建立连接
                    SqlCommand com = new SqlCommand();
                    com.Connection = conn;
                    com.CommandText = "select BookNum from BooK where BookNum='" + booknum + "'";
                    string t1 = (string)com.ExecuteScalar();
                    com.CommandText = "select BookNum from SendBook where BookNum='" + booknum + "'";
                    string t2 = (string)com.ExecuteScalar();
                    if (t1 == null && t2 == null)
                    {
                        com.CommandText = "insert into SendBook(BookName,Edition,BookAuthor,BookPress,ISBN,BookNum,BookID)values('" + bookname + "','" + edition + "','" + bookauthor + "','" + bookpress + "','" + isbn + "','" + booknum + "','" + bookid + "')";
                        int n = com.ExecuteNonQuery();
                        if (n < 1)
                        {
                            MessageBox.Show("编目失败");
                        }
                        else
                        {
                            //ds.Tables["sendbook"].Clear();
                            //SqlCommand command2 = new SqlCommand("select * from SendBook", conn);
                            //da.SelectCommand = command2;
                            //da.Fill(ds, "sendbook");
                            //dataGridView1.DataSource = ds.Tables["sendbook"];
                            //dataGridView1.Columns["BookNum"].HeaderText = "书目号";
                            //dataGridView1.Columns["ISBN"].HeaderText = "ISBN号";
                            //dataGridView1.Columns["BookID"].HeaderText = "分类号";
                            //dataGridView1.Columns["BookName"].HeaderText = "书籍名称";
                            //dataGridView1.Columns["BookAuthor"].HeaderText = "作者";
                            //dataGridView1.Columns["BookPress"].HeaderText = "出版社";
                            //dataGridView1.Columns["Edition"].HeaderText = "版本";
                            //this.dataGridView1.Columns["BookNum"].ReadOnly = true;
                            //this.dataGridView1.Columns["ISBN"].ReadOnly = true;
                            //this.dataGridView1.Columns["Edition"].ReadOnly = true;
                            //this.dataGridView1.Columns["BookName"].ReadOnly = true;
                            //this.dataGridView1.Columns["BookAuthor"].ReadOnly = true;
                            //this.dataGridView1.Columns["BookPress"].ReadOnly = true;
                            MessageBox.Show("编目成功！");
                        }
                    }
                    else
                    {
                        MessageBox.Show("该书目号已存在，请重新输入！");
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string s = listBox1.SelectedItem.ToString();
                bookid= s.Substring(0, 4).Trim();
            }
        }
    }
}
