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
    public partial class FormMessage : Form
    {
        public FormMessage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = textBox1.Text.Trim().ToString();
            string reply = " ";
            string sql = "insert into message(UserMessage,Reply) values (";
            sql+="'"+message+"',";
            sql += "'" + reply + "')";
            try
            {
                SQLServer.ExecuteNonQuery(sql);
                MessageBox.Show("留言成功！", "提示");
            }
            catch (Exception ex)
            {
                MessageBox.Show("留言失败！");
                Console.WriteLine(ex);
            }

        }

        private void FormMessage_Load(object sender, EventArgs e)
        {

        }
    }
}
