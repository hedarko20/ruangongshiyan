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
    public partial class FormUserMain : Form
    {
        private string username;
        public FormUserMain(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void 绑定学号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (check_is_binded(username))
            {
                MessageBox.Show("您已经绑定过。","提示");
            }
            else
            {
                FormUserBindStudent formUserBindStudent = new FormUserBindStudent(username);
                Visible = false;
                formUserBindStudent.ShowDialog();
                Visible = true;
            }
        }

        /// <summary>
        /// 检测是否已绑定个人信息
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        private bool check_is_binded(string username)
        {
            string sql = "select * from [User] where UserName =";
            sql += "'" + username + "'";
            sql += "and CardID =''";
            sql += "and ID=''";
            DataTable dt = SQLServer.ExecuteQuery(sql);
            if (dt.Rows.Count > 0)
                return false;
            else
                return true;
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChangePassword formChangePassword = new FormChangePassword(username);
            Visible = false;
            formChangePassword.ShowDialog();
            Visible = true;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormUserMain_Load(object sender, EventArgs e)
        {
            string sql = "select BookNum,BookName,BookAuthor,BookPress,ISBN from Book ";
            DataTable dataTable = SQLServer.ExecuteQuery(sql);
           
            dataGridView1.DataSource = dataTable;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns["BookNum"].HeaderText = "书目号";
            dataGridView1.Columns["BookName"].HeaderText = "书名";
            dataGridView1.Columns["BookAuthor"].HeaderText = "作者";
            dataGridView1.Columns["BookPress"].HeaderText = "出版社";
            dataGridView1.Columns["ISBN"].HeaderText = "ISBN号";
            // dataGridView1.Columns[0].Width = 80;//设置列宽度
            dataGridView1.Columns["BookNum"].Width = 40;//设置列宽度
            dataGridView1.Columns["BookName"].Width = 40;//设置列宽度
            dataGridView1.Columns["BookAuthor"].Width = 40;//设置列宽度
            dataGridView1.Columns["BookPress"].Width = 40;//设置列宽度
            dataGridView1.Columns["ISBN"].Width = 40;//设置列宽度
            

        }

        private void 完善个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUserInfo formUserInfo = new FormUserInfo(username);
            Visible = false;
            formUserInfo.ShowDialog();
            Visible = true;
        }

        private void 查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            txt_bookname.Visible = true;
            txt_press.Visible = true;
            借阅ToolStripMenuItem.Visible = true;
            if (txt_bookname.Text == "" && txt_press.Text == "")
            {
                
                string sql = "select BookNum,BookName,BookAuthor,BookPress,ISBN from Book  ";
                DataTable dataTable = SQLServer.ExecuteQuery(sql);
                dataGridView1.DataSource = dataTable;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                string sql = "select BookNum,BookName,BookAuthor,BookPress,ISBN from Book  where ";
                if (txt_bookname.Text != "")
                {
                    sql += "BookName like ";
                    sql += "'%" + txt_bookname.Text.Trim() + "%'";
                    if (txt_press.Text != "")
                    {
                        sql += "and BookAuthor like";
                        sql += "'%" + txt_press.Text.Trim() + "%'";
                    }
                }
                else
                {
                    sql += "BookAuthor like";
                    sql += "'%" + txt_press.Text.Trim() + "%'";
                }
                DataTable dataTable = SQLServer.ExecuteQuery(sql);
                if (dataTable.Rows.Count == 0)
                    MessageBox.Show("没有符合条件的书");
                dataGridView1.DataSource = dataTable;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void 登记想要的书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!check_is_binded(username))
            {
                MessageBox.Show("您还未绑定身份，不能使用该功能！");
            }
            else
            {
                FormRegisterWantBooks formRegisterWantBooks = new FormRegisterWantBooks(username);
                Visible = false;
                formRegisterWantBooks.ShowDialog();
                Visible = true;
            }
        }

        private void load_data()
        {
            string sql = "select * from Book";
            DataTable dt = SQLServer.ExecuteQuery(sql);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private string get_user_borrowed_num(string username)
        {
            string sql5 = "select Number from [User] where UserName=";
            sql5 += "'" + username + "'";
            DataTable dt = SQLServer.ExecuteQuery(sql5);
            string number = dt.Rows[0]["Number"].ToString();
            return number;
        }

        private bool check_book_user_exist(string username, string bookid)
        {
            string sql = "select * from ordertable where UserName = ";
            sql += "'" + username + "'";
            sql += "and OrderNum = ";
            sql += "'" + bookid + "'";
            DataTable dt = SQLServer.ExecuteQuery(sql);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        private void 借书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!check_is_binded(username))
            {
                MessageBox.Show("您还未绑定身份，不能使用该功能！");
            }
            else
            {
                if (get_user_borrowed_num(username) == "5")
                {
                    MessageBox.Show("您已经借了5本书，达到上限");
                }
                else if (dataGridView1.SelectedRows.Count > 0)
                {
                    MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                    DialogResult dr = MessageBox.Show("确定要借这本书吗?", "确定", messButton);
                    if (dr == DialogResult.OK)
                    {
                        if (!check_book_user_exist(username, dataGridView1.SelectedRows[0].Cells["BookNum"].Value.ToString()))
                        {
                            string sql = "insert into ordertable(UserName,OrderNum,OrderBookName)values( ";
                            sql += "'" + username + "',";
                            sql += "'" + dataGridView1.SelectedRows[0].Cells["BookNum"].Value.ToString() + "',";
                            sql += "'" + dataGridView1.SelectedRows[0].Cells["BookName"].Value.ToString() + "')";
                            string sql2 = "update [User] set Number = Number +1 where UserName = ";
                            sql2 += "'" + username + "'";
                            try
                            {
                                SQLServer.ExecuteNonQuery(sql);
                                MessageBox.Show("借书成功！");
                                load_data();
                                SQLServer.ExecuteNonQuery(sql2);
                                FormUserBorrowedBooks formBorrowedBooks = new FormUserBorrowedBooks(username);
                                Visible = false;
                                formBorrowedBooks.ShowDialog();
                                Visible = true;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("借书失败");
                                Console.WriteLine(ex);
                            }
                        }
                        else
                        {
                            MessageBox.Show("您已经借过这本书");
                        }
                    }
                }
            }
            
        }

        private void 已借书目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!check_is_binded(username))
            {
                MessageBox.Show("您还未绑定身份，不能使用该功能！");
            }
            else
            {
                FormUserBorrowedBooks formUserBorrowedBooks = new FormUserBorrowedBooks(username);
                Visible = false;
                formUserBorrowedBooks.ShowDialog();
                Visible = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 新书通报ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "select BookName,BookAuthor,BookPress,Edition,ISBN from NBook";
            DataTable dataTable = SQLServer.ExecuteQuery(sql);

            dataGridView1.DataSource = dataTable;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            txt_bookname.Visible = false;
            txt_press.Visible = false;
            借阅ToolStripMenuItem.Visible = false;
            dataGridView1.Columns["BookName"].HeaderText = "书名";
            dataGridView1.Columns["BookAuthor"].HeaderText = "作者";
            dataGridView1.Columns["BookPress"].HeaderText = "出版社";
            dataGridView1.Columns["Edition"].HeaderText = "版次";
            dataGridView1.Columns["ISBN"].HeaderText = "ISBN号";
            // dataGridView1.Columns[0].Width = 80;//设置列宽度
            dataGridView1.Columns["BookName"].Width = 20;//设置列宽度
            dataGridView1.Columns["BookAuthor"].Width = 20;//设置列宽度
            dataGridView1.Columns["BookPress"].Width = 20;//设置列宽度
            dataGridView1.Columns["Edition"].Width = 20;//设置列宽度
            dataGridView1.Columns["ISBN"].Width = 20;//设置列宽度
        }

        private void 留言ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMessage formMessage = new FormMessage();
            Visible = false;
            formMessage.ShowDialog();
            Visible = true;
        }

        private void 留言表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUserMessage formUserMessage = new FormUserMessage("admin");
            Visible = false;
            formUserMessage.ShowDialog();
            Visible = true;
        }

        private void 借阅ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 推荐图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            推荐图书 f = new 推荐图书();
            f.Show();
        }
    }
}
