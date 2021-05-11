using System.Web;
using System.Web.Mvc;

namespace Ejercicio6.MVC.Project
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
