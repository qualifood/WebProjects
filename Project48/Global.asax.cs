using System;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using C1.C1Pdf;

namespace Project48
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var p = new C1PdfDocument();
            Console.WriteLine(p);
            
            AreaRegistration.RegisterAllAreas();
        }
    }
}