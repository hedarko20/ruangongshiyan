
namespace LibraryManagement
{
    partial class FormRegisterWantBooks
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
            this.添加书目 = new System.Windows.Forms.Button();
            this.txt_press = new System.Windows.Forms.TextBox();
            this.txt_bookname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 添加书目
            // 
            this.添加书目.Location = new System.Drawing.Point(352, 288);
            this.添加书目.Name = "添加书目";
            this.添加书目.Size = new System.Drawing.Size(91, 32);
            this.添加书目.TabIndex = 9;
            this.添加书目.Text = "添加";
            this.添加书目.UseVisualStyleBackColor = true;
            this.添加书目.Click += new System.EventHandler(this.添加书目_Click);
            // 
            // txt_press
            // 
            this.txt_press.Location = new System.Drawing.Point(407, 186);
            this.txt_press.Name = "txt_press";
            this.txt_press.Size = new System.Drawing.Size(100, 25);
            this.txt_press.TabIndex = 8;
            // 
            // txt_bookname
            // 
            this.txt_bookname.Location = new System.Drawing.Point(407, 131);
            this.txt_bookname.Name = "txt_bookname";
            this.txt_bookname.Size = new System.Drawing.Size(100, 25);
            this.txt_bookname.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "作者信息";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "书名";
            // 
            // FormRegisterWantBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.添加书目);
            this.Controls.Add(this.txt_press);
            this.Controls.Add(this.txt_bookname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRegisterWantBooks";
            this.Text = "登记想要的书";
            this.Load += new System.EventHandler(this.FormRegisterWantBooks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 添加书目;
        private System.Windows.Forms.TextBox txt_press;
        private System.Windows.Forms.TextBox txt_bookname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}