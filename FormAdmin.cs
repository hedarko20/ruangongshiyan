using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class FormAdmin : Form
    {
        private string username;
        public FormAdmin(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void 编目传送ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 关闭ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChangePassword formChangePassword1 = new FormChangePassword(username);
            Visible = false;
            formChangePassword1.ShowDialog();
            Visible = true;
        }

        private void 用户角色管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChangeReaderType formChangeReaderType = new FormChangeReaderType(username);
            Visible = false;
            formChangeReaderType.ShowDialog();
            Visible = true;
            string sql = "select UserName from ReaderType where UserName=";
            sql += "'"+username+"'";
            sql += "and UserType='管理员'";
            DataTable dataTable = SQLServer.ExecuteQuery(sql);
            if (dataTable.Rows.Count == 0)
            {
                this.Close();
            }
        }

        private void 用户权限管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUserManagement formUserManagement = new FormUserManagement(username);
            Visible = false;
            formUserManagement.ShowDialog();
            Visible = true;
        }

        private void 管理借书信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 审核用户还书ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 预约ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminBookManagement formAdminBookManagement = new FormAdminBookManagement();
            Visible = false;
            formAdminBookManagement.ShowDialog();
            Visible = true;
        }

        private void 新书通报ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "select BookName,BookAuthor,BookPress,Edition,ISBN from NBook ";
            DataTable dataTable = SQLServer.ExecuteQuery(sql);

            dataGridView1.DataSource = dataTable;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns["BookName"].HeaderText = "书名";
            dataGridView1.Columns["BookAuthor"].HeaderText = "作者";
            dataGridView1.Columns["BookPress"].HeaderText = "出版社";
            dataGridView1.Columns["Edition"].HeaderText = "版次";
            dataGridView1.Columns["ISBN"].HeaderText = "ISBN号";
            dataGridView1.Columns["BookName"].Width = 70;//设置列宽度
            dataGridView1.Columns["BookAuthor"].Width = 70;//设置列宽度
            dataGridView1.Columns["BookPress"].Width = 80;//设置列宽度
            dataGridView1.Columns["Edition"].Width = 70;//设置列宽度
            dataGridView1.Columns["ISBN"].Width = 90;//设置列宽度
        }

        private void 用户留言ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUserMessage formUserMessage = new FormUserMessage();
            Visible = false;
            formUserMessage.ShowDialog();
            Visible = true;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 验收ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new 验收信息查询();
            f.Show();
        }

        private void 采访收集ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 采访信息筛选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new 采访筛选();
            f.Show();
        }

        private void 采访信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new 采访收集();
            f.Show();
        }

        private void 订单管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new 订单管理();
            f.Show();
        }

        private void 退货信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new 退货信息查询();
            f.Show();
        }

        private void 推荐书籍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new 推荐图书();
            f.Show();
        }

        private void 编目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new 编目();
            f.Show();
        }

        private void 直接编目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new 人工编目();
            f.Show();
        }

        private void 移送ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new 移送();
            f.Show();
        }

        private void 书籍破损登记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new 书籍破损登记();
            f.Show();
        }

        private void 注销破损管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            注销报损管理 f = new 注销报损管理();
            f.Show();
        }

        private void 流通数目查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            流通查询 f = new 流通查询();
            f.Show();
        }

        private void 借阅书目查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            借阅信息查询 f = new 借阅信息查询();
            f.Show();
        }

        private void 借阅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            借阅 f = new 借阅();
            f.Show();
        }

        private void 归还ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            归还 f = new 归还();
            f.Show();
        }

        private void 图书流通信息表备份ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            图书流通信息表备份还原 f = new 图书流通信息表备份还原();
            f.Show();
        }

        private void 借阅信息表备份ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            借阅信息表备份 f = new 借阅信息表备份();
            f.Show();
        }

        private void 用户信息表备份ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            用户信息表备份 f = new 用户信息表备份();
            f.Show();
        }

        private void 书商字典维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            书商字典维护 f = new 书商字典维护();
            f.Show();
        }

        private void 出版社字典维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            出版社字典维护 f = new 出版社字典维护();
            f.Show();
        }

        private void 收藏单位维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            收藏单位维护 f = new 收藏单位维护();
            f.Show();
        }

        private void 印刷厂字典维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            印刷厂字典维护 f = new 印刷厂字典维护();
            f.Show();
        }
    }
}
