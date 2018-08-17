using ShuJuZhuLiExcelAddIn.Config;
using ShuJuZhuLiExcelAddIn.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShuJuZhuLiExcelAddIn.User
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.FormClosing += FormLogin_FormClosing;
            this.labelStatus.Text = "";
        }

        void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this._LoginRequestProcessor != null)
            {
                this._LoginRequestProcessor.Abort();
            }
        }

        private RequestProcessor _LoginRequestProcessor = null;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.EnableControls(false, "正在登录......");
            RequestProcessor rp = new RequestProcessor();
            this._LoginRequestProcessor = rp;
            rp.InvokeLogin(this.textBoxUserName.Text, this.textBoxPwd.Text, new RequestProcessor.DelegateAfterLoginMethod(this.InvokeAfterLogin));
        }

        private void AfterLogin(Exception ex)
        { 
            if (ex == null)
            {
                this.EnableControls(true, "登录成功");
                this.Close();
            }
            else
            {
                this.EnableControls(true, ex.Message);
            }
        }

        private delegate void AfterLoginDelegate(Exception ex);

        private void InvokeAfterLogin(Exception ex)
        {
            this.Invoke(new AfterLoginDelegate(this.AfterLogin),  ex );
        }

        private void EnableControls(bool enable, string statusInfo)
        {
            this.textBoxUserName.Enabled = enable;
            this.textBoxPwd.Enabled = enable;
            this.buttonLogin.Enabled = enable;
            this.buttonCancel.Enabled = enable;
            this.labelStatus.Text = statusInfo;
        }



        private void buttonCancel_Click(object sender, EventArgs e)
        { 
            this.Close();
        }
    }
}
