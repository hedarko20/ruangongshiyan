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
    public partial class 推荐图书 : Form
    {
        public 推荐图书()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void 推荐图书_Load(object sender, EventArgs e)
        {

            string recname = 主界面.Mainuser;
            textBox6.Text = recname;
            textBox6.ReadOnly = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string bookname = textBox1.Text.ToString().Trim();
            string edition = textBox2.Text.ToString().Trim();
            string bookAuthor = textBox3.Text.ToString().Trim();
            string bookPress = textBox4.Text.ToString().Trim();
            string ISBN = textBox5.Text.ToString().Trim();
            string recname =textBox6.Text ;
            if (bookname == null || edition == null || bookAuthor == null || bookPress == null || ISBN == null)
            {
                MessageBox.Show("书名，版次，作者，出版社，ISBN号全部不为空，请重新输入！");
            }
            else
            {
                SqlConnection conn = new SqlConnection(); //创建连接对象
                conn.ConnectionString = "Data Source=.;Initial Catalog=softwareSY;Integrated Security=True;";   //连接字符串
                conn.Open();
                SqlCommand com = new SqlCommand();
                com.Connection = conn;
                com.CommandText = "select * from InterInfo where BookName='" + bookname + "' and Edition='" + edition + "' and BookAuthor= '" + bookAuthor + "' and BookPress='" + bookPress + "'";
                string t = (string)com.ExecuteScalar();
                SqlDataReader reader = com.ExecuteReader();
                string flag="";
                if (reader.Read())
                {
                    flag =reader.GetValue(6).ToString();
                }
                reader.Close();
                if (t == null)
                {
                    //采访初表中没有该书记录,需要插入该条记录
                    int m = 1;
                    char p = '0';
                    com.CommandText = "insert into InterInfo(BookName,Edition,BookAuthor,BookPress,ISBN,BookAmount,Flag)values('" + bookname + "','" + edition + "','" + bookAuthor + "','" + bookPress + "','" + ISBN + "'," + m + ",'" + p + "')";

                    int n = com.ExecuteNonQuery();
                    if (n < 1)
                    {
                        MessageBox.Show("推荐失败");
                    }
                    else
                    {
                        MessageBox.Show("推荐成功");
                        this.Close();
                    }
                }
                else if(flag=="1")
                {
                    //采访初表有该书记录但已经筛选过，需要删掉再插入一条数据
                    com.CommandText = "delete from InterInfo where BookName='" + bookname + "' and Edition='" + edition + "' and BookAuthor= '" + bookAuthor + "' and BookPress='" + bookPress + "'";
                    int tt = com.ExecuteNonQuery();
                    if (tt < 1)
                    {
                        MessageBox.Show("推荐失败");
                    }
                    else
                    {
                        int m = 1;
                        char p = '0';
                        com.CommandText = "insert into InterInfo(BookName,Edition,BookAuthor,BookPress,ISBN,BookAmount,Flag)values('" + bookname + "','" + edition + "','" + bookAuthor + "','" + bookPress + "','" + ISBN + "'," + m + ",'" + p + "')";
                        int n = com.ExecuteNonQuery();
                        if (n < 1)
                        {
                            MessageBox.Show("推荐失败");
                        }
                        else
                        {
                            MessageBox.Show("推荐成功");
                            this.Close();
                        }
                    }
                  
                }
                else
                {
                    //采访初表中有该书记录，需要更新推荐次数
                    SqlDataReader reader1 = com.ExecuteReader();
                    int x = 0;
                    if (reader1.Read())
                    {
                        x = int.Parse(reader1.GetValue(5).ToString());
                    }
                    reader1.Close();
                    x += 1;
                    com.CommandText = "update InterInfo set BookAmount='" + x + "'"+ "where BookName = '" + bookname + "' and Edition = '" + edition + "' and BookAuthor = '" + bookAuthor + "' and BookPress = '" + bookPress + "'";
                    int n = com.ExecuteNonQuery();
                    if (n < 1)
                    {
                        MessageBox.Show("推荐失败");
                    }
                    else
                    {
                        MessageBox.Show("推荐成功");
                        this.Close();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}


