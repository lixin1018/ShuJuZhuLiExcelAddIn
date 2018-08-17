namespace ShuJuZhuLiExcelAddIn.DataShare
{
    partial class UserControlDataShare
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlDataShare));
            this.toolStripCategory = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabelStatus = new System.Windows.Forms.ToolStripLabel();
            this.tabControlCategory = new System.Windows.Forms.TabControl();
            this.toolStripCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripCategory
            // 
            this.toolStripCategory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonRefresh,
            this.toolStripLabelStatus});
            this.toolStripCategory.Location = new System.Drawing.Point(0, 0);
            this.toolStripCategory.Name = "toolStripCategory";
            this.toolStripCategory.Size = new System.Drawing.Size(541, 25);
            this.toolStripCategory.TabIndex = 1;
            this.toolStripCategory.Text = "toolStrip1";
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRefresh.Image")));
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRefresh.Text = "刷新";
            this.toolStripButtonRefresh.ToolTipText = "刷新数据分类列表";
            // 
            // toolStripLabelStatus
            // 
            this.toolStripLabelStatus.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabelStatus.Name = "toolStripLabelStatus";
            this.toolStripLabelStatus.Size = new System.Drawing.Size(146, 22);
            this.toolStripLabelStatus.Text = "正在获取数据分类列表......";
            // 
            // tabControlCategory
            // 
            this.tabControlCategory.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlCategory.Location = new System.Drawing.Point(0, 25);
            this.tabControlCategory.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlCategory.Multiline = true;
            this.tabControlCategory.Name = "tabControlCategory";
            this.tabControlCategory.Padding = new System.Drawing.Point(0, 0);
            this.tabControlCategory.SelectedIndex = 0;
            this.tabControlCategory.Size = new System.Drawing.Size(541, 494);
            this.tabControlCategory.TabIndex = 2;
            // 
            // UserControlDataShare
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlCategory);
            this.Controls.Add(this.toolStripCategory);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControlDataShare";
            this.Size = new System.Drawing.Size(541, 519);
            this.toolStripCategory.ResumeLayout(false);
            this.toolStripCategory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripCategory;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.ToolStripLabel toolStripLabelStatus;
        private System.Windows.Forms.TabControl tabControlCategory;


    }
}
