namespace ShuJuZhuLiExcelAddIn
{
    partial class RibbonGoOnData : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public RibbonGoOnData()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RibbonGoOnData));
            this.tabGoOnData = this.Factory.CreateRibbonTab();
            this.groupGoOnDataShareDB = this.Factory.CreateRibbonGroup();
            this.groupUser = this.Factory.CreateRibbonGroup();
            this.groupLog = this.Factory.CreateRibbonGroup();
            this.labelUserStatus = this.Factory.CreateRibbonLabel();
            this.separator1 = this.Factory.CreateRibbonSeparator();
            this.buttonOpenGoOnDataShareDB = this.Factory.CreateRibbonButton();
            this.buttonLogin = this.Factory.CreateRibbonButton();
            this.buttonLogout = this.Factory.CreateRibbonButton();
            this.buttonChangePassword = this.Factory.CreateRibbonButton();
            this.buttonForgetPwd = this.Factory.CreateRibbonButton();
            this.buttonShowLog = this.Factory.CreateRibbonButton();
            this.tabGoOnData.SuspendLayout();
            this.groupGoOnDataShareDB.SuspendLayout();
            this.groupUser.SuspendLayout();
            this.groupLog.SuspendLayout();
            // 
            // tabGoOnData
            // 
            this.tabGoOnData.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tabGoOnData.Groups.Add(this.groupGoOnDataShareDB);
            this.tabGoOnData.Groups.Add(this.groupUser);
            this.tabGoOnData.Groups.Add(this.groupLog);
            this.tabGoOnData.Label = "GoOnData";
            this.tabGoOnData.Name = "tabGoOnData";
            // 
            // groupGoOnDataShareDB
            // 
            this.groupGoOnDataShareDB.Items.Add(this.buttonOpenGoOnDataShareDB);
            this.groupGoOnDataShareDB.Label = "数据共享";
            this.groupGoOnDataShareDB.Name = "groupGoOnDataShareDB";
            // 
            // groupUser
            // 
            this.groupUser.Items.Add(this.labelUserStatus);
            this.groupUser.Items.Add(this.buttonLogin);
            this.groupUser.Items.Add(this.buttonLogout);
            this.groupUser.Items.Add(this.separator1);
            this.groupUser.Items.Add(this.buttonChangePassword);
            this.groupUser.Items.Add(this.buttonForgetPwd);
            this.groupUser.Label = "账号管理";
            this.groupUser.Name = "groupUser";
            // 
            // groupLog
            // 
            this.groupLog.Items.Add(this.buttonShowLog);
            this.groupLog.Label = "日志";
            this.groupLog.Name = "groupLog";
            // 
            // labelUserStatus
            // 
            this.labelUserStatus.Label = "状态:未登录";
            this.labelUserStatus.Name = "labelUserStatus";
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            // 
            // buttonOpenGoOnDataShareDB
            // 
            this.buttonOpenGoOnDataShareDB.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonOpenGoOnDataShareDB.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenGoOnDataShareDB.Image")));
            this.buttonOpenGoOnDataShareDB.Label = "访问共享数据库";
            this.buttonOpenGoOnDataShareDB.Name = "buttonOpenGoOnDataShareDB";
            this.buttonOpenGoOnDataShareDB.ScreenTip = "访问GoOnData.com共享数据库";
            this.buttonOpenGoOnDataShareDB.ShowImage = true;
            this.buttonOpenGoOnDataShareDB.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonOpenGoOnDataShareDB_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogin.Image")));
            this.buttonLogin.Label = "登录";
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.ScreenTip = "登录到GoOnData.com服务";
            this.buttonLogin.ShowImage = true;
            this.buttonLogin.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogout.Image")));
            this.buttonLogout.Label = "登出";
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.ScreenTip = "登出GoOnData.com服务";
            this.buttonLogout.ShowImage = true;
            this.buttonLogout.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonLogout_Click);
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("buttonChangePassword.Image")));
            this.buttonChangePassword.Label = "修改密码";
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.ScreenTip = "修改密码";
            this.buttonChangePassword.ShowImage = true;
            this.buttonChangePassword.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonChangePassword_Click);
            // 
            // buttonForgetPwd
            // 
            this.buttonForgetPwd.Image = ((System.Drawing.Image)(resources.GetObject("buttonForgetPwd.Image")));
            this.buttonForgetPwd.Label = "忘记密码";
            this.buttonForgetPwd.Name = "buttonForgetPwd";
            this.buttonForgetPwd.ScreenTip = "忘记密码";
            this.buttonForgetPwd.ShowImage = true;
            this.buttonForgetPwd.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonForgetPwd_Click);
            // 
            // buttonShowLog
            // 
            this.buttonShowLog.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonShowLog.Image = ((System.Drawing.Image)(resources.GetObject("buttonShowLog.Image")));
            this.buttonShowLog.Label = "查看日志";
            this.buttonShowLog.Name = "buttonShowLog";
            this.buttonShowLog.ShowImage = true;
            this.buttonShowLog.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonShowLog_Click);
            // 
            // RibbonGoOnData
            // 
            this.Name = "RibbonGoOnData";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tabGoOnData);
            this.tabGoOnData.ResumeLayout(false);
            this.tabGoOnData.PerformLayout();
            this.groupGoOnDataShareDB.ResumeLayout(false);
            this.groupGoOnDataShareDB.PerformLayout();
            this.groupUser.ResumeLayout(false);
            this.groupUser.PerformLayout();
            this.groupLog.ResumeLayout(false);
            this.groupLog.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tabGoOnData;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupGoOnDataShareDB;
        protected Microsoft.Office.Tools.Ribbon.RibbonButton buttonOpenGoOnDataShareDB;
        public Microsoft.Office.Tools.Ribbon.RibbonGroup groupUser;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonLogin;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonLogout;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonChangePassword;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonForgetPwd;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupLog;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonShowLog;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel labelUserStatus;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator1;
    }

    partial class ThisRibbonCollection
    {
        internal RibbonGoOnData RibbonShuJuZhuLi
        {
            get { return this.GetRibbon<RibbonGoOnData>(); }
        }
    }
}
