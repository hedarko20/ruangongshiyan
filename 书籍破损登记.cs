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
    public partial class 书籍破损登记 : Form
    {
        public 书籍破损登记()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string booknum = "";
            string reason = "";
            booknum = textBox1.Text.ToString().Trim();
            reason = textBox2.Text.ToString().Trim();
            int flag = 0;
            if (booknum == "" || reason == "")
            {
                MessageBox.Show("书目号,原因不为空！");
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
                    else
                    {
                        flag = 1;
                    }
                }
                else
                {
                    MessageBox.Show("书目号应该为十五位数字！请重新输入！");
                }
            }
            if (flag == 1)
            {
                SqlConnection conn = new SqlConnection(); //创建连接对象
                conn.ConnectionString = "Data Source=.;Initial Catalog=softwareSY;Integrated Security=True;";   //连接字符串
                conn.Open();  //建立连接
                SqlCommand com = new SqlCommand();
                com.Connection = conn;
                com.CommandText = "select BookNum from BooK where BookNum='" + booknum + "'";
                string t1 = (string)com.ExecuteScalar();
                if (t1 == null)
                {
                    MessageBox.Show("登记失败,书目号不存在！");
                }
                else
                {
                    com.CommandText = "select BookNum from DamagedBook where BookNum='" + booknum + "'";
                    string t2 = (string)com.ExecuteScalar();
                    if (t2 != null)
                    {
                        MessageBox.Show("该书已经登记过！");
                    }
                    else
                    {
                        com.CommandText = "insert into DamagedBook(BookNum,DBReason,DBRegistrar,Time)values('" + booknum + "','" + reason + "','" + user + "','" + time + "')";
                        int n = com.ExecuteNonQuery();
                        if (n < 1)
                        {
                            MessageBox.Show("登记失败！");
                        }
                        else
                        {
                            MessageBox.Show("登记成功！");
                        }
                    }

                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string user = 主界面.Mainuser;
        string time = DateTime.Now.ToString();
        private void 书籍破损登记_Load(object sender, EventArgs e)
        {
            
            textBox3.Text = user;
            textBox4.Text = time;    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
        }

      /*  private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // 书籍破损登记
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "书籍破损登记";
            this.Load += new System.EventHandler(this.书籍破损登记_Load_1);
            this.ResumeLayout(false);

        }*/

        private void 书籍破损登记_Load_1(object sender, EventArgs e)
        {

        }
    }
}
