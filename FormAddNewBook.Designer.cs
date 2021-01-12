
namespace LibraryManagement
{
    partial class FormAddNewBook
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
            this.txt_classification = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.添加新书 = new System.Windows.Forms.Button();
            this.txt_press = new System.Windows.Forms.TextBox();
            this.txt_bookname = new System.Windows.Forms.TextBox();
            this.txt_bookid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_classification
            // 
            this.txt_classification.Location = new System.Drawing.Point(415, 241);
            this.txt_classification.Name = "txt_classification";
            this.txt_classification.Size = new System.Drawing.Size(100, 25);
            this.txt_classification.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "分类号";
            // 
            // 添加新书
            // 
            this.添加新书.AutoSize = true;
            this.添加新书.Location = new System.Drawing.Point(349, 362);
            this.添加新书.Name = "添加新书";
            this.添加新书.Size = new System.Drawing.Size(99, 30);
            this.添加新书.TabIndex = 15;
            this.添加新书.Text = "添加书目";
            this.添加新书.UseVisualStyleBackColor = true;
            this.添加新书.Click += new System.EventHandler(this.添加新书_Click);
            // 
            // txt_press
            // 
            this.txt_press.Location = new System.Drawing.Point(415, 185);
            this.txt_press.Name = "txt_press";
            this.txt_press.Size = new System.Drawing.Size(100, 25);
            this.txt_press.TabIndex = 14;
            // 
            // txt_bookname
            // 
            this.txt_bookname.Location = new System.Drawing.Point(415, 136);
            this.txt_bookname.Name = "txt_bookname";
            this.txt_bookname.Size = new System.Drawing.Size(100, 25);
            this.txt_bookname.TabIndex = 13;
            // 
            // txt_bookid
            // 
            this.txt_bookid.Location = new System.Drawing.Point(415, 80);
            this.txt_bookid.Name = "txt_bookid";
            this.txt_bookid.Size = new System.Drawing.Size(100, 25);
            this.txt_bookid.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "作者";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "书籍名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "书目号";
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(415, 292);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(100, 25);
            this.txt_number.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "ISBN号";
            // 
            // FormAddNewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_classification);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.添加新书);
            this.Controls.Add(this.txt_press);
            this.Controls.Add(this.txt_bookname);
            this.Controls.Add(this.txt_bookid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddNewBook";
            this.Text = "添加新书";
            this.Load += new System.EventHandler(this.FormAddNewBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_classification;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button 添加新书;
        private System.Windows.Forms.TextBox txt_press;
        private System.Windows.Forms.TextBox txt_bookname;
        private System.Windows.Forms.TextBox txt_bookid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.Label label5;
    }
}