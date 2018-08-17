using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ShuJuZhuLiExcelAddIn.Server;
using Newtonsoft.Json.Linq;

namespace ShuJuZhuLiExcelAddIn.DataShare
{
    public partial class UserControlDataShare : UserControl
    {
        public UserControlDataShare()
        {
            InitializeComponent();
            this.Load += UserControlDataShare_Load;
        }

        private void UserControlDataShare_Load(object sender, EventArgs e)
        {
            this.GetCategoryFromServer();
        }


        private void GetCategoryFromServer()
        {
            RequestProcessor rp = new RequestProcessor();
            string serviceUrl = "dataShareNcpService/getCategoryTypeList.action";
            rp.InvokeGetData(serviceUrl, "", new RequestProcessor.DelegateAfterGetDataMethod(this.InvokeAfterGetCategroy));
        }

        private delegate void AfterGetCategroyFailedDelegate(Exception ex);
        private delegate void AfterGetCategroySucceedDelegate(JObject resultInfoJson);

        private void InvokeAfterGetCategroy(Exception ex, JObject resultInfoJson)
        {
            if (ex == null)
            {
                this.Invoke(new AfterGetCategroySucceedDelegate(this.AfterGetCategroySucceed), resultInfoJson);
            }
            else
            {
                this.Invoke(new AfterGetCategroyFailedDelegate(this.AfterGetCategroyFailed), ex);
            }
        }

        private void AfterGetCategroySucceed(JObject resultInfoJson)
        {
            this.ShowStatus(""); 

            JArray typeArray = resultInfoJson.GetValue("categoryTypes") as JArray;
            if (typeArray.Count > 0)
            {
                for (int i = 0; i < typeArray.Count; i++)
                {
                    JObject categoryJson = typeArray[i] as JObject;
                    string typeName = categoryJson.GetValue("name").ToString();

                    TabPage cateTabPage = new TabPage();
                    cateTabPage.AutoScroll = true;
                    cateTabPage.Margin = new System.Windows.Forms.Padding(0);
                    cateTabPage.Padding = new System.Windows.Forms.Padding(0);
                    cateTabPage.BackColor = Color.White;
                    this.tabControlCategory.Controls.Add(cateTabPage);
                      

                    UserControlCategoryDataList categoryUserControl = new UserControlCategoryDataList();
                    categoryUserControl.Dock = DockStyle.Fill;
                    categoryUserControl.ShowSubCategory(categoryJson);
                    cateTabPage.Controls.Add(categoryUserControl);
                    int dataCount = categoryUserControl.GetDataCount();

                    cateTabPage.Text = "按" + typeName + "分类(" + dataCount.ToString() + ")";
                }
            }
        }

        private void AfterGetCategroyFailed(Exception ex)
        {
            if (ex == null)
            {
                this.ShowStatus(ex.Message);
            }
        }

        private void ShowStatus(string statusInfo)
        {
            this.toolStripLabelStatus.Text = statusInfo;
        }
    }
}
