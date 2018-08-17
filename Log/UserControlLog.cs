using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShuJuZhuLiExcelAddIn
{
    public partial class UserControlLog : UserControl
    {
        public UserControlLog()
        {
            InitializeComponent();
        }

        private delegate void ShowLogInvokeDelegate(string msg);
        
        public void InvokeShowLog(string msg)
        {
            this.Invoke(new ShowLogInvokeDelegate(this.ShowLog), msg);
        }
        private void ShowLog(string msg)
        {
            this.textBoxLog.Text =  msg ;
        }

        private void toolStripButtonClear_Click(object sender, EventArgs e)
        {
            this.textBoxLog.Clear();
        }
    }
}
