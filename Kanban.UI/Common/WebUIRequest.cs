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

        protected override void OnPreLoad(EventArgs e)
        {
            FormWebUI = Request.Form;
        }

        protected override void OnLoad(EventArgs e)
        {
            //lleva a la pagina de donde se inicio la peticion
            //base.OnLoad(e);

            if (Request.Form != null && !string.IsNullOrEmpty(FormWebUI["action"]))
            {
                object resultMethod = new object();

                try
                {
                    //TODO: Problemas cuando hay un metodo sobrecargado.
                    MethodInfo methodInfo = GetType().GetMethod(FormWebUI["action"], 
                        BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy);

                    if (methodInfo != null)
                    {
                        resultMethod = methodInfo.Invoke(this, GetValueParameters(FormWebUI));
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                Response.Write(JsonConvert.SerializeObject(resultMethod));
                HttpContext.Current.Response.Flush();
                HttpContext.Current.Response.SuppressContent = true;
                //Response.Redirect("Login.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
            }
        }

        private object[] GetValueParameters(NameValueCollection form)
        {
            IEnumerable<string> keyParams = form.AllKeys.Where(x => x.EndsWith("_param"));
            if (keyParams != null)
            {
                return keyParams.Select(key => form.Get(key)).Cast<string>().ToArray();
            }

            return null;
        }
    }
}