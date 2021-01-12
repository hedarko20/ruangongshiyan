
namespace LibraryManagement
{
    partial class FormAddUser
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
            this.返回登陆 = new System.Windows.Forms.Button();
            this.注册 = new System.Windows.Forms.Button();
            this.txt_password_confirm = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 返回登陆
            // 
            this.返回登陆.AutoSize = true;
            this.返回登陆.Location = new System.Drawing.Point(347, 349);
            this.返回登陆.Name = "返回登陆";
            this.返回登陆.Size = new System.Drawing.Size(104, 32);
            this.返回登陆.TabIndex = 15;
            this.返回登陆.Text = "返回登陆";
            this.返回登陆.UseVisualStyleBackColor = true;
            this.返回登陆.Click += new System.EventHandler(this.返回登陆_Click);
            // 
            // 注册
            // 
            this.注册.AutoSize = true;
            this.注册.Location = new System.Drawing.Point(347, 281);
            this.注册.Name = "注册";
            this.注册.Size = new System.Drawing.Size(104, 34);
            this.注册.TabIndex = 14;
            this.注册.Text = "确认注册";
            this.注册.UseVisualStyleBackColor = true;
            this.注册.Click += new System.EventHandler(this.注册_Click_1);
            // 
            // txt_password_confirm
            // 
            this.txt_password_confirm.Location = new System.Drawing.Point(422, 181);
            this.txt_password_confirm.Name = "txt_password_confirm";
            this.txt_password_confirm.PasswordChar = '*';
            this.txt_password_confirm.Size = new System.Drawing.Size(100, 25);
            this.txt_password_confirm.TabIndex = 13;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(422, 124);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(100, 25);
            this.txt_password.TabIndex = 12;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(422, 70);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(100, 25);
            this.txt_username.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(278, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "确认密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(278, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(278, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "用户名";
            // 
            // FormAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.返回登陆);
            this.Controls.Add(this.注册);
            this.Controls.Add(this.txt_password_confirm);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddUser";
            this.Text = "注册用户";
            this.Load += new System.EventHandler(this.FormAddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 返回登陆;
        private System.Windows.Forms.Button 注册;
        private System.Windows.Forms.TextBox txt_password_confirm;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}