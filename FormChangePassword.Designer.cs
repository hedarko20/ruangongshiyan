
namespace LibraryManagement
{
    partial class FormChangePassword
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
            this.修改密码 = new System.Windows.Forms.Button();
            this.txt_password_repeat = new System.Windows.Forms.TextBox();
            this.txt_newpassword = new System.Windows.Forms.TextBox();
            this.txt_oldpassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 修改密码
            // 
            this.修改密码.AutoSize = true;
            this.修改密码.Location = new System.Drawing.Point(349, 323);
            this.修改密码.Name = "修改密码";
            this.修改密码.Size = new System.Drawing.Size(99, 31);
            this.修改密码.TabIndex = 13;
            this.修改密码.Text = "确认修改";
            this.修改密码.UseVisualStyleBackColor = true;
            this.修改密码.Click += new System.EventHandler(this.修改密码_Click_1);
            // 
            // txt_password_repeat
            // 
            this.txt_password_repeat.Location = new System.Drawing.Point(407, 219);
            this.txt_password_repeat.Name = "txt_password_repeat";
            this.txt_password_repeat.PasswordChar = '*';
            this.txt_password_repeat.Size = new System.Drawing.Size(100, 25);
            this.txt_password_repeat.TabIndex = 12;
            // 
            // txt_newpassword
            // 
            this.txt_newpassword.Location = new System.Drawing.Point(407, 157);
            this.txt_newpassword.Name = "txt_newpassword";
            this.txt_newpassword.PasswordChar = '*';
            this.txt_newpassword.Size = new System.Drawing.Size(100, 25);
            this.txt_newpassword.TabIndex = 11;
            // 
            // txt_oldpassword
            // 
            this.txt_oldpassword.Location = new System.Drawing.Point(407, 97);
            this.txt_oldpassword.Name = "txt_oldpassword";
            this.txt_oldpassword.PasswordChar = '*';
            this.txt_oldpassword.Size = new System.Drawing.Size(100, 25);
            this.txt_oldpassword.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "重复密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "新密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "原密码";
            // 
            // FormChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.修改密码);
            this.Controls.Add(this.txt_password_repeat);
            this.Controls.Add(this.txt_newpassword);
            this.Controls.Add(this.txt_oldpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormChangePassword";
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.FormChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 修改密码;
        private System.Windows.Forms.TextBox txt_password_repeat;
        private System.Windows.Forms.TextBox txt_newpassword;
        private System.Windows.Forms.TextBox txt_oldpassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}