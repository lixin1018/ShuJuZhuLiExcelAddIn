using Microsoft.Office.Tools;
using NetDataAccess.Base.EnumTypes;
using ShuJuZhuLiExcelAddIn.Config;
using ShuJuZhuLiExcelAddIn.Pane;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShuJuZhuLiExcelAddIn.Log
{
    public class LogProcessor
    {
        private StringBuilder _LogStringBuilder = new StringBuilder();

        public void AddLog(string msg, LogLevelType logLevel)
        {
            string s = DateTime.Now.ToString("(yyyy-MM-dd HH:mm:ss)\r\n") + logLevel.ToString() + ": " + msg + "\r\n";
            this._LogStringBuilder.AppendLine(s);
            this.ShowLog();
        }

        public void ShowLog()
        {
            if (SystemConfig.SystemPaneList.ExistPane(PaneType.Log))
            {
                CustomTaskPane logViewer = this.LogViewer;
                UserControlLog logControl = (UserControlLog)logViewer.Control;
                logControl.InvokeShowLog(this._LogStringBuilder.ToString());
            }
        }

        private CustomTaskPane LogViewer
        {
            get
            {
                return SystemConfig.SystemPaneList.GetPane(PaneType.Log);
            }
        }
    }
}
