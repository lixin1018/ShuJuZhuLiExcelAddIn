namespace ShuJuZhuLiExcelAddIn.DataShare
{
    partial class UserControlCategoryDataList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewCategroyDataList = new System.Windows.Forms.DataGridView();
            this.ColumnShowIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataTableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLastUpdateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnShowDetail = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategroyDataList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCategroyDataList
            // 
            this.dataGridViewCategroyDataList.AllowUserToAddRows = false;
            this.dataGridViewCategroyDataList.AllowUserToDeleteRows = false;
            this.dataGridViewCategroyDataList.AllowUserToResizeColumns = false;
            this.dataGridViewCategroyDataList.AllowUserToResizeRows = false;
            this.dataGridViewCategroyDataList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCategroyDataList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCategroyDataList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCategroyDataList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCategroyDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategroyDataList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnShowIndex,
            this.ColumnDataCode,
            this.ColumnDataName,
            this.ColumnDataTableName,
            this.ColumnLastUpdateTime,
            this.ColumnShowDetail});
            this.dataGridViewCategroyDataList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCategroyDataList.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewCategroyDataList.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCategroyDataList.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewCategroyDataList.MultiSelect = false;
            this.dataGridViewCategroyDataList.Name = "dataGridViewCategroyDataList";
            this.dataGridViewCategroyDataList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewCategroyDataList.RowHeadersVisible = false;
            this.dataGridViewCategroyDataList.RowTemplate.Height = 23;
            this.dataGridViewCategroyDataList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCategroyDataList.ShowCellErrors = false;
            this.dataGridViewCategroyDataList.ShowEditingIcon = false;
            this.dataGridViewCategroyDataList.ShowRowErrors = false;
            this.dataGridViewCategroyDataList.Size = new System.Drawing.Size(446, 547);
            this.dataGridViewCategroyDataList.TabIndex = 1;
            // 
            // ColumnShowIndex
            // 
            this.ColumnShowIndex.DataPropertyName = "showIndex";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnShowIndex.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnShowIndex.HeaderText = "";
            this.ColumnShowIndex.Name = "ColumnShowIndex";
            this.ColumnShowIndex.ReadOnly = true;
            this.ColumnShowIndex.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnShowIndex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnShowIndex.Visible = false;
            this.ColumnShowIndex.Width = 30;
            // 
            // ColumnDataCode
            // 
            this.ColumnDataCode.DataPropertyName = "dataCode";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ColumnDataCode.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnDataCode.HeaderText = "编码";
            this.ColumnDataCode.Name = "ColumnDataCode";
            this.ColumnDataCode.ReadOnly = true;
            this.ColumnDataCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnDataCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnDataCode.Visible = false;
            this.ColumnDataCode.Width = 50;
            // 
            // ColumnDataName
            // 
            this.ColumnDataName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDataName.DataPropertyName = "dataName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ColumnDataName.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnDataName.HeaderText = "名称";
            this.ColumnDataName.Name = "ColumnDataName";
            this.ColumnDataName.ReadOnly = true;
            this.ColumnDataName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnDataName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnDataTableName
            // 
            this.ColumnDataTableName.DataPropertyName = "dataTableName";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ColumnDataTableName.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnDataTableName.HeaderText = "表名";
            this.ColumnDataTableName.Name = "ColumnDataTableName";
            this.ColumnDataTableName.ReadOnly = true;
            this.ColumnDataTableName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnDataTableName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnDataTableName.Visible = false;
            this.ColumnDataTableName.Width = 50;
            // 
            // ColumnLastUpdateTime
            // 
            this.ColumnLastUpdateTime.DataPropertyName = "lastUpdateTime";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColumnLastUpdateTime.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColumnLastUpdateTime.HeaderText = "更新时间";
            this.ColumnLastUpdateTime.Name = "ColumnLastUpdateTime";
            this.ColumnLastUpdateTime.ReadOnly = true;
            this.ColumnLastUpdateTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnLastUpdateTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnLastUpdateTime.Width = 80;
            // 
            // ColumnShowDetail
            // 
            this.ColumnShowDetail.ActiveLinkColor = System.Drawing.Color.Black;
            this.ColumnShowDetail.DataPropertyName = "showDetail";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnShowDetail.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColumnShowDetail.HeaderText = "";
            this.ColumnShowDetail.LinkColor = System.Drawing.Color.Black;
            this.ColumnShowDetail.Name = "ColumnShowDetail";
            this.ColumnShowDetail.ReadOnly = true;
            this.ColumnShowDetail.Width = 40;
            // 
            // UserControlCategoryDataList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridViewCategroyDataList);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControlCategoryDataList";
            this.Size = new System.Drawing.Size(446, 547);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategroyDataList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCategroyDataList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnShowIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataTableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLastUpdateTime;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnShowDetail;
    }
}
