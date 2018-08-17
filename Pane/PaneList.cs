using Microsoft.Office.Tools;
using ShuJuZhuLiExcelAddIn.DataShare;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShuJuZhuLiExcelAddIn.Pane
{
    public class PaneList
    {
        private Dictionary<PaneType, CustomTaskPane> PaneDic = new Dictionary<PaneType, CustomTaskPane>();

        public void ShowPane(PaneType paneType)
        {
            CustomTaskPane taskPane = this.GetPane(paneType);
            taskPane.Visible = true;
        }

        public CustomTaskPane GetPane(PaneType paneType)
        {
            if (!PaneDic.ContainsKey(paneType))
            {
                CustomTaskPane taskPane = this.CreatePane(paneType);
                PaneDic.Add(paneType, taskPane);
            }
            return PaneDic[paneType];
        }

        public bool ExistPane(PaneType paneType)
        {
            return PaneDic.ContainsKey(paneType);
        }

        private CustomTaskPane CreatePane(PaneType paneType)
        {
            switch (paneType)
            {
                case PaneType.ShareDB:
                    {
                        UserControlDataShare goondataDBPane = new UserControlDataShare();
                        CustomTaskPane goondataTaskPane = Globals.ThisAddIn.AddCustomTaskPane(goondataDBPane, "共享数据库-GoOnData");
                        goondataTaskPane.Width = 400;
                        return goondataTaskPane;
                    }
                case PaneType.Log:
                    {
                        UserControlLog logPane = new UserControlLog();
                        CustomTaskPane logTaskPane = Globals.ThisAddIn.AddCustomTaskPane(logPane, "日志-GoOnData");
                        logTaskPane.Width = 300;
                        return logTaskPane;
                    } 
                default:
                    throw new Exception("Unknown pane type. PaneType = " + paneType.ToString()); 
            }
        } 
         
    }
}
