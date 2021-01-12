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
    public partial class FormAdminReply : Form
    {
        private string message;
        public FormAdminReply(string message)
        {
            InitializeComponent();
            this.message = message;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = message ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "update message set Reply=";
            sql += "'"+ textBox1.Text.ToString() + "'";
            sql += "where UserMessage=";
            sql+="'"+message+"'";
            DataTable dataTable = SQLServer.ExecuteQuery(sql);
            MessageBox.Show("回复成功！", "提示");
        }

        private void FormAdminReply_Load(object sender, EventArgs e)
        {
            textBox2.Text = message;
        }
    }
}
