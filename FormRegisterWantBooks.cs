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
    public partial class FormRegisterWantBooks : Form
    {
        private string username;
        public FormRegisterWantBooks(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void 添加书目_Click(object sender, EventArgs e)
        {
            string bookname = txt_bookname.Text.Trim();
            string press = txt_press.Text.Trim();
            if (bookname == "" || press == "")
            {
                MessageBox.Show("请填入完整信息");
            }
            else if (check_book_exist(bookname))
            {

            }
            else
            {
                string sql = "insert into bookUserWanted1(username,bookname,press) values(";
                sql += "'" + username + "',";
                sql += "'" + bookname + "',";
                sql += "'" + press + "')";
                try
                {
                    SQLServer.ExecuteNonQuery(sql);
                    MessageBox.Show("登记成功！");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("登记失败!");
                    Console.WriteLine(ex);
                }
            }
        }
        private bool check_book_exist(string bookname)
        {
            string sql = "select * from Book where BookName =";
            sql += "'" + bookname + "'";
            DataTable dt = SQLServer.ExecuteQuery(sql);
            string sql1 = "select * from bookUserWanted1 where bookname =";
            sql1 += "'" + bookname + "'";
            DataTable dt1 = SQLServer.ExecuteQuery(sql1);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("该书在图书库中已存在");
                return true;
            }
            else if (dt1.Rows.Count > 0)
            {
                MessageBox.Show("该书已经被登记过");
                return true;
            }
            else
                return false;
        }

        private void FormRegisterWantBooks_Load(object sender, EventArgs e)
        {

        }
    }
}
