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
    public partial class FormUserManagement : Form
    {
        private string username;
        public FormUserManagement()
        {
            InitializeComponent();
        }

        public FormUserManagement(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void 查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminAddUser formAdminAddUser = new FormAdminAddUser();
            Visible = false;
            formAdminAddUser.ShowDialog();
            Visible = false;

        }

        private void 查询ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string sql = "select [User].UserName,[User].ID,[User].CardID,ReaderType.UserType from [User],ReaderType where ReaderType.UserName=[User].UserName and ReaderType.UserType='读者'";
            DataTable dataTable = SQLServer.ExecuteQuery(sql);
            dataGridView1.DataSource = dataTable;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 重置密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                DialogResult dr = MessageBox.Show("确定要重置该用户的密码吗?", "确定", messButton);
                if (dr == DialogResult.OK)
                {
                    string thisusername = dataGridView1.SelectedRows[0].Cells["UserName"].Value.ToString();
                    string sql = "update [User] set Code ='a123456'";
                    sql += "where UserName = ";
                    sql += "'" + thisusername + "'";
                    SQLServer.ExecuteNonQuery(sql);
                    MessageBox.Show("重置成功！");
                }
            }
        }

        private void 修改用户名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChangeUserName formChangeUserName = new FormChangeUserName(username);
            Visible = false;
            formChangeUserName.ShowDialog();
            Visible = true;
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                DialogResult dr = MessageBox.Show("确定要删除该用户吗?", "确定", messButton);
                if (dr == DialogResult.OK)
                {
                    string thisusername = dataGridView1.SelectedRows[0].Cells["UserName"].Value.ToString();
                    string sql = "delete from [User] where UserName=";
                    sql += "'" + thisusername + "'";
                    string sql2 = "delete from ReaderType where UserName=";
                    sql2 += "'" + thisusername + "'";
                    SQLServer.ExecuteNonQuery(sql);
                    SQLServer.ExecuteNonQuery(sql2);
                    MessageBox.Show("删除成功！");
                }
            }
        }

        private void FormUserManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
