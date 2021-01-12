
namespace LibraryManagement
{
    partial class FormUserMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.账号管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个人信息绑定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.完善个人信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登记想要的书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借阅ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.已借书目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新书通报ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.留言ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.留言表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_press = new System.Windows.Forms.TextBox();
            this.txt_bookname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.推荐图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始ToolStripMenuItem,
            this.账号管理ToolStripMenuItem,
            this.查询ToolStripMenuItem,
            this.登记ToolStripMenuItem,
            this.借阅ToolStripMenuItem,
            this.新书通报ToolStripMenuItem,
            this.留言ToolStripMenuItem,
            this.留言表ToolStripMenuItem,
            this.推荐图书ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(900, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 开始ToolStripMenuItem
            // 
            this.开始ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改密码ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.开始ToolStripMenuItem.Name = "开始ToolStripMenuItem";
            this.开始ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.开始ToolStripMenuItem.Text = "开始";
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 账号管理ToolStripMenuItem
            // 
            this.账号管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.个人信息绑定ToolStripMenuItem,
            this.完善个人信息ToolStripMenuItem});
            this.账号管理ToolStripMenuItem.Name = "账号管理ToolStripMenuItem";
            this.账号管理ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.账号管理ToolStripMenuItem.Text = "账号管理";
            // 
            // 个人信息绑定ToolStripMenuItem
            // 
            this.个人信息绑定ToolStripMenuItem.Name = "个人信息绑定ToolStripMenuItem";
            this.个人信息绑定ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.个人信息绑定ToolStripMenuItem.Text = "绑定个人信息";
            this.个人信息绑定ToolStripMenuItem.Click += new System.EventHandler(this.绑定学号ToolStripMenuItem_Click);
            // 
            // 完善个人信息ToolStripMenuItem
            // 
            this.完善个人信息ToolStripMenuItem.Name = "完善个人信息ToolStripMenuItem";
            this.完善个人信息ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.完善个人信息ToolStripMenuItem.Text = "修改个人信息";
            this.完善个人信息ToolStripMenuItem.Click += new System.EventHandler(this.完善个人信息ToolStripMenuItem_Click);
            // 
            // 查询ToolStripMenuItem
            // 
            this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            this.查询ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.查询ToolStripMenuItem.Text = "查询";
            this.查询ToolStripMenuItem.Click += new System.EventHandler(this.查询ToolStripMenuItem_Click);
            // 
            // 登记ToolStripMenuItem
            // 
            this.登记ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.登记想要的书ToolStripMenuItem});
            this.登记ToolStripMenuItem.Name = "登记ToolStripMenuItem";
            this.登记ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.登记ToolStripMenuItem.Text = "登记";
            // 
            // 登记想要的书ToolStripMenuItem
            // 
            this.登记想要的书ToolStripMenuItem.Name = "登记想要的书ToolStripMenuItem";
            this.登记想要的书ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.登记想要的书ToolStripMenuItem.Text = "登记想要的书";
            this.登记想要的书ToolStripMenuItem.Click += new System.EventHandler(this.登记想要的书ToolStripMenuItem_Click);
            // 
            // 借阅ToolStripMenuItem
            // 
            this.借阅ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.借书ToolStripMenuItem,
            this.已借书目ToolStripMenuItem});
            this.借阅ToolStripMenuItem.Name = "借阅ToolStripMenuItem";
            this.借阅ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.借阅ToolStripMenuItem.Text = "预约";
            this.借阅ToolStripMenuItem.Click += new System.EventHandler(this.借阅ToolStripMenuItem_Click);
            // 
            // 借书ToolStripMenuItem
            // 
            this.借书ToolStripMenuItem.Name = "借书ToolStripMenuItem";
            this.借书ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.借书ToolStripMenuItem.Text = "预约图书";
            this.借书ToolStripMenuItem.Click += new System.EventHandler(this.借书ToolStripMenuItem_Click);
            // 
            // 已借书目ToolStripMenuItem
            // 
            this.已借书目ToolStripMenuItem.Name = "已借书目ToolStripMenuItem";
            this.已借书目ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.已借书目ToolStripMenuItem.Text = "已预约书目";
            this.已借书目ToolStripMenuItem.Click += new System.EventHandler(this.已借书目ToolStripMenuItem_Click);
            // 
            // 新书通报ToolStripMenuItem
            // 
            this.新书通报ToolStripMenuItem.Name = "新书通报ToolStripMenuItem";
            this.新书通报ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.新书通报ToolStripMenuItem.Text = "新书通报";
            this.新书通报ToolStripMenuItem.Click += new System.EventHandler(this.新书通报ToolStripMenuItem_Click);
            // 
            // 留言ToolStripMenuItem
            // 
            this.留言ToolStripMenuItem.Name = "留言ToolStripMenuItem";
            this.留言ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.留言ToolStripMenuItem.Text = "留言";
            this.留言ToolStripMenuItem.Click += new System.EventHandler(this.留言ToolStripMenuItem_Click);
            // 
            // 留言表ToolStripMenuItem
            // 
            this.留言表ToolStripMenuItem.Name = "留言表ToolStripMenuItem";
            this.留言表ToolStripMenuItem.Size = new System.Drawing.Size(80, 28);
            this.留言表ToolStripMenuItem.Text = "留言表";
            this.留言表ToolStripMenuItem.Click += new System.EventHandler(this.留言表ToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 161);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(875, 379);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txt_press
            // 
            this.txt_press.Location = new System.Drawing.Point(407, 113);
            this.txt_press.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_press.Name = "txt_press";
            this.txt_press.Size = new System.Drawing.Size(112, 28);
            this.txt_press.TabIndex = 13;
            // 
            // txt_bookname
            // 
            this.txt_bookname.Location = new System.Drawing.Point(407, 59);
            this.txt_bookname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_bookname.Name = "txt_bookname";
            this.txt_bookname.Size = new System.Drawing.Size(112, 28);
            this.txt_bookname.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "作者";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "书名";
            // 
            // 推荐图书ToolStripMenuItem
            // 
            this.推荐图书ToolStripMenuItem.Name = "推荐图书ToolStripMenuItem";
            this.推荐图书ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.推荐图书ToolStripMenuItem.Text = "推荐图书";
            this.推荐图书ToolStripMenuItem.Click += new System.EventHandler(this.推荐图书ToolStripMenuItem_Click);
            // 
            // FormUserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_press);
            this.Controls.Add(this.txt_bookname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormUserMain";
            this.Text = "用户主界面";
            this.Load += new System.EventHandler(this.FormUserMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 开始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 账号管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个人信息绑定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 完善个人信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_press;
        private System.Windows.Forms.TextBox txt_bookname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 登记ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登记想要的书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借阅ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 已借书目ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新书通报ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 留言ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 留言表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 推荐图书ToolStripMenuItem;
    }
}