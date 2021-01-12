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
    public partial class 验收 : Form
    {
        public 验收()
        {
            InitializeComponent();
        }
        private string olnum;
        private string alamount;
        private string aldate;
        private string alname;
        public 验收(string olnum1, string alamount1,string alname1)
        {
            InitializeComponent();
            olnum = olnum1;
            alamount = alamount1;
            alname = alname1;
        }
       
        private void 验收_Load(object sender, EventArgs e)
        {
            textBox1.Text = olnum;
            textBox2.Text = alamount;
            textBox3.Text = alname;
            aldate = DateTime.Now.ToString();
            textBox5.Text = aldate;
            textBox1.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox5.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

             string alamount1 = textBox2.Text.Trim();
            if (alamount == null)
            {
                MessageBox.Show("本数不应为空，请重新输入！");
            }
            else
            { 
                System.Text.RegularExpressions.Regex r = new System.Text.RegularExpressions.Regex(@"^\d+$");
                if (r.IsMatch(alamount))
                {
                    int amount1 = int.Parse(alamount1);
                    int amount = int.Parse(alamount);
                    if (amount1 <= 0)
                    {
                        MessageBox.Show("本数至少为1，请重新输入！");
                    }
                    else if(amount1>amount)
                    {
                        MessageBox.Show("验收本数不应大于订单中本数，请重新输入！");
                    }
                    else
                    {
                        SqlConnection conn = new SqlConnection(); //创建连接对象
                        conn.ConnectionString = "Data Source=.;Initial Catalog=softwareSY;Integrated Security=True;";   //连接字符串
                        conn.Open();
                        SqlCommand com = new SqlCommand();
                        com.Connection = conn;
                        com.CommandText = "select * from ReturnList where OLNum='" + olnum + "'";
                        string t = (string)com.ExecuteScalar();
                        if(t==null)
                        {
                            //退货清单中没有该订单记录，直接去验收清单！
                            com.CommandText = "select * from AcceptList where OLNum='" + olnum + "'";
                            string t1 = (string)com.ExecuteScalar();
                            if (t1 == null)
                            {
                                //验收清单中没有记录，需要插入一行新纪录
                                com.CommandText = "insert into AcceptList(OLNum,ALDate,ALName,ALamount)values('" + olnum + "','" + aldate + "','" + alname + "','" + alamount1 + "')";
                                int n = com.ExecuteNonQuery();
                                if (n < 1)
                                {
                                    MessageBox.Show("验收失败");
                                }
                                else
                                {
                                    MessageBox.Show("验收成功");
                                }
                            }
                            else
                            {
                                MessageBox.Show("该订单已经被验收过！");
                            }
                        }
                        else
                        {
                            //退货清单中有记录需要   退货清单本数+验收清单本数=订单本数
                            //读取退货清单中的本数
                            com.CommandText = "select * from ReturnList where OLNum='" + olnum + "'";
                            SqlDataReader reader = com.ExecuteReader();
                            int amount2 = 0;
                            if (reader.Read())
                            {
                                 amount2 = int.Parse(reader.GetValue(4).ToString());
                            }
                            reader.Close();
                            //判断  退货清单本数+验收清单本数=订单本数？
                            if(amount1+amount2==amount)
                            {
                                //验收成功
                                com.CommandText = "select * from AcceptList where OLNum='" + olnum + "'";
                                string t1 = (string)com.ExecuteScalar();
                                if (t1 == null)
                                {
                                    //验收清单中没有记录，需要插入一行新纪录
                                    com.CommandText = "insert into AcceptList(OLNum,ALDate,ALName,ALamount)values('" + olnum + "','" + aldate + "','" + alname + "','" + alamount1 + "')";
                                    int n = com.ExecuteNonQuery();
                                    if (n < 1)
                                    {
                                        MessageBox.Show("验收失败");
                                    }
                                    else
                                    {
                                        MessageBox.Show("验收成功");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("该订单已经被验收过！");
                                }
                            }
                            else
                            {
                                //提示错误！
                                int x = amount - amount2;
                                if(x>0)
                                {
                                    MessageBox.Show("验收本数应为"+x+" 因为该订单已退货"+amount2+"本");
                                }
                                else
                                {
                                    MessageBox.Show("该订单已全部退货" );
                                }
                                
                            }
                        }

                        conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("本数应全为数字！请重新输入！");
                }
            }

        }
    }
}
