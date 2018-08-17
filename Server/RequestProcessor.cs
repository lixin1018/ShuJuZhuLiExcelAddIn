using NetDataAccess.Base.Common;
using NetDataAccess.Base.EnumTypes;
using NetDataAccess.Base.Web;
using Newtonsoft.Json.Linq;
using ShuJuZhuLiExcelAddIn.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;

namespace ShuJuZhuLiExcelAddIn.Server
{
    public class RequestProcessor
    {
        public RequestProcessor()
        {
            this._Id = Guid.NewGuid().ToString();
        }

        private string _Id = null;
        private string Id
        {
            get
            {
                return this._Id;
            }
        }

        private NDAWebClient CreateNewClient()
        {
            NDAWebClient client = new NDAWebClient();
            client.Timeout = SystemConfig.WebRequestTimeoutSeconds * 1000;
            client.Id = this.Id;
            client.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded; charset=UTF-8");
            client.Headers.Add("X-Requested-With", "XMLHttpRequest");
            client.ResponseEncoding = Encoding.UTF8;
            if (SystemConfig.UserCredentials != null)
            {
                client.Credentials = SystemConfig.UserCredentials;
            }
            return client;
        }


        private string Request(string methodUrl, string requestData)
        {
            string requestUrl = SystemConfig.ServerRootUrl + methodUrl;
            WebClient client = new WebClient();
            return "";
        }

        private int CheckIntervalSecond
        {
            get
            {
                return 1;
            }
        }

        public delegate void DelegateAfterLoginMethod(Exception ex);

        public delegate void DelegateAfterGetDataMethod(Exception ex, JObject resultInfoJson);


        public void InvokeLogin(string user, string pwd, DelegateAfterLoginMethod afterLogin)
        {
            Thread loginThread = new Thread(new ParameterizedThreadStart(this.Login));
            loginThread.Start(new object[] { user, pwd, afterLogin });
        }

        public void InvokeLogout()
        {
            Thread logoutThread = new Thread(new ThreadStart(this.Logout));
            logoutThread.Start();
        }

        public void Abort()
        {
            this._RequestActive = false;
        }

        private void Login(object p)
        {
            object[] parameters = (object[])p;
            string user = (string)parameters[0];
            string pwd = (string)parameters[1];
            DelegateAfterLoginMethod afterLogin = (DelegateAfterLoginMethod)parameters[2];
            string requestUrl = SystemConfig.ServerRootUrl + "userNcpService/login.action";
            JObject requestJo = new JObject();
            requestJo.Add("code", user);
            requestJo.Add("password", pwd);
            string fromData = "requestParam=" + CommonUtil.UrlEncode(requestJo.ToString());
            byte[] requestData = Encoding.UTF8.GetBytes(fromData);

            NDAWebClient webClient = this.CreateNewClient();
            webClient.UploadDataCompleted += webClient_UploadDataCompleted;


            AddLog("登录中...... 用户 = " + user, LogLevelType.System);
            this._RequestActive = true;
            webClient.UploadDataAsync(new Uri(requestUrl), "POST", requestData);

            int checkCount = 0;
            while (this._RequestActive && this._ResponseObject == null && checkCount * this.CheckIntervalSecond < SystemConfig.WebRequestTimeoutSeconds)
            {
                Thread.Sleep(this.CheckIntervalSecond * 1000);
            }

            if (this._RequestActive)
            {
                this._RequestActive = false;
                if (this._ResponseObject is Exception)
                {
                    Exception ex = (Exception)this._ResponseObject;
                    AddLog("登录失败, " + ex.Message, LogLevelType.Error);
                    afterLogin(ex);
                }
                else if (this._ResponseObject == null)
                {
                    Exception ex = new Exception("登录失败, 服务器端无响应");
                    AddLog(ex.Message, LogLevelType.Error);
                    afterLogin(ex);
                }
                else
                {
                    string responseText = Encoding.UTF8.GetString((byte[])this._ResponseObject);
                    JArray responseJA = JArray.Parse(responseText);
                    JObject jo = (JObject)responseJA[0];
                    string code = jo.GetValue("code").ToString();

                    switch (code)
                    {
                        case "000":
                            {
                                JObject resultJo = (JObject)jo.GetValue("result");
                                string userCode = resultJo.GetValue("userCode").ToString();
                                string userId = resultJo.GetValue("userId").ToString();
                                string userName = resultJo.GetValue("userName").ToString();
                                SystemConfig.SetCurrentUser(userId, userCode, userName, webClient.Credentials);
                                AddLog("登录成功, 用户 = " + userName + " (" + userCode + ")", LogLevelType.System);
                                afterLogin(null);
                            }
                            break;
                        default:
                            {
                                string msg = jo.GetValue("message").ToString();
                                Exception ex = new Exception("登录失败, " + msg);
                                AddLog("登录失败, 返回错误码 = " + code + ", 错误信息 = " + msg, LogLevelType.System);
                                afterLogin(ex);
                            }
                            break;
                    }
                }
            }
        }

        public void InvokeGetData(string serviceUrl, string requestParam, DelegateAfterGetDataMethod afterGetData)
        {
            Thread loginThread = new Thread(new ParameterizedThreadStart(this.GetData));
            loginThread.Start(new object[] { serviceUrl, requestParam, afterGetData });
        }

        private void GetData(object p)
        {
            object[] parameters = (object[])p;
            string serviceUrl = (string)parameters[0];
            string requestParam = (string)parameters[1];
            DelegateAfterGetDataMethod afterGetData = (DelegateAfterGetDataMethod)parameters[2];
            string requestUrl = SystemConfig.ServerRootUrl + serviceUrl;
            string fromData = "requestParam=" + CommonUtil.UrlEncode(requestParam);
            byte[] requestData = Encoding.UTF8.GetBytes(fromData);

            NDAWebClient webClient = this.CreateNewClient();
            webClient.UploadDataCompleted += webClient_UploadDataCompleted;


            AddLog("调用服务中......ServiceUrl = " + serviceUrl + ", Id = " + this.Id, LogLevelType.System);
            this._RequestActive = true;
            webClient.UploadDataAsync(new Uri(requestUrl), "POST", requestData);

            int checkCount = 0;
            while (this._RequestActive && this._ResponseObject == null && checkCount * this.CheckIntervalSecond < SystemConfig.WebRequestTimeoutSeconds)
            {
                Thread.Sleep(this.CheckIntervalSecond * 1000);
            }

            if (this._RequestActive)
            {
                this._RequestActive = false;
                if (this._ResponseObject is Exception)
                {
                    Exception ex = (Exception)this._ResponseObject;
                    AddLog("调用服务失败, " + ex.Message + ", RequestId = " + this.Id, LogLevelType.Error);
                    afterGetData(ex, null);
                }
                else if (this._ResponseObject == null)
                {
                    Exception ex = new Exception("登录失败, 服务器端无响应");
                    AddLog(ex.Message + ", RequestId = " + this.Id, LogLevelType.Error);
                    afterGetData(ex, null);
                }
                else
                {
                    string responseText = Encoding.UTF8.GetString((byte[])this._ResponseObject);
                    JArray responseJA = JArray.Parse(responseText);
                    JObject jo = (JObject)responseJA[0];
                    string code = jo.GetValue("code").ToString();

                    switch (code)
                    {
                        case "000":
                            {
                                JObject resultJo = (JObject)jo.GetValue("result"); 
                                AddLog("调用服务成功, RequestId = " + this.Id, LogLevelType.System);
                                afterGetData(null, resultJo);
                            }
                            break;
                        default:
                            {
                                string msg = jo.GetValue("message").ToString();
                                Exception ex = new Exception("登录失败, " + msg);
                                AddLog("调用服务失败, 返回错误码 = " + code + ", 错误信息 = " + msg + ", RequestId = " + this.Id, LogLevelType.System);
                                afterGetData(ex, null);
                            }
                            break;
                    }
                }
            }
        }

        private void Logout()
        { 
            string requestUrl = SystemConfig.ServerRootUrl + "userNcpService/logout.action";
            JObject requestJo = new JObject(); 
            string fromData = "requestParam=" + CommonUtil.UrlEncode(requestJo.ToString());
            byte[] requestData = Encoding.UTF8.GetBytes(fromData);

            NDAWebClient webClient = this.CreateNewClient(); 
            this._RequestActive = true;
            webClient.UploadDataAsync(new Uri(requestUrl), "POST", requestData);             
        }

        private bool _RequestActive = false;

        private object _ResponseObject = null;

        private void AddLog(string msg, LogLevelType logLevel)
        {
            SystemConfig.SystemLogProcessor.AddLog(msg, logLevel);
        }
        
        private void webClient_UploadDataCompleted(object sender, UploadDataCompletedEventArgs e)
        {
            if (this._RequestActive)
            {
                NDAWebClient client = (NDAWebClient)sender;
                try
                {
                    if (e.Error == null)
                    {
                        byte[] bs = e.Result;
                        this._ResponseObject = bs;
                    }
                    else
                    {
                        this._ResponseObject = e.Error;
                    }
                }
                catch (Exception ex)
                {
                    this._ResponseObject = ex;
                }
                finally
                {
                }
            }
        }
    }
}
