using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class FormChangeUserName : Form
    {
        public FormChangeUserName()
        {
            InitializeComponent();
        }

        private string username;
        public FormChangeUserName(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private bool check_pass(string username, string username1, string username2)
        {
            if (username == "")
            {
                MessageBox.Show("原始用户名不能为空");
                return false;
            }
            else if (username1 == "")
            {
                MessageBox.Show("新用户名不能为空");
                return false;
            }
            else if (username2 == "")
            {
                MessageBox.Show("重复新用户名不能为空");
                return false;
            }
            else
            {
                if (username1 != username2)
                {
                    MessageBox.Show("两次输入的用户名不同");
                    return false;
                }
                else
                {
                    if (username == username1)
                    {
                        MessageBox.Show("新密码不能与原始密码相同");
                        return false;
                    }
                    else
                    {
                        string sql = "select * from [User] where UserName =";
                        sql += "'" + username + "'";

                        DataTable dt = SQLServer.ExecuteQuery(sql);
                        if (dt.Rows.Count > 0)
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("原始用户名输入错误");
                            return false;
                        }
                    }
                }
            }
        }

        private void FormChangeUserName_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void 修改密码_Click(object sender, EventArgs e)
        {
            string username = txt_oldusername.Text.Trim();
            string username1 = txt_newusername.Text.Trim();
            string username2 = txt_username_repeat.Text.Trim();
            if (check_pass(username, username1, username2))
            {
                string sql = "update [User] set UserName =";
                sql += "'" + username1 + "'";
                sql += "where UserName = ";
                sql += "'" + username + "'";
                string sql1 = "update ReaderType set UserName =";
                sql1 += "'" + username1 + "'";
                sql1 += "where UserName = ";
                sql1 += "'" + username + "'";
                

                try
                {
                    SQLServer.ExecuteNonQuery(sql);
                    SQLServer.ExecuteNonQuery(sql1);
                    MessageBox.Show("修改成功！");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("修改失败！");
                    Console.WriteLine(ex);
                }
            }
        }
    }
}
