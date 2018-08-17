using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using NetDataAccess.Base.Common;

namespace ShuJuZhuLiExcelAddIn.DataShare
{
    public partial class UserControlCategoryDataList : UserControl
    {
        public UserControlCategoryDataList()
        {
            InitializeComponent();
            this.dataGridViewCategroyDataList.CellPainting += dataGridViewCategroyDataList_CellPainting;
            this.dataGridViewCategroyDataList.CellContentClick += dataGridViewCategroyDataList_CellContentClick;
        }

        private void dataGridViewCategroyDataList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (dataGridViewCategroyDataList.Columns[e.ColumnIndex].Name == "ColumnShowDetail")
                {
                    DataGridViewCellCollection cells = this.dataGridViewCategroyDataList.Rows[e.RowIndex].Cells;

                    string dataCode = cells[ColumnDataCode.Index].Value.ToString();
                    string dataName = cells[ColumnDataName.Index].Value.ToString();
                    if (dataCode.Length != 0)
                    {
                        MessageBox.Show(dataName);
                    }
                }
            }
        }

        private void dataGridViewCategroyDataList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex > -1)
            { 
                string showIndex = this.dataGridViewCategroyDataList.Rows[e.RowIndex].Cells[ColumnShowIndex.Name].Value.ToString();
                if (showIndex.Length == 0)
                {
                    Font subCateFont = new Font(e.CellStyle.Font, FontStyle.Bold);
                    e.CellStyle.Font = subCateFont;
                }
            }
        }

        private int _DataCount = 0;
        public int GetDataCount()
        {
            return this._DataCount;
        }

        public void ShowSubCategory(JObject categoryJson)
        {
            JArray subCategoryArray = categoryJson.GetValue("categoryArray") as JArray;
            DataTable dt = new DataTable();
            dt.Columns.Add("dataName");
            dt.Columns.Add("dataCode");
            dt.Columns.Add("lastUpdateTime");
            dt.Columns.Add("dataTableName");
            dt.Columns.Add("showIndex");
            dt.Columns.Add("showDetail");
            for (int i = 0; i < subCategoryArray.Count; i++)
            {
                JObject subCategoryJson = subCategoryArray[i] as JObject;
                string subCategoryName = CommonUtil.UrlDecode(subCategoryJson.GetValue("name").ToString());

                JArray dataArray = subCategoryJson.GetValue("dataList") as JArray;
                int subCategoryDataCount = dataArray == null ? 0 : dataArray.Count;
                this._DataCount += subCategoryDataCount;

                dt.Rows.Add(new object[] { subCategoryName + " (" + subCategoryDataCount.ToString() + ")", "", "", "", "", "" });

                if (subCategoryDataCount>0)
                {
                    for (int j = 0; j < subCategoryDataCount; j++)
                    {
                        JObject dataJson = dataArray[j] as JObject;
                        string dataName = CommonUtil.UrlDecode(dataJson.GetValue("name").ToString());
                        string dataCode = dataJson.GetValue("code").ToString();
                        string lastUpdateTime = dataJson.GetValue("lastUpdateTime").ToString();
                        string tableName = dataJson.GetValue("tableName").ToString();

                        dt.Rows.Add(new object[] { "  " + dataName, dataCode, lastUpdateTime, tableName, (j + 1).ToString(), "详情" });

                    }
                }
            }
            this.dataGridViewCategroyDataList.DataSource = dt; 
        }


    }
}
