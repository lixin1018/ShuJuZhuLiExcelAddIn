using ShuJuZhuLiExcelAddIn.Log;
using ShuJuZhuLiExcelAddIn.Pane;
using ShuJuZhuLiExcelAddIn.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace ShuJuZhuLiExcelAddIn.Config
{
    public class SystemConfig
    {
        private static PaneList _SystemPaneList = null;
        public static PaneList SystemPaneList
        {
            get
            {
                return _SystemPaneList;
            }
        } 

        private static LogProcessor _SystemLogProcessor = null;
        public static LogProcessor SystemLogProcessor
        {
            get
            {
                if (_SystemLogProcessor == null)
                {
                    _SystemLogProcessor = new LogProcessor();
                }
                return _SystemLogProcessor;
            }
        }

        public static void RefreshUserStatus()
        {
            RibbonGoOnData ribbonGoOnData = (RibbonGoOnData)Globals.Ribbons.GetRibbon(typeof(RibbonGoOnData));
            ribbonGoOnData.RefreshUserStatus();
        }

        public static void Init()
        {
            _SystemPaneList = new PaneList();
            RefreshUserStatus();
        } 

        public static string ForgetPwdPageUrl
        {
            get
            {
                return ServerRootUrl + "page/h/grzx/forgetPwd.jsp";
            }
        }
        public static string ChangePwdPageUrl
        {
            get
            {
                return ServerRootUrl + "page/h/grzx/changePwd.jsp";
            }
        }

        public static string ServerRootUrl
        {
            get
            {
                return "http://localhost:8080/s/";
            }
        }

        public static int WebRequestTimeoutSeconds
        {
            get
            {
                return 5;
            }
        }

        public static void SetCurrentUser(string userId, string userCode, string userName, ICredentials credentials)
        {
            _UserId = userId;
            _UserName = userName;
            _UserCode = userCode;
            _UserCredentials = credentials;
            RefreshUserStatus();
        }

        private static ICredentials _UserCredentials = null;
        public static ICredentials UserCredentials
        {
            get
            {
                return _UserCredentials;
            }
        }

        public static bool HadLogin()
        {
            return UserId != null;
        }

        private static string _UserId = null;
        public static string UserId
        {
            get
            {
                return _UserId;
            }
        }

        private static string _UserCode = null;
        public static string UserCode
        {
            get
            {
                return _UserCode;
            }
        }

        private static string _UserName = null;
        public static string UserName
        { 
            get
            {
                return _UserName;
            }
        }

    }

}
