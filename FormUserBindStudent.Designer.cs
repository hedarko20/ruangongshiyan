
namespace LibraryManagement
{
    partial class FormUserBindStudent
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
            this.txt_identitycard = new System.Windows.Forms.TextBox();
            this.txt_cardid = new System.Windows.Forms.TextBox();
            this.确认绑定 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_identitycard
            // 
            this.txt_identitycard.Location = new System.Drawing.Point(409, 176);
            this.txt_identitycard.Name = "txt_identitycard";
            this.txt_identitycard.Size = new System.Drawing.Size(100, 25);
            this.txt_identitycard.TabIndex = 9;
            // 
            // txt_cardid
            // 
            this.txt_cardid.Location = new System.Drawing.Point(409, 118);
            this.txt_cardid.Name = "txt_cardid";
            this.txt_cardid.Size = new System.Drawing.Size(100, 25);
            this.txt_cardid.TabIndex = 8;
            // 
            // 确认绑定
            // 
            this.确认绑定.Location = new System.Drawing.Point(351, 300);
            this.确认绑定.Name = "确认绑定";
            this.确认绑定.Size = new System.Drawing.Size(75, 32);
            this.确认绑定.TabIndex = 7;
            this.确认绑定.Text = "绑定";
            this.确认绑定.UseVisualStyleBackColor = true;
            this.确认绑定.Click += new System.EventHandler(this.确认绑定_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "身份证号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "学号";
            // 
            // FormUserBindStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_identitycard);
            this.Controls.Add(this.txt_cardid);
            this.Controls.Add(this.确认绑定);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUserBindStudent";
            this.Text = "绑定用户";
            this.Load += new System.EventHandler(this.FormUserBindStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_identitycard;
        private System.Windows.Forms.TextBox txt_cardid;
        private System.Windows.Forms.Button 确认绑定;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}