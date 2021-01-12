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
    public partial class FormChangePassword : Form
    {
        public FormChangePassword()
        {
            InitializeComponent();
        }

        private string username;
        public FormChangePassword(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        /// <summary>
        /// 检测密码是否合法
        /// </summary>
        /// <param name="password"></param>
        /// <param name="password1"></param>
        /// <param name="password2"></param>
        /// <returns></returns>
        private bool check_pass(string password, string password1, string password2)
        {
            if (password == "")
            {
                MessageBox.Show("原始密码不能为空");
                return false;
            }
            else if (password1 == "")
            {
                MessageBox.Show("新密码不能为空");
                return false;
            }
            else if (password2 == "")
            {
                MessageBox.Show("重复密码不能为空");
                return false;
            }
            else
            {
                if (password1 != password2)
                {
                    MessageBox.Show("两次输入的密码不同");
                    return false;
                }
                else
                {
                    if (password == password1)
                    {
                        MessageBox.Show("新密码不能与原始密码相同");
                        return false;
                    }
                    else
                    {
                        string sql = "select * from [User] where UserName =";
                        sql += "'" + username + "'";
                        sql += "and Code= ";
                        sql += "'" + password + "'";

                        DataTable dt = SQLServer.ExecuteQuery(sql);
                        if (dt.Rows.Count > 0)
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("原始密码输入错误");
                            return false;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 密码安全性检测
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private int CodeLevel(string str)
        {
            int level = 0;
            int ilowchar = 0;   //是否包含小写字母
            int icapchar = 0;   //是否包含大写字母
            int inum = 0;       //是否包含数字
            int iother = 0;     //是否包含特殊字符
            if (str.Count() < 6 || str.Length > 12)
            {
                level = 0;
                MessageBox.Show("密码长度应该在6-12位之间");
                return level;
            }
            else
            {
                foreach (char c in str)
                {
                    int ic = Convert.ToInt32(c);
                    if (ic >= 48 && ic <= 57)   //数字
                    {
                        inum = 1;
                    }
                    else if (ic >= 65 && ic <= 90)  //大写字母
                    {
                        icapchar = 1;
                    }
                    else if (ic >= 97 && ic <= 122)  //小写字母
                    {
                        ilowchar = 1;
                    }
                    else    //其他字符
                    {
                        iother = 1;
                    }
                }
                level = ilowchar + icapchar + inum + iother;
                if (inum == 0 || ilowchar == 0)
                {
                    MessageBox.Show("密码至少包含一位数字和一位字母");
                    level = 0;
                }
            }
            return level;
        }

        private void FormChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void 修改密码_Click_1(object sender, EventArgs e)
        {
            string password = txt_oldpassword.Text.Trim();
            string password1 = txt_newpassword.Text.Trim();
            string password2 = txt_password_repeat.Text.Trim();
            if (check_pass(password, password1, password2))
            {
                if (CodeLevel(password1) < 2)
                {

                }
                else
                {
                    string sql = "update [User] set Code =";
                    sql += "'" + password1 + "'";
                    sql += "where UserName = ";
                    sql += "'" + username + "'";
                    try
                    {
                        SQLServer.ExecuteNonQuery(sql);
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
}
