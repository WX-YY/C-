using System;
using System.Windows.Forms;

namespace 理财帮手
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.账号操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注册ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.账本操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加支出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.账本详情ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.流水详细ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于我们ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.账号操作ToolStripMenuItem,
            this.账本操作ToolStripMenuItem,
            this.账本详情ToolStripMenuItem,
            this.关于我们ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(424, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 账号操作ToolStripMenuItem
            // 
            this.账号操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.注销ToolStripMenuItem,
            this.注册ToolStripMenuItem});
            this.账号操作ToolStripMenuItem.Name = "账号操作ToolStripMenuItem";
            this.账号操作ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.账号操作ToolStripMenuItem.Text = "账号操作";
            // 
            // 注销ToolStripMenuItem
            // 
            this.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem";
            this.注销ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.注销ToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.注销ToolStripMenuItem.Text = "注销";
            this.注销ToolStripMenuItem.Click += new System.EventHandler(this.注销ToolStripMenuItem_Click);
            // 
            // 注册ToolStripMenuItem
            // 
            this.注册ToolStripMenuItem.Name = "注册ToolStripMenuItem";
            this.注册ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.注册ToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.注册ToolStripMenuItem.Text = "注册";
            this.注册ToolStripMenuItem.Click += new System.EventHandler(this.注册ToolStripMenuItem_Click);
            // 
            // 账本操作ToolStripMenuItem
            // 
            this.账本操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加支出ToolStripMenuItem});
            this.账本操作ToolStripMenuItem.Name = "账本操作ToolStripMenuItem";
            this.账本操作ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.账本操作ToolStripMenuItem.Text = "账本操作";
            // 
            // 添加支出ToolStripMenuItem
            // 
            this.添加支出ToolStripMenuItem.Name = "添加支出ToolStripMenuItem";
            this.添加支出ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.添加支出ToolStripMenuItem.Text = "添加收支";
            this.添加支出ToolStripMenuItem.Click += new System.EventHandler(this.添加支出ToolStripMenuItem_Click);
            // 
            // 账本详情ToolStripMenuItem
            // 
            this.账本详情ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.流水详细ToolStripMenuItem});
            this.账本详情ToolStripMenuItem.Name = "账本详情ToolStripMenuItem";
            this.账本详情ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.账本详情ToolStripMenuItem.Text = "统计查询";
            // 
            // 流水详细ToolStripMenuItem
            // 
            this.流水详细ToolStripMenuItem.Name = "流水详细ToolStripMenuItem";
            this.流水详细ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.流水详细ToolStripMenuItem.Text = "流水详细";
            this.流水详细ToolStripMenuItem.Click += new System.EventHandler(this.流水详细ToolStripMenuItem_Click);
            // 
            // 关于我们ToolStripMenuItem
            // 
            this.关于我们ToolStripMenuItem.Name = "关于我们ToolStripMenuItem";
            this.关于我们ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.关于我们ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.关于我们ToolStripMenuItem.Text = "关于我们";
            this.关于我们ToolStripMenuItem.Click += new System.EventHandler(this.关于我们ToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(424, 333);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(424, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "迷你账本";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

     
   

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 账号操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 账本操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加支出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 账本详情ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 流水详细ToolStripMenuItem;
        private ToolStripMenuItem 注册ToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem 关于我们ToolStripMenuItem;
    }
}