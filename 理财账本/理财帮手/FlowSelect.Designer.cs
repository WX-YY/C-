
namespace 理财帮手
{
    partial class FlowSelect
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlowSelect));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemTableAdapter = new 理财帮手.MyFinancingDataSetTableAdapters.itemTableAdapter();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myFinancingDataSet = new 理财帮手.MyFinancingDataSet();
            this.itemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.BtnAll = new System.Windows.Forms.Button();
            this.BtnSR = new System.Windows.Forms.Button();
            this.BtnZC = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myFinancingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(654, 316);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // myFinancingDataSet
            // 
            this.myFinancingDataSet.DataSetName = "MyFinancingDataSet";
            this.myFinancingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemBindingSource1
            // 
            this.itemBindingSource1.DataMember = "item";
            this.itemBindingSource1.DataSource = this.myFinancingDataSet;
            // 
            // BtnAll
            // 
            this.BtnAll.Location = new System.Drawing.Point(59, 372);
            this.BtnAll.Name = "BtnAll";
            this.BtnAll.Size = new System.Drawing.Size(127, 42);
            this.BtnAll.TabIndex = 1;
            this.BtnAll.Text = "查询全部";
            this.BtnAll.UseVisualStyleBackColor = true;
            this.BtnAll.Click += new System.EventHandler(this.BtnAll_Click);
            // 
            // BtnSR
            // 
            this.BtnSR.Location = new System.Drawing.Point(330, 372);
            this.BtnSR.Name = "BtnSR";
            this.BtnSR.Size = new System.Drawing.Size(127, 42);
            this.BtnSR.TabIndex = 2;
            this.BtnSR.Text = "收入查询";
            this.BtnSR.UseVisualStyleBackColor = true;
            this.BtnSR.Click += new System.EventHandler(this.BtnSR_Click);
            // 
            // BtnZC
            // 
            this.BtnZC.Location = new System.Drawing.Point(586, 372);
            this.BtnZC.Name = "BtnZC";
            this.BtnZC.Size = new System.Drawing.Size(127, 42);
            this.BtnZC.TabIndex = 3;
            this.BtnZC.Text = "支出查询";
            this.BtnZC.UseVisualStyleBackColor = true;
            this.BtnZC.Click += new System.EventHandler(this.BtnZC_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(770, 461);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FlowSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 461);
            this.Controls.Add(this.BtnZC);
            this.Controls.Add(this.BtnSR);
            this.Controls.Add(this.BtnAll);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FlowSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlowSelect";
            this.Load += new System.EventHandler(this.FlowSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myFinancingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MyFinancingDataSetTableAdapters.itemTableAdapter itemTableAdapter;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private MyFinancingDataSet myFinancingDataSet;
        private System.Windows.Forms.BindingSource itemBindingSource1;
        private System.Windows.Forms.Button BtnAll;
        private System.Windows.Forms.Button BtnSR;
        private System.Windows.Forms.Button BtnZC;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}