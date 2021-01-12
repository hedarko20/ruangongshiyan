
namespace LibraryManagement
{
    partial class FormChangeUserName
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
            this.txt_username_repeat = new System.Windows.Forms.TextBox();
            this.txt_newusername = new System.Windows.Forms.TextBox();
            this.txt_oldusername = new System.Windows.Forms.TextBox();
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
            this.修改密码.TabIndex = 20;
            this.修改密码.Text = "确认修改";
            this.修改密码.UseVisualStyleBackColor = true;
            this.修改密码.Click += new System.EventHandler(this.修改密码_Click);
            // 
            // txt_username_repeat
            // 
            this.txt_username_repeat.Location = new System.Drawing.Point(407, 219);
            this.txt_username_repeat.Name = "txt_username_repeat";
            this.txt_username_repeat.Size = new System.Drawing.Size(100, 25);
            this.txt_username_repeat.TabIndex = 19;
            // 
            // txt_newusername
            // 
            this.txt_newusername.Location = new System.Drawing.Point(407, 157);
            this.txt_newusername.Name = "txt_newusername";
            this.txt_newusername.Size = new System.Drawing.Size(100, 25);
            this.txt_newusername.TabIndex = 18;
            // 
            // txt_oldusername
            // 
            this.txt_oldusername.Location = new System.Drawing.Point(407, 97);
            this.txt_oldusername.Name = "txt_oldusername";
            this.txt_oldusername.Size = new System.Drawing.Size(100, 25);
            this.txt_oldusername.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "重复新用户名";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "新用户名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "原用户名";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormChangeUserName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.修改密码);
            this.Controls.Add(this.txt_username_repeat);
            this.Controls.Add(this.txt_newusername);
            this.Controls.Add(this.txt_oldusername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormChangeUserName";
            this.Text = "修改用户名";
            this.Load += new System.EventHandler(this.FormChangeUserName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 修改密码;
        private System.Windows.Forms.TextBox txt_username_repeat;
        private System.Windows.Forms.TextBox txt_newusername;
        private System.Windows.Forms.TextBox txt_oldusername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}