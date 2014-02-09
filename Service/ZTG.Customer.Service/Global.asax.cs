using System;
using System.Web;
using Customers.Service;
using ServiceStack.MiniProfiler;

namespace ZTG.Customer.Service
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            new CustomerAppHost().Init();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            if (Request.IsLocal)
            {
                Profiler.Start();
            }
        }

        protected void Application_End(object sender, EventArgs e)
        {
            Profiler.Stop();
        }
    }
}