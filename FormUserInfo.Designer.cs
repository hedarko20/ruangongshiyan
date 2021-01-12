
namespace LibraryManagement
{
    partial class FormUserInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_useraddress = new System.Windows.Forms.TextBox();
            this.txt_userworkplace = new System.Windows.Forms.TextBox();
            this.确认绑定 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxsex = new System.Windows.Forms.ComboBox();
            this.comboBoxyear = new System.Windows.Forms.ComboBox();
            this.comboBoxmonth = new System.Windows.Forms.ComboBox();
            this.comboBoxday = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_useraddress
            // 
            this.txt_useraddress.Location = new System.Drawing.Point(409, 139);
            this.txt_useraddress.Name = "txt_useraddress";
            this.txt_useraddress.Size = new System.Drawing.Size(100, 25);
            this.txt_useraddress.TabIndex = 14;
            // 
            // txt_userworkplace
            // 
            this.txt_userworkplace.Location = new System.Drawing.Point(409, 81);
            this.txt_userworkplace.Name = "txt_userworkplace";
            this.txt_userworkplace.Size = new System.Drawing.Size(100, 25);
            this.txt_userworkplace.TabIndex = 13;
            // 
            // 确认绑定
            // 
            this.确认绑定.Location = new System.Drawing.Point(353, 345);
            this.确认绑定.Name = "确认绑定";
            this.确认绑定.Size = new System.Drawing.Size(75, 32);
            this.确认绑定.TabIndex = 12;
            this.确认绑定.Text = "绑定";
            this.确认绑定.UseVisualStyleBackColor = true;
            this.确认绑定.Click += new System.EventHandler(this.确认绑定_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "居住地址";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "工作地址";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "性别";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "出生日期";
            // 
            // comboBoxsex
            // 
            this.comboBoxsex.FormattingEnabled = true;
            this.comboBoxsex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBoxsex.Location = new System.Drawing.Point(409, 202);
            this.comboBoxsex.Name = "comboBoxsex";
            this.comboBoxsex.Size = new System.Drawing.Size(100, 23);
            this.comboBoxsex.TabIndex = 19;
            // 
            // comboBoxyear
            // 
            this.comboBoxyear.FormattingEnabled = true;
            this.comboBoxyear.Items.AddRange(new object[] {
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970",
            "1969",
            "1968",
            "1967",
            "1966",
            "1965",
            "1964",
            "1963",
            "1962",
            "1961",
            "1960",
            "1959",
            "1958"});
            this.comboBoxyear.Location = new System.Drawing.Point(409, 257);
            this.comboBoxyear.Name = "comboBoxyear";
            this.comboBoxyear.Size = new System.Drawing.Size(68, 23);
            this.comboBoxyear.TabIndex = 20;
            // 
            // comboBoxmonth
            // 
            this.comboBoxmonth.FormattingEnabled = true;
            this.comboBoxmonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxmonth.Location = new System.Drawing.Point(514, 257);
            this.comboBoxmonth.Name = "comboBoxmonth";
            this.comboBoxmonth.Size = new System.Drawing.Size(68, 23);
            this.comboBoxmonth.TabIndex = 21;
            this.comboBoxmonth.SelectedIndexChanged += new System.EventHandler(this.comboBoxmonth_SelectedIndexChanged);
            // 
            // comboBoxday
            // 
            this.comboBoxday.FormattingEnabled = true;
            this.comboBoxday.Location = new System.Drawing.Point(616, 257);
            this.comboBoxday.Name = "comboBoxday";
            this.comboBoxday.Size = new System.Drawing.Size(68, 23);
            this.comboBoxday.TabIndex = 22;
            this.comboBoxday.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "年";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(588, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "月";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(690, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "日";
            // 
            // FormUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxday);
            this.Controls.Add(this.comboBoxmonth);
            this.Controls.Add(this.comboBoxyear);
            this.Controls.Add(this.comboBoxsex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_useraddress);
            this.Controls.Add(this.txt_userworkplace);
            this.Controls.Add(this.确认绑定);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUserInfo";
            this.Text = "完善个人信息";
            this.Load += new System.EventHandler(this.FormUserInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_useraddress;
        private System.Windows.Forms.TextBox txt_userworkplace;
        private System.Windows.Forms.Button 确认绑定;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxsex;
        private System.Windows.Forms.ComboBox comboBoxyear;
        private System.Windows.Forms.ComboBox comboBoxmonth;
        private System.Windows.Forms.ComboBox comboBoxday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}