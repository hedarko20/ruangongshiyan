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
    public partial class FormAdminBookManagement : Form
    {
        public FormAdminBookManagement()
        {
            InitializeComponent();
        }

        private void FormAdminBookManagement_Load(object sender, EventArgs e)
        {
            loadData();
            还书.Visible = true;
        }

        private void 还书_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                DialogResult dr = MessageBox.Show("确定要还书吗?", "确定还书", messButton);
                if (dr == DialogResult.OK)
                {
                    string sql = "delete from bookReturning1 where UserName  =";
                    sql += "'" + dataGridView1.SelectedRows[0].Cells["UserName"].Value.ToString() + "'";
                    sql += "and BookNum =";
                    sql += "'" + dataGridView1.SelectedRows[0].Cells["BookNum"].Value.ToString() + "'";

                    string sql2 = "update [User] set Number =Number-1 where UserName=";
                    sql2 += "'" + dataGridView1.SelectedRows[0].Cells["UserName"].Value.ToString() + "'";

                    try
                    {
                        SQLServer.ExecuteNonQuery(sql);
                        MessageBox.Show("还书成功！");
                        SQLServer.ExecuteNonQuery(sql2);
                        loadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("还书失败！");
                        Console.WriteLine(ex);
                    }
                }
            }
        }

        private void 管理借书信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            还书.Visible = false;
            string sql = "select ordertable.UserName ,ordertable.OrderNum,ordertable.OrderBookName from ordertable";
            DataTable dt = SQLServer.ExecuteQuery(sql);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void 审核用户还书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadData();
            还书.Visible = true;
        }

        private void 管理图书信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            还书.Visible = false;
            FormAdminBookInfo formAdminBookInfo = new FormAdminBookInfo();
            Visible = false;
            formAdminBookInfo.ShowDialog();
            Visible = true;
            dataGridView1.DataSource = null;
        }


        private void loadData()
        {
            string sql1 = "select UserName ,BookNum from bookReturning1";
            DataTable dt1 = SQLServer.ExecuteQuery(sql1);
            dataGridView1.DataSource = dt1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
