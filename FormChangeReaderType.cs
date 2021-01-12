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
    public partial class FormChangeReaderType : Form
    {
        private string username;
        public FormChangeReaderType()
        {
            InitializeComponent();
        }

        public FormChangeReaderType(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void load_data()
        {

        }

        private void FormChangeReaderType_Load(object sender, EventArgs e)
        {

        }

        private void 查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox_UserName.Text == "" && textBox_CardID.Text == "")
            {
                string sql = "select [User].UserName,[User].ID,[User].CardID,ReaderType.UserType from [User],ReaderType where ReaderType.UserName=[User].UserName";
                DataTable dataTable = SQLServer.ExecuteQuery(sql);
                dataGridView1.DataSource = dataTable;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                string sql = "select [User].UserName,[User].ID,[User].CardID,ReaderType.UserType from [User],ReaderType where ";
                if (textBox_UserName.Text != "")
                {
                    sql += "[User].UserName like ";
                    sql += "'%" + textBox_UserName.Text.Trim() + "%'";
                    sql += "and ReaderType.UserName like ";
                    sql += "'%" + textBox_UserName.Text.Trim() + "%'";
                    sql += "and ReaderType.UserName=[User].UserName ";
                    if (textBox_CardID.Text != "")
                    {
                        sql += "and [User].CardID like";
                        sql += "'%" + textBox_CardID.Text.Trim() + "%'";
                    }
                }
                else
                {
                    sql += "[User].CardID like";
                    sql += "'%" + textBox_CardID.Text.Trim() + "%'";
                    sql += "and ReaderType.UserName=[User].UserName ";
                }
                DataTable dataTable = SQLServer.ExecuteQuery(sql);
                if (dataTable.Rows.Count == 0)
                    MessageBox.Show("没有符合条件的读者");
                dataGridView1.DataSource = dataTable;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void textBox_UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows[0].Cells["UserType"].Value.ToString() != "管理员")
                {
                    MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                    DialogResult dr = MessageBox.Show("确定要将该用户设为管理员吗?", "确定", messButton);
                    if (dr == DialogResult.OK)
                    {
                        string thisusername = dataGridView1.SelectedRows[0].Cells["UserName"].Value.ToString();
                        string sql = "update ReaderType set UserType ='管理员'";
                        sql += "where UserName = ";
                        sql += "'" + thisusername + "'";
                        SQLServer.ExecuteNonQuery(sql);
                        MessageBox.Show("设置成功！");
                    }
                }
                else
                {
                    MessageBox.Show("该用户已经是管理员", "提示");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows[0].Cells["UserType"].Value.ToString() != "读者" && dataGridView1.SelectedRows[0].Cells["UserName"].Value.ToString() != "admin" && dataGridView1.SelectedRows[0].Cells["UserName"].Value.ToString() != username)
                {
                    MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                    DialogResult dr = MessageBox.Show("确定要移除该管理员权限吗?", "确定", messButton);
                    if (dr == DialogResult.OK)
                    {
                        string thisusername = dataGridView1.SelectedRows[0].Cells["UserName"].Value.ToString();
                        string sql = "update ReaderType set UserType ='读者'";
                        sql += "where UserName = ";
                        sql += "'" + thisusername + "'";
                        SQLServer.ExecuteNonQuery(sql);
                        MessageBox.Show("移除成功！");
                    }
                }
                else if (dataGridView1.SelectedRows[0].Cells["UserType"].Value.ToString() != "读者" && dataGridView1.SelectedRows[0].Cells["UserName"].Value.ToString() == username&&username!="admin")
                {
                    MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                    DialogResult dr = MessageBox.Show("确定要移除您的管理员权限吗?", "确定", messButton);
                    if (dr == DialogResult.OK)
                    {
                        string thisusername = dataGridView1.SelectedRows[0].Cells["UserName"].Value.ToString();
                        string sql = "update ReaderType set UserType ='读者'";
                        sql += "where UserName = ";
                        sql += "'" + thisusername + "'";
                        SQLServer.ExecuteNonQuery(sql);
                        MessageBox.Show("移除成功！");
                        this.Close();
                        
                    }
                    
                }
                else if (dataGridView1.SelectedRows[0].Cells["UserName"].Value.ToString() == "admin")
                {
                    MessageBox.Show("该用户管理员权限不可移除", "提示");
                }
                else
                {
                    MessageBox.Show("该用户已经是读者", "提示");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
