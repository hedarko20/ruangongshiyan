
namespace LibraryManagement
{
    partial class 流通查询
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
            this.BookID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.BookNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BookName = new System.Windows.Forms.TextBox();
            this.BookAuthor = new System.Windows.Forms.TextBox();
            this.BookPress = new System.Windows.Forms.TextBox();
            this.ISBN = new System.Windows.Forms.TextBox();
            this.Edition = new System.Windows.Forms.TextBox();
            this.BookState = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BookID
            // 
            this.BookID.Location = new System.Drawing.Point(93, 46);
            this.BookID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BookID.Name = "BookID";
            this.BookID.Size = new System.Drawing.Size(275, 25);
            this.BookID.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.BookNum);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BookName);
            this.panel1.Controls.Add(this.BookAuthor);
            this.panel1.Controls.Add(this.BookPress);
            this.panel1.Controls.Add(this.ISBN);
            this.panel1.Controls.Add(this.Edition);
            this.panel1.Controls.Add(this.BookState);
            this.panel1.Controls.Add(this.BookID);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(60, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1297, 281);
            this.panel1.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(852, 220);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "书目号";
            // 
            // BookNum
            // 
            this.BookNum.Location = new System.Drawing.Point(935, 216);
            this.BookNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BookNum.Name = "BookNum";
            this.BookNum.Size = new System.Drawing.Size(275, 25);
            this.BookNum.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(852, 136);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "ISBN号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(868, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "作者";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 136);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "版次";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "书籍名称";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 220);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "书籍状态";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "出版社";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "分类号";
            // 
            // BookName
            // 
            this.BookName.Location = new System.Drawing.Point(517, 46);
            this.BookName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(275, 25);
            this.BookName.TabIndex = 8;
            // 
            // BookAuthor
            // 
            this.BookAuthor.Location = new System.Drawing.Point(935, 46);
            this.BookAuthor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BookAuthor.Name = "BookAuthor";
            this.BookAuthor.Size = new System.Drawing.Size(275, 25);
            this.BookAuthor.TabIndex = 9;
            // 
            // BookPress
            // 
            this.BookPress.Location = new System.Drawing.Point(93, 132);
            this.BookPress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BookPress.Name = "BookPress";
            this.BookPress.Size = new System.Drawing.Size(275, 25);
            this.BookPress.TabIndex = 6;
            // 
            // ISBN
            // 
            this.ISBN.Location = new System.Drawing.Point(935, 132);
            this.ISBN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(275, 25);
            this.ISBN.TabIndex = 7;
            // 
            // Edition
            // 
            this.Edition.Location = new System.Drawing.Point(517, 132);
            this.Edition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Edition.Name = "Edition";
            this.Edition.Size = new System.Drawing.Size(275, 25);
            this.Edition.TabIndex = 4;
            // 
            // BookState
            // 
            this.BookState.Location = new System.Drawing.Point(93, 216);
            this.BookState.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BookState.Name = "BookState";
            this.BookState.Size = new System.Drawing.Size(275, 25);
            this.BookState.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(60, 354);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1297, 285);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1379, 159);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 流通查询
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1495, 689);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "流通查询";
            this.Text = "流通查询";
            this.Load += new System.EventHandler(this.流通查询_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox BookID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox BookName;
        private System.Windows.Forms.TextBox BookAuthor;
        private System.Windows.Forms.TextBox BookPress;
        private System.Windows.Forms.TextBox ISBN;
        private System.Windows.Forms.TextBox Edition;
        private System.Windows.Forms.TextBox BookState;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox BookNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}