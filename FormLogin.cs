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
    public partial class FormLogin : Form
    {
        private string username1;
        private string role;

        public FormLogin()
        {
            InitializeComponent();
        }

        public FormLogin(string username)//这个方法实现从注册返回时自动填入用户名(密码)
        {
            InitializeComponent();
            username1 = username;
            txt_username.Text = username;
        }

        /// <summary>
        /// 检查管理员的用户名，密码，以及身份
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool check_password1(string username, string password)
        {
            string sql = "select * from [User] where Code =";
            sql += "'" + password + "'";
            sql += "and UserName in(select UserName from ReaderType where Username=";
            sql += "'" + username + "'";
            sql += "and UserType='管理员')";

            DataTable dt = SQLServer.ExecuteQuery(sql);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// 检查读者的用户名，密码，以及身份
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool check_password(string username, string password)
        {
            string sql = "select * from [User] where Code =";
            sql += "'" + password + "'";
            sql += "and UserName in(select UserName from ReaderType where Username=";
            sql += "'" + username + "'";
            sql += "and UserType='读者')";

            DataTable dt = SQLServer.ExecuteQuery(sql);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
                return false;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void 注册_Click_1(object sender, EventArgs e)
        {
            FormAddUser formAddUser = new FormAddUser();
            Visible = false;
            formAddUser.ShowDialog();
            //Visible = true;
        }

        private void 登陆_Click_1(object sender, EventArgs e)
        {
            string username = txt_username.Text.Trim();
            string password = txt_password.Text.Trim();
            role = this.comboBoxrole.SelectedItem.ToString();
            if (username == "" || password == "")
            {
                MessageBox.Show("用户名或密码不能为空");
            }
            else if(role=="")
            {
                MessageBox.Show("请选择用户类型","提示");
            }
            else if (role == "管理员" && check_password1(username, password)) //检测管理员用户密码是否正确
            {
                FormAdmin formAdmin = new FormAdmin(username);
                Visible = false;
                formAdmin.ShowDialog();
                Application.Exit();
            }
            else if (role == "读者" && check_password(username, password))  //检测读者用户密码是否正确
            {
                FormUserMain formUserMain = new FormUserMain(username);
                Visible = false;
                formUserMain.ShowDialog();
                Visible = true;
                Application.Exit();
            }
            else
                MessageBox.Show("用户名或密码错误");
        }

        private void comboBoxrole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
