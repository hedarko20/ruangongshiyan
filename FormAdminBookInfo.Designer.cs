﻿
namespace LibraryManagement
{
    partial class FormAdminBookInfo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.书目管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增加书目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除书目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读者登记的书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 32);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(798, 416);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.书目管理ToolStripMenuItem,
            this.读者登记的书ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 书目管理ToolStripMenuItem
            // 
            this.书目管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增加书目ToolStripMenuItem,
            this.删除书目ToolStripMenuItem});
            this.书目管理ToolStripMenuItem.Name = "书目管理ToolStripMenuItem";
            this.书目管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.书目管理ToolStripMenuItem.Text = "书目管理";
            // 
            // 增加书目ToolStripMenuItem
            // 
            this.增加书目ToolStripMenuItem.Name = "增加书目ToolStripMenuItem";
            this.增加书目ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.增加书目ToolStripMenuItem.Text = "增加书目";
            this.增加书目ToolStripMenuItem.Click += new System.EventHandler(this.增加书目ToolStripMenuItem_Click);
            // 
            // 删除书目ToolStripMenuItem
            // 
            this.删除书目ToolStripMenuItem.Name = "删除书目ToolStripMenuItem";
            this.删除书目ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.删除书目ToolStripMenuItem.Text = "删除书目";
            this.删除书目ToolStripMenuItem.Click += new System.EventHandler(this.删除书目ToolStripMenuItem_Click);
            // 
            // 读者登记的书ToolStripMenuItem
            // 
            this.读者登记的书ToolStripMenuItem.Name = "读者登记的书ToolStripMenuItem";
            this.读者登记的书ToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.读者登记的书ToolStripMenuItem.Text = "读者登记的书";
            this.读者登记的书ToolStripMenuItem.Click += new System.EventHandler(this.读者登记的书ToolStripMenuItem_Click);
            // 
            // FormAdminBookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormAdminBookInfo";
            this.Text = "书目管理";
            this.Load += new System.EventHandler(this.FormAdminBookInfo_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 书目管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增加书目ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除书目ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读者登记的书ToolStripMenuItem;
    }
}