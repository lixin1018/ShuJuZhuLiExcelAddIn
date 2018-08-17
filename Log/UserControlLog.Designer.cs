namespace ShuJuZhuLiExcelAddIn
{
    partial class UserControlLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlLog));
            this.toolStripLog = new System.Windows.Forms.ToolStrip();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.toolStripButtonClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripLog
            // 
            this.toolStripLog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonClear});
            this.toolStripLog.Location = new System.Drawing.Point(0, 0);
            this.toolStripLog.Name = "toolStripLog";
            this.toolStripLog.Size = new System.Drawing.Size(541, 25);
            this.toolStripLog.TabIndex = 0;
            this.toolStripLog.Text = "toolStrip1";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLog.Location = new System.Drawing.Point(0, 25);
            this.textBoxLog.MaxLength = 32767000;
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLog.Size = new System.Drawing.Size(541, 494);
            this.textBoxLog.TabIndex = 1;
            // 
            // toolStripButtonClear
            // 
            this.toolStripButtonClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClear.Image")));
            this.toolStripButtonClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClear.Name = "toolStripButtonClear";
            this.toolStripButtonClear.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonClear.Text = "清除";
            this.toolStripButtonClear.ToolTipText = "清除日志内容";
            this.toolStripButtonClear.Click += new System.EventHandler(this.toolStripButtonClear_Click);
            // 
            // UserControlLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.toolStripLog);
            this.Name = "UserControlLog";
            this.Size = new System.Drawing.Size(541, 519);
            this.toolStripLog.ResumeLayout(false);
            this.toolStripLog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripLog;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.ToolStripButton toolStripButtonClear;

    }
}
