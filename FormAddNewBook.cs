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
    public partial class FormAddNewBook : Form
    {
        public FormAddNewBook()
        {
            InitializeComponent();
        }
        
        private bool check_pass(string bookid)
        {
            string sql = "select * from Book where BookNum =";
            sql += "'" + bookid + "'";

            DataTable dt = SQLServer.ExecuteQuery(sql);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void 添加新书_Click(object sender, EventArgs e)
        {
            string bookid = txt_bookid.Text.Trim();
            string bookname = txt_bookname.Text.Trim();
            string pressname = txt_press.Text.Trim();
            string bookid1 = txt_classification.Text.Trim();
            string isbn = txt_number.Text.Trim();
            if (bookid == "" || bookname == "" || pressname == "" || bookid1 == ""||isbn=="")
            {
                MessageBox.Show("请填入所有的信息");
            }
            else
            {
                if (!check_pass(bookid))
                {
                    string sql = "insert into Book (BookNum,BookName,BookAuthor,BookID,ISBN)values(";
                    sql += "'" + bookid + "',";
                    sql += "'" + bookname + "',";
                    sql += "'" + pressname + "',";
                    sql += "'" + bookid1 + "',";
                    sql += "'" + isbn + "')";
                    try
                    {
                        SQLServer.ExecuteNonQuery(sql);
                        MessageBox.Show("增书成功！");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("增书失败！");
                        Console.WriteLine(ex);
                    }
                }
                else
                {
                    MessageBox.Show("该编号已经被占用");
                }
            }
        }

        private void FormAddNewBook_Load(object sender, EventArgs e)
        {

        }
    }
}
