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
    public partial class FormAdminAddUser : Form
    {
        public FormAdminAddUser()
        {
            InitializeComponent();
        }

        private void 注册_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text.Trim();
            string identitycard = "";
            string cardid = "";
            string userworkplace = "  ";
            string sex = "  ";
            string useraddress = "  ";
            string birthday = "  ";
            string usertype = "读者";
            string password = txt_password.Text.Trim();
            string passwordConfirm = txt_password_confirm.Text.Trim();
            string number = "5";
            if (username == "" || password == "" || passwordConfirm == "")
                MessageBox.Show("请填入所有信息");
            else if (password != passwordConfirm)
            {
                MessageBox.Show("两次输入的密码不一致");
            }
            else if (CodeLevel(password) < 2)
            {

            }
            else
            {
                if (!check_user_exist(username))//检测用户名是否存在，此处为用户名不存在的条件
                {
                    string sql2 = "insert into ReaderType (UserName ,UserType)values(";
                    sql2 += "'" + username + "',";
                    sql2 += "'" + usertype + "')";

                    string sql1 = "insert into [User] (UserName,CardID,ID,UserWorkPlace,Code,UserAddress,Sex ,Birthday,Number)values(";
                    sql1 += "'" + username + "',";
                    sql1 += "'" + cardid + "',";
                    sql1 += "'" + identitycard + "',";
                    sql1 += "'" + userworkplace + "',";
                    sql1 += "'" + password + "',";
                    sql1 += "'" + useraddress + "',";
                    sql1 += "'" + sex + "',";
                    sql1 += "'" + birthday + "',";
                    sql1 += "'" + number + "')";
                    SQLServer.ExecuteNonQuery(sql1);
                    try
                    {
                        SQLServer.ExecuteNonQuery(sql2);

                        MessageBox.Show("注册成功！", "提示");
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("注册失败！", "提示");
                        Console.WriteLine(ex);
                    }
                }
            }
        }

        

        /// <summary>
        /// 判断密码安全等级
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
                foreach (char c in str)//判断密码中各字符的种类，并统计各自的数量
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
                if (inum == 0 || ilowchar == 0)//判断密码是否至少包含一位数字&字母
                {
                    MessageBox.Show("密码至少包含一位数字和一位字母");
                    level = 0;
                }
            }
            return level;
        }

        /// <summary>
        /// 检测用户名是否已存在
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        private bool check_user_exist(string username)
        {
            string sql = "select UserName , Code from [User] where UserName =";
            sql += "'" + username + "'";

            DataTable dt = SQLServer.ExecuteQuery(sql);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("用户名被占用");
                return true;
            }
            else
                return false;
        }

        private void FormAddUser_Load(object sender, EventArgs e)
        {

        }

        private void FormAdminAddUser_Load(object sender, EventArgs e)
        {

        }
    }
}
