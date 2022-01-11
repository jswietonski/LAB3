using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace LAB3
{
    public class Global : System.Web.HttpApplication
    {
        public object SESSION { get; private set; }

        protected void Application_Start(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            DbManager.UPDATEdisactiveAll(dc);
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["RegUser"] = "";            
            
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            Debug.WriteLine("Zmniejszam licznik");
            DbManager.UPDATEdisactive(dc, Session["RegUser"].ToString());
        }

        protected void Application_End(object sender, EventArgs e)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            DbManager.UPDATEdisactiveAll(dc);
        }
    }
}