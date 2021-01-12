
namespace LibraryManagement
{
    partial class FormAdminBookManagement
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
            this.图书管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理图书信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理借书信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.审核用户还书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.还书 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图书管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 图书管理ToolStripMenuItem
            // 
            this.图书管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理图书信息ToolStripMenuItem,
            this.管理借书信息ToolStripMenuItem,
            this.审核用户还书ToolStripMenuItem});
            this.图书管理ToolStripMenuItem.Name = "图书管理ToolStripMenuItem";
            this.图书管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.图书管理ToolStripMenuItem.Text = "图书管理";
            // 
            // 管理图书信息ToolStripMenuItem
            // 
            this.管理图书信息ToolStripMenuItem.Name = "管理图书信息ToolStripMenuItem";
            this.管理图书信息ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.管理图书信息ToolStripMenuItem.Text = "管理图书信息";
            this.管理图书信息ToolStripMenuItem.Click += new System.EventHandler(this.管理图书信息ToolStripMenuItem_Click);
            // 
            // 管理借书信息ToolStripMenuItem
            // 
            this.管理借书信息ToolStripMenuItem.Name = "管理借书信息ToolStripMenuItem";
            this.管理借书信息ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.管理借书信息ToolStripMenuItem.Text = "管理借书信息";
            this.管理借书信息ToolStripMenuItem.Click += new System.EventHandler(this.管理借书信息ToolStripMenuItem_Click);
            // 
            // 审核用户还书ToolStripMenuItem
            // 
            this.审核用户还书ToolStripMenuItem.Name = "审核用户还书ToolStripMenuItem";
            this.审核用户还书ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.审核用户还书ToolStripMenuItem.Text = "审核用户还书";
            this.审核用户还书ToolStripMenuItem.Click += new System.EventHandler(this.审核用户还书ToolStripMenuItem_Click);
            // 
            // 还书
            // 
            this.还书.BackColor = System.Drawing.SystemColors.Menu;
            this.还书.Location = new System.Drawing.Point(379, 0);
            this.还书.Name = "还书";
            this.还书.Size = new System.Drawing.Size(75, 26);
            this.还书.TabIndex = 4;
            this.还书.Text = "还书";
            this.还书.UseVisualStyleBackColor = false;
            this.还书.Click += new System.EventHandler(this.还书_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 422);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormAdminBookManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.还书);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormAdminBookManagement";
            this.Text = "图书管理";
            this.Load += new System.EventHandler(this.FormAdminBookManagement_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 图书管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理图书信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理借书信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 审核用户还书ToolStripMenuItem;
        private System.Windows.Forms.Button 还书;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}