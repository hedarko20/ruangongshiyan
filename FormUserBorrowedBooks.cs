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
    public partial class FormUserBorrowedBooks : Form
    {
        private string username;
        public FormUserBorrowedBooks(string username)
        {
            InitializeComponent();
            this.username = username;
        }


        private void load_data()
        {
            string sql = "select ordertable.UserName,ordertable.OrderNum,ordertable.OrderBookName from ordertable where  ordertable.UserName =";
            sql += "'" + username + "'";

            DataTable dt = SQLServer.ExecuteQuery(sql);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FormUserBorrowedBooks_Load(object sender, EventArgs e)
        {
            load_data();
        }

        private void 还书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                DialogResult dr = MessageBox.Show("确定要还书吗?", "确定还书", messButton);
                if (dr == DialogResult.OK)
                {
                    string sql = "delete from ordertable where UserName  =";
                    sql += "'" + username + "'";
                    sql += "and ordertable.OrderNum =";
                    sql += "'" + dataGridView1.SelectedRows[0].Cells["OrderNum"].Value.ToString() + "'";
                    string sql3 = "insert into bookReturning1 (BookNum,UserName) values(";
                    sql3 += "'" + dataGridView1.SelectedRows[0].Cells["OrderNum"].Value.ToString() + "',";
                    sql3 += "'" + username + "')";
                    try
                    {
                        SQLServer.ExecuteNonQuery(sql);
                        MessageBox.Show("还书成功等待管理员审核！");
                        SQLServer.ExecuteNonQuery(sql3);
                        load_data();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("还书失败！");
                        Console.WriteLine(ex);
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FormUserBorrowedBooks_Load_1(object sender, EventArgs e)
        {
            load_data();
        }
    }
}
