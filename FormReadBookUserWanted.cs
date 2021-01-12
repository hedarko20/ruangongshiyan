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
    public partial class FormReadBookUserWanted : Form
    {
        public FormReadBookUserWanted()
        {
            InitializeComponent();
        }
        private void FormReadBookUserWanted_Load(object sender, EventArgs e)
        {
            load_data();
        }

        private void load_data()
        {
            string sql = "select * from bookUserWanted1";
            DataTable dt = SQLServer.ExecuteQuery(sql);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void 删除条目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                DialogResult dr = MessageBox.Show("确定要删除吗?", "确定删除", messButton);
                if (dr == DialogResult.OK)
                {
                    string sql2 = "delete from bookUserWanted1 where bookname =";
                    sql2 += "'" + dataGridView1.SelectedRows[0].Cells["bookname"].Value.ToString() + "'";
                    sql2 += "and username = ";
                    sql2 += "'" + dataGridView1.SelectedRows[0].Cells["username"].Value.ToString() + "'";

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

        private void FormReadBookUserWanted_Load_1(object sender, EventArgs e)
        {
            load_data();
        }
    }
}
