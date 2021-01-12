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
    public partial class 退货 : Form
    {
        public 退货()
        {
            InitializeComponent();
        }
        public string olnum;
        public string rlamount;
        public string rlreason;
        public string rlname;
        public string rldate;
        public 退货(string olnum1, string alamount1, string alname1)
        {
            InitializeComponent();
            olnum = olnum1;
            rlamount = alamount1;
            rlname = alname1;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            string rlamount1 = textBox2.Text.Trim();
            rlreason = "";
            rlreason=textBox6.Text.Trim();
            if (rlamount1 == null)
            {
                MessageBox.Show("本数不应为空，请重新输入！");
            }
            else if (rlreason == "")
            {
                MessageBox.Show("退货原因不应为空，请重新输入！");
            }
            else
            {
                System.Text.RegularExpressions.Regex r = new System.Text.RegularExpressions.Regex(@"^\d+$");
                if (r.IsMatch(rlamount))
                {
                    int amount1 = int.Parse(rlamount1);
                    int amount = int.Parse(rlamount);
                    if (amount1 <= 0)
                    {
                        MessageBox.Show("本数至少为1，请重新输入！");
                    }
                    else if (amount1 > amount)
                    {
                        MessageBox.Show("退货本数不应大于订单中本数！退货失败！");
                    }
                    else
                    {
                        SqlConnection conn = new SqlConnection(); //创建连接对象
                        conn.ConnectionString = "Data Source=.;Initial Catalog=softwareSY;Integrated Security=True;";   //连接字符串
                        conn.Open();
                        SqlCommand com = new SqlCommand();
                        com.Connection = conn;
                        com.CommandText = "select * from AcceptList where OLNum='" + olnum + "'";
                        string t = (string)com.ExecuteScalar();
                        if (t == null)
                        {

                            com.CommandText = "select * from ReturnList where OLNum='" + olnum + "'";
                            string t1 = (string)com.ExecuteScalar();
                            if (t1 == null)
                            {
                                //退货清单中没有记录，需要插入一行新纪录
                                com.CommandText = "insert into ReturnList(OLNum,RLDate,RLname,RLReason,RLamount)values('" + olnum + "','" + rldate + "','" + rlname + "','" + rlreason + "','" + rlamount1 + "')";
                                int n = com.ExecuteNonQuery();
                                if (n < 1)
                                {
                                    MessageBox.Show("退货失败");
                                }
                                else
                                {
                                    MessageBox.Show("退货成功");
                                }
                            }
                            else
                            {
                                MessageBox.Show("该订单已经被退货过！");
                            }
                        }
                        else
                        {
                            //该订单已经被验收过
                            //验收清单中有记录需要   退货清单本数+验收清单本数=订单本数
                            //读取验收清单中的本数
                            com.CommandText = "select * from AcceptList where OLNum='" + olnum + "'";
                            SqlDataReader reader = com.ExecuteReader();
                            int amount2 = 0;
                            if (reader.Read())
                            {
                                amount2 = int.Parse(reader.GetValue(3).ToString());
                            }
                            reader.Close();
                            //判断  退货清单本数+验收清单本数=订单本数？
                            if (amount1 + amount2 == amount)
                            {
                                //退货成功

                                com.CommandText = "select * from ReturnList where OLNum='" + olnum + "'";
                                string t1 = (string)com.ExecuteScalar();
                                if (t1 == null)
                                {
                                    //退货清单中没有记录，需要插入一行新纪录
                                    com.CommandText = "insert into ReturnList(OLNum,RLDate,RLname,RLReason,RLamount)values('" + olnum + "','" + rldate + "','" + rlname + "','" + rlreason + "','" + rlamount1 + "')";
                                    int n = com.ExecuteNonQuery();
                                    if (n < 1)
                                    {
                                        MessageBox.Show("退货失败");
                                    }
                                    else
                                    {
                                        MessageBox.Show("退货成功");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("该订单已经被退货过！");
                                }
                            }
                            else
                            {
                                //提示错误！
                                int x = amount - amount2;
                                if(x>0)
                                {
                                    MessageBox.Show("退货本数应为" + x + " 因为该订单已验收" + amount2 + "本");
                                }
                                else
                                { 
                                    MessageBox.Show("订单已全部验收");
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

        private void 退货_Load(object sender, EventArgs e)
        {
            textBox1.Text = olnum;
            textBox2.Text = rlamount;
            textBox3.Text = rlname;
            rldate = DateTime.Now.ToString();
            textBox5.Text = rldate;
            textBox1.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox5.ReadOnly = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
