using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.Office.Interop.Excel;
using ShuJuZhuLiExcelAddIn.Pane;
using ShuJuZhuLiExcelAddIn.Config;
using ShuJuZhuLiExcelAddIn.User;
using ShuJuZhuLiExcelAddIn.Server;
using System.Windows.Forms;
using NetDataAccess.Base.EnumTypes;

namespace ShuJuZhuLiExcelAddIn
{
    public partial class RibbonGoOnData
    { 

        private void buttonOpenGoOnDataShareDB_Click(object sender, RibbonControlEventArgs e)
        {
            SystemConfig.SystemPaneList.ShowPane(PaneType.ShareDB);
        }

        private void buttonChangePassword_Click(object sender, RibbonControlEventArgs e)
        {
            System.Diagnostics.Process.Start(SystemConfig.ChangePwdPageUrl);
        }

        private void buttonForgetPwd_Click(object sender, RibbonControlEventArgs e)
        {
            System.Diagnostics.Process.Start(SystemConfig.ForgetPwdPageUrl);
        }

        private void buttonLogin_Click(object sender, RibbonControlEventArgs e)
        {
            FormLogin loginForm = new FormLogin();
            loginForm.ShowDialog();
        }

        private void buttonShowLog_Click(object sender, RibbonControlEventArgs e)
        {
            bool isNewLogViewer = !SystemConfig.SystemPaneList.ExistPane(PaneType.Log);
            SystemConfig.SystemPaneList.ShowPane(PaneType.Log);
            if (isNewLogViewer)
            {
                SystemConfig.SystemLogProcessor.ShowLog();
            } 
        }

        public void RefreshUserStatus()
        {
            if (SystemConfig.HadLogin())
            {
                this.labelUserStatus.Label = "状态: 已登录\r\n用户: " + SystemConfig.UserName;
                this.buttonLogin.Visible = false;
                this.buttonLogout.Visible = true;
            }
            else
            {
                this.labelUserStatus.Label = "状态:未登录";
                this.buttonLogin.Visible = true;
                this.buttonLogout.Visible = false;
            }
        }

        private void buttonLogout_Click(object sender, RibbonControlEventArgs e)
        {
            if (MessageBox.Show("是否要登出GoOnData服务?", "确定", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                SystemConfig.SystemLogProcessor.AddLog("登出系统中......", LogLevelType.System);
                RequestProcessor rp = new RequestProcessor();
                rp.InvokeLogout();
                SystemConfig.SetCurrentUser(null, null, null, null);
                SystemConfig.RefreshUserStatus();
                SystemConfig.SystemLogProcessor.AddLog("成功登出.", LogLevelType.System);
            }
        } 
    }
}
