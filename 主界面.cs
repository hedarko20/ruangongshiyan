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
    public partial class 主界面 : Form
    {
        public 主界面()
        {
            InitializeComponent();
        }
        public static string  Mainuser="aaa";
        private void Form1_Load(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(); //创建连接对象
            //conn.ConnectionString = "Data Source=.;Initial Catalog=softwareSY;Integrated Security=True;";   //连接字符串
            //conn.Open();  //建立连接
            //SqlCommand com = new SqlCommand();
            //com.Connection = conn;
            //com.CommandText = "select * from InterList";
            //SqlDataReader reader = com.ExecuteReader();
            ////用循环语句读取SQL查询获得的数据集。.
            //while (reader.Read())   //读取一条数据

            //{
            //    MessageBox.Show(reader[0].ToString()+' '+ reader[1].ToString());
            //}
            //reader.Close();
            //conn.Close();
        }

        private void 编目传送ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 采访收集ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 验收ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new 验收信息查询();
            f.Show();
        }

        private void 筛选ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void 注销报损查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new 注销报损管理();
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

        private void 注销报损ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 书籍破损登记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new 书籍破损登记();
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
