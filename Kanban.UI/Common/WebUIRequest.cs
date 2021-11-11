using Kanban.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;

namespace Kanban.UI.Common
{
    public class WebUIRequest : Page
    {
        protected NameValueCollection FormWebUI { get; set; }
        private readonly ResponseClient _responseClient;
        protected string RedirectClient { get; set; }

        public WebUIRequest()
        {
            _responseClient = new ResponseClient();
        }

        protected override void OnPreLoad(EventArgs e)
        {
            FormWebUI = Request.Form;
        }
        
        protected override void OnLoad(EventArgs e)
        {
            try
            {
                if (Request.Form != null && !string.IsNullOrEmpty(FormWebUI["action"]))
                {
                    //TODO: Problemas cuando hay un metodo sobrecargado.
                    //TODO: Objeto response para retornar las respuestas del sistema
                    MethodInfo methodInfo = GetType().GetMethod(FormWebUI["action"],
                        BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy);

                    if (methodInfo != null)
                    {
                        
                    }

                    _responseClient.ResultMethod = methodInfo.Invoke(this, GetValueParameters(FormWebUI));
                    _responseClient.Code = _responseClient.ResultMethod == null ? 1100 : 1000;
                    _responseClient.StringCode = "success";
                    _responseClient.Redirect = RedirectClient;

                    ResponseClient(JsonConvert.SerializeObject(_responseClient));
                }
                else
                {
                    base.OnLoad(e);
                }
            }
            catch (Exception ex)
            {
                _responseClient.StringCode = "error";

                if (ex.InnerException != null)
                {
                    _responseClient.Message = ex.InnerException.Message;
                    //_responseClient.StackTrace = ex.InnerException.StackTrace;
                    _responseClient.Code = 2000;
                }
                else
                {
                    _responseClient.Message = ex.Message;
                    _responseClient.Code = 3000;
                    //_responseClient.StackTrace = ex.StackTrace;
                }

                ResponseClient(JsonConvert.SerializeObject(_responseClient));
            }
        }

        protected void ResponseClient(object response)
        {
            
            HttpContext.Current.Response.Write(response);
            HttpContext.Current.Response.Flush();
            HttpContext.Current.Response.SuppressContent = true;
            Context.ApplicationInstance.CompleteRequest();
        }

        private object[] GetValueParameters(NameValueCollection form)
        {
            IEnumerable<string> keyParams = form.AllKeys.Where(x => x.EndsWith("_param"));
            if (keyParams != null)
            {
                return keyParams.Select(key => form.Get(key)).Cast<string>().ToArray();
            }

            return new object[] { };
        }
    }
}