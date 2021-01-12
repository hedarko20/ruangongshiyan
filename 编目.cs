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
    public partial class 编目 : Form
    {
        public 编目()
        {
            InitializeComponent();
        }
        private DataSet ds = new DataSet();
        private SqlDataAdapter da = new SqlDataAdapter();
        private void 编目_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(); //创建连接对象
            conn.ConnectionString = "Data Source=.;Initial Catalog=softwareSY;Integrated Security=True;";   //连接字符串
            SqlCommand command = new SqlCommand("select * from AcceptList", conn);
            da.SelectCommand = command;
            da.Fill(ds, "acceptlist");
            dataGridView1.DataSource = ds.Tables["acceptlist"];
            dataGridView1.Columns["OLNum"].HeaderText = "订单号";
            dataGridView1.Columns["ALdate"].HeaderText = "验收日期";
            dataGridView1.Columns["ALName"].HeaderText = "验收人";
            dataGridView1.Columns["ALamount"].HeaderText = "数量";
            //SqlCommand command2 = new SqlCommand("select * from SendBook", conn);
            //da.SelectCommand = command2;
            //da.Fill(ds, "sendbook");
            //dataGridView2.DataSource = ds.Tables["sendbook"];
            //dataGridView2.Columns["BookNum"].HeaderText = "书目号";
            //dataGridView2.Columns["ISBN"].HeaderText = "ISBN号";
            //dataGridView2.Columns["BookID"].HeaderText = "分类号";
            //dataGridView2.Columns["BookName"].HeaderText = "书籍名称";
            //dataGridView2.Columns["BookAuthor"].HeaderText = "作者";
            //dataGridView2.Columns["BookPress"].HeaderText = "出版社";
            //dataGridView2.Columns["Edition"].HeaderText = "版本";
            //this.dataGridView2.Columns["BookNum"].ReadOnly = true;
            //this.dataGridView2.Columns["ISBN"].ReadOnly = true;
            //this.dataGridView2.Columns["Edition"].ReadOnly = true;
            //this.dataGridView2.Columns["BookName"].ReadOnly = true;
            //this.dataGridView2.Columns["BookAuthor"].ReadOnly = true;
            //this.dataGridView2.Columns["BookNum"].ReadOnly = true;
            //this.label2.Hide();
            //this.dataGridView2.Hide();
            //this.button2.Hide();
            //this.button3.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //对验收清单中的每个订单中的每一本数进行编目
            int i= 0,j=0;
            string booknum="";//书目号
            for (i=0;i<dataGridView1.Rows.Count-1;i++)
            {
                DataRow dr = ds.Tables["acceptlist"].Rows[i];
                int count = int.Parse(dr[3].ToString());

                SqlConnection conn = new SqlConnection(); //创建连接对象
                conn.ConnectionString = "Data Source=.;Initial Catalog=softwareSY;Integrated Security=True;";   //连接字符串
                conn.Open();  //建立连接
                SqlCommand com = new SqlCommand();
                com.Connection = conn;
                com.CommandText = "select * from OrderList where OLNum='" + dr[0].ToString() + "'";
                SqlDataReader reader = com.ExecuteReader();
                string isbn = "";
                string bookname = "";
                string bookauthor = "";
                string bookpress = "";
                string edition = "";
                if (reader.Read())
                { 
                    bookname = reader.GetValue(1).ToString();
                    edition = reader.GetValue(2).ToString();
                    bookauthor = reader.GetValue(3).ToString();
                    bookpress = reader.GetValue(4).ToString();
                    isbn = reader.GetValue(6).ToString();
                    
                }
                reader.Close();
                for (j = 0; j < count; j++)
                {
                    //对一个订单中的count本书依次编目。随机数产生15位书目号
                    booknum = "";
                    Random r = new Random();
                    for (int k = 0; k < 15; k++)
                    {
                        booknum += r.Next(0, 10).ToString();
                    }
                    
                    com.CommandText = "select BookNum from Book where BookNum='" + booknum + "'";
                    string t1 = (string)com.ExecuteScalar();
                    com.CommandText = "select BookNum from SendBook where BookNum='" + booknum + "'";
                    string t2= (string)com.ExecuteScalar();
                    if (t1 == null&&t2==null)
                    {
                        com.CommandText = "insert into SendBook(BookName,Edition,BookAuthor,BookPress,ISBN,BookNum)values('" + bookname + "','" + edition + "','" + bookauthor + "','" + bookpress + "','" + isbn + "','" + booknum+ "')";
                        int n = com.ExecuteNonQuery();
                        if (n < 1)
                        {
                            MessageBox.Show("编目失败");
                        }
                        else
                        {
                            
                            //ds.Tables["sendbook"].Clear();
                            //SqlCommand command2 = new SqlCommand("select * from SendBook", conn);
                            //da.SelectCommand = command2;
                            //da.Fill(ds, "sendbook");
                            //dataGridView2.DataSource = ds.Tables["sendbook"];
                            //dataGridView2.Columns["BookNum"].HeaderText = "书目号";
                            //dataGridView2.Columns["ISBN"].HeaderText = "ISBN号";
                            //dataGridView2.Columns["BookID"].HeaderText = "分类号";
                            //dataGridView2.Columns["BookName"].HeaderText = "书籍名称";
                            //dataGridView2.Columns["BookAuthor"].HeaderText = "作者";
                            //dataGridView2.Columns["BookPress"].HeaderText = "出版社";
                            //dataGridView2.Columns["Edition"].HeaderText = "版本";
                            //this.dataGridView2.Columns["BookNum"].ReadOnly = true;
                            //this.dataGridView2.Columns["ISBN"].ReadOnly = true;
                            //this.dataGridView2.Columns["Edition"].ReadOnly = true;
                            //this.dataGridView2.Columns["BookName"].ReadOnly = true;
                            //this.dataGridView2.Columns["BookAuthor"].ReadOnly = true;
                            //this.dataGridView2.Columns["BookPress"].ReadOnly = true;
                        }
                        }
                    else
                    {
                        j -= 1;
                    }
                }
                
            }
            if(i ==dataGridView1.Rows.Count - 1)
            {
                MessageBox.Show("编目成功!");


            }
           
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
    }
}
