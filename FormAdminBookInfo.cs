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
    public partial class FormAdminBookInfo : Form
    {
        public FormAdminBookInfo()
        {
            InitializeComponent();
        }

        private void FormAdminBookInfo_Load(object sender, EventArgs e)
        {
            load_data();
        }
        private void load_data()
        {
            string sql = "select * from Book";
            DataTable dt = SQLServer.ExecuteQuery(sql);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private FormReadBookUserWanted formReadBookUserWanted;
        private void 读者登记的书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formReadBookUserWanted == null || formReadBookUserWanted.IsDisposed)
            {
                formReadBookUserWanted = new FormReadBookUserWanted();
                formReadBookUserWanted.Show();
            }
            else
            {
                formReadBookUserWanted.WindowState = FormWindowState.Normal;
                formReadBookUserWanted.Activate();
            }
        }

        private void 增加书目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddNewBook formAddNewBook = new FormAddNewBook();
            Visible = false;
            formAddNewBook.ShowDialog();
            Visible = true;
            load_data();
        }

        private void 删除书目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                DialogResult dr = MessageBox.Show("确定要删除吗?", "确定删除", messButton);
                if (dr == DialogResult.OK)
                {
                    string sql2 = "delete from Book where BookNum =";
                    sql2 += "'" + dataGridView1.SelectedRows[0].Cells["BookNum"].Value.ToString() + "'";

                    try
                    {
                        SQLServer.ExecuteNonQuery(sql2);
                        MessageBox.Show("删除成功！");
                        load_data();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("删除失败！");
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

        private void FormAdminBookInfo_Load_1(object sender, EventArgs e)
        {
            string sql = "select * from Book";
            DataTable dt = SQLServer.ExecuteQuery(sql);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
