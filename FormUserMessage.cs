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
    public partial class FormUserMessage : Form
    {
        private string username;
        public FormUserMessage(string username)
        {
            InitializeComponent();
            this.username = username;
        }
        public FormUserMessage()
        {
            InitializeComponent();
        }

        private void FormUserMessage_Load(object sender, EventArgs e)
        {
            if(username=="admin")
            {
                this.menuStrip1.Visible = false;
            }
            string sql = "select UserMessage,Reply from message ";
            DataTable dataTable = SQLServer.ExecuteQuery(sql);

            dataGridView1.DataSource = dataTable;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns["UserMessage"].HeaderText = "留言";
            dataGridView1.Columns["Reply"].HeaderText = "回复";
            
            // dataGridView1.Columns[0].Width = 80;//设置列宽度
            dataGridView1.Columns["UserMessage"].Width = 1000;//设置列宽度
            dataGridView1.Columns["Reply"].Width =250;//设置列宽度
            
        }

        private void load_data()
        {
            string sql = "select * from message";
            DataTable dt = SQLServer.ExecuteQuery(sql);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void 删除留言ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                DialogResult dr = MessageBox.Show("确定要删除吗?", "确定删除", messButton);
                if (dr == DialogResult.OK)
                {
                    string sql2 = "delete from message where UserMessage =";
                    sql2 += "'" + dataGridView1.SelectedRows[0].Cells["UserMessage"].Value.ToString() + "'";
                    

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

        private void 回复ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                FormAdminReply formAdminReply = new FormAdminReply(dataGridView1.SelectedRows[0].Cells["UserMessage"].Value.ToString());
                Visible = false;
                formAdminReply.ShowDialog();
                Visible = true;
            }
        }
    }
}
