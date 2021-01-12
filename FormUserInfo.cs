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
    public partial class FormUserInfo : Form
    {
        public FormUserInfo()
        {
            InitializeComponent();
        }

        private string username;
        public FormUserInfo(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FormUserInfo_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBoxmonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            string yea = this.comboBoxyear.SelectedItem.ToString();
            int year = Convert.ToInt32(yea);
            string month = this.comboBoxmonth.SelectedItem.ToString();
            switch (month)
            {
                case "1":
                case "3":
                case "5":
                case "7":
                case "8":
                case "10":
                case "12":
                    comboBoxday.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                    {
                        comboBoxday.Items.Add(i.ToString());
                    }
                    break;
                case "4":
                case "6":
                case "9":
                case "11":
                    comboBoxday.Items.Clear();
                    for (int i = 1; i <= 30; i++)
                    {
                        comboBoxday.Items.Add(i.ToString());
                    }
                    break;
                default:
                    if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                    {
                        comboBoxday.Items.Clear();
                        for (int i = 1; i <= 29; i++)
                        {
                            comboBoxday.Items.Add(i.ToString());
                        }
                    }
                    else
                    {
                        comboBoxday.Items.Clear();
                        for (int i = 1; i <= 28; i++)
                        {
                            comboBoxday.Items.Add(i.ToString());
                        }
                    }
                    break;
            }
        }

        private void 确认绑定_Click(object sender, EventArgs e)
        {
            string userworkplace = txt_userworkplace.Text.Trim();
            string useraddress = txt_useraddress.Text.Trim();
            string sex = comboBoxsex.Text.Trim();
            string year= comboBoxyear.Text.Trim();
            string month = comboBoxmonth.Text.Trim();
            string day = comboBoxday.Text.Trim();
            string sql = "update [User] set UserWorkPlace =";
            sql += "'" + userworkplace + "'";
            sql += ",UserAddress=";
            sql += "'" + useraddress + "'";
            sql += ",Sex=";
            sql += "'" + sex + "'";
            sql += ",Birthday=";
            sql += "'" + year + "."+month+"."+day+"'";
            sql += "where UserName = ";
            sql += "'" + username + "'";
            try
            {

                SQLServer.ExecuteNonQuery(sql);
                MessageBox.Show("绑定成功！");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("绑定失败！");
                Console.WriteLine(ex);
            }
        }
    }
}
