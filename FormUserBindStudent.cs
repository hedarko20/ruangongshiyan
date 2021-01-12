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
    public partial class FormUserBindStudent : Form
    {
        public FormUserBindStudent()
        {
            InitializeComponent();
        }

        private string username;
        public FormUserBindStudent(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        /// <summary>
        /// 检查学生用户是否已存在
        /// </summary>
        /// <param name="studentno"></param>
        /// <param name="studentname"></param>
        /// <returns></returns>
        private bool checkStudentExist(string cardid, string identitycard)
        {
            string sql = "select * from [User] where CardID = ";
            sql += "'" + cardid + "'";
            sql += " and ID = ";
            sql += "'" + identitycard + "'";
            DataTable dt = SQLServer.ExecuteQuery(sql);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 检查学生信息是否绑定过其他用户
        /// </summary>
        /// <param name="studentno"></param>
        /// <returns></returns>
        private bool checkStudentsticked(string cardid)
        {
            string sql = "select * from [User] where CardID =";
            sql += "'" + cardid + "'";
            DataTable dt = SQLServer.ExecuteQuery(sql);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
                return false;
        }

        private void FormUserBindStudent_Load(object sender, EventArgs e)
        {

        }

        private void 确认绑定_Click_1(object sender, EventArgs e)
        {
            string cardid = txt_cardid.Text.Trim();
            string identitycard = txt_identitycard.Text.Trim();
            if (cardid == "" || identitycard == "")
            {
                MessageBox.Show("请填入所有信息");
            }
            else if (!checkStudentExist(cardid, identitycard))
            {
                if (!checkStudentsticked(cardid))
                {
                    string sql = "update [User] set CardID =";
                    sql += "'" + cardid + "'";
                    sql += ",ID=";
                    sql += "'" + identitycard + "'";
                    sql += "where UserName = ";
                    sql += "'" + username + "'";
                    try
                    {
                        
                        SQLServer.ExecuteNonQuery(sql);
                        MessageBox.Show("绑定成功！");
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("绑定失败！");
                        Console.WriteLine(ex);
                    }
                }
                else
                {
                    MessageBox.Show("该学生信息已经绑定过");
                }
            }
            else
            {
                MessageBox.Show("学生信息有错误");
            }
        }
    }
}
