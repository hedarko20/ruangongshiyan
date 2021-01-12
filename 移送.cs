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
    public partial class 移送 : Form
    {
        public 移送()
        {
            InitializeComponent();
        }
        private DataSet ds = new DataSet();
        private SqlDataAdapter da = new SqlDataAdapter();
        private void 移送_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(); //创建连接对象
            conn.ConnectionString = "Data Source=.;Initial Catalog=softwareSY;Integrated Security=True;";   //连接字符串
            SqlCommand command = new SqlCommand("select * from SendBook", conn);
            da.SelectCommand = command;
            da.Fill(ds, "sendbook");
            dataGridView1.DataSource = ds.Tables["sendbook"];
            dataGridView1.Columns["BookNum"].HeaderText = "书目号";
            dataGridView1.Columns["ISBN"].HeaderText = "ISBN号";
            dataGridView1.Columns["BookID"].HeaderText = "分类号";
            dataGridView1.Columns["BookName"].HeaderText = "书籍名称";
            dataGridView1.Columns["BookAuthor"].HeaderText = "作者";
            dataGridView1.Columns["BookPress"].HeaderText = "出版社";
            dataGridView1.Columns["Edition"].HeaderText = "版本";
            this.dataGridView1.Columns["BookNum"].ReadOnly = true;
            this.dataGridView1.Columns["ISBN"].ReadOnly = true;
            this.dataGridView1.Columns["Edition"].ReadOnly = true;
            this.dataGridView1.Columns["BookName"].ReadOnly = true;
            this.dataGridView1.Columns["BookAuthor"].ReadOnly = true;
            this.dataGridView1.Columns["BookNum"].ReadOnly = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(ds, "sendbook");
            }
            catch
            {
                MessageBox.Show("保存失败！");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            DataRow dr = ds.Tables["sendbook"].Rows[index];
            DialogResult dx = MessageBox.Show("确认删除吗", "提示", MessageBoxButtons.OKCancel);
            if (dx == DialogResult.OK)
            {
                dr.Delete();
                MessageBox.Show("删除成功");
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(ds, "sendbook");
            }
            else
            {
                MessageBox.Show("删除取消");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(); //创建连接对象
            conn.ConnectionString = "Data Source=.;Initial Catalog=softwareSY;Integrated Security=True;";   //连接字符串
            conn.Open();  //建立连接
            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            //检查分类号是否全部补充完整
            int i = 0, flag = 0;
            string bookid = "";//分类号
            for (i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                DataRow dr = ds.Tables["sendbook"].Rows[i];
                bookid = dr[0].ToString();
                if (bookid == "")
                {
                    MessageBox.Show("第" + (i + 1) + "行分类号为空，请重新填写！");
                    flag = 1;
                }
            }
            //分类号完整
            if (flag == 0)
            {
                //新书登记
                for (i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    DataRow dr = ds.Tables["sendbook"].Rows[i];

                    //判断是否为新书，以及新书表填写
                    com.CommandText = "select * from BooK where ISBN='" + dr[5].ToString() + "'";
                    string t = (string)com.ExecuteScalar();
                    if (t == null)
                    {
                        //证明是新书
                        com.CommandText = "select * from NBooK where ISBN='" + dr[5].ToString() + "'";
                        string tt = (string)com.ExecuteScalar();
                        if (tt == null)
                        {
                            //插入新纪录
                            int amount = 1;
                            string time = DateTime.Now.ToString();
                            com.CommandText = "insert into NBooK(ISBN,ALAmount,Time,BookName,BookPress,BookAuthor,Edition)values('" + dr[5].ToString() + "'," + amount + ",'" + time + "','" + dr[1].ToString() + "','" + dr[3].ToString() + "','" + dr[2].ToString() + "','" + dr[4].ToString() + "')";
                            int n1 = com.ExecuteNonQuery();
                            if (n1 < 1)
                            {
                                MessageBox.Show("新书登记失败");
                            }
                            else
                            {
                                //更新数目
                                com.CommandText = "update NBook set ALAmount=ALAmount+1 where ISBN='" + dr[5].ToString() + "'";
                                int n2 = com.ExecuteNonQuery();
                                if (n2 < 1)
                                {
                                    MessageBox.Show("新书登记失败");
                                }
                            }
                        }
                    }
                }
                int j = 0;
                for (j = 0; j < dataGridView1.Rows.Count - 1; j++)
                {
                    DataRow dr = ds.Tables["sendbook"].Rows[j];
                    string state = "在馆";
                    //插入图书流通信息表
                    com.CommandText = "insert into BooK(BookID,BookName,BookAuthor,BookPress,Edition,ISBN,BookNum,BookState)values('" + dr[0].ToString() + "','" + dr[1].ToString() + "','" + dr[2].ToString() + "','" + dr[3].ToString() + "','" + dr[4].ToString() + "','" + dr[5].ToString() + "','" + dr[6].ToString() + "','" + state + "')";
                    int n = com.ExecuteNonQuery();
                    if (n < 1)
                    {
                        MessageBox.Show("移送失败");
                    }
                    else
                    {
                        com.CommandText = "delete from SendBook where BookNum='" + dr[6].ToString() + "'";
                        int m = com.ExecuteNonQuery();
                        if (m < 1)
                        {

                            MessageBox.Show("移送失败");
                        }
                    }
                }
                if (j == dataGridView1.Rows.Count - 1)
                {
                    MessageBox.Show("移送成功");
                    ds.Tables["sendbook"].Clear();
                    da.Fill(ds, "sendbook");
                    dataGridView1.DataSource = ds.Tables["sendbook"];
                    dataGridView1.Columns["BookNum"].HeaderText = "书目号";
                    dataGridView1.Columns["ISBN"].HeaderText = "ISBN号";
                    dataGridView1.Columns["BookID"].HeaderText = "分类号";
                    dataGridView1.Columns["BookName"].HeaderText = "书籍名称";
                    dataGridView1.Columns["BookAuthor"].HeaderText = "作者";
                    dataGridView1.Columns["BookPress"].HeaderText = "出版社";
                    dataGridView1.Columns["Edition"].HeaderText = "版本";
                    this.dataGridView1.Columns["BookNum"].ReadOnly = true;
                    this.dataGridView1.Columns["ISBN"].ReadOnly = true;
                    this.dataGridView1.Columns["Edition"].ReadOnly = true;
                    this.dataGridView1.Columns["BookName"].ReadOnly = true;
                    this.dataGridView1.Columns["BookAuthor"].ReadOnly = true;
                    this.dataGridView1.Columns["BookNum"].ReadOnly = true;


                }
            }
        }
                

           
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
