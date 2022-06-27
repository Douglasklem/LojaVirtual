using DkSoftware.LojaVirtual.Dominio.Repository;
using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Routing;

namespace DkSoftware.LojaVirtual.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);            
        }
    }
}
