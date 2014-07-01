using System.Web;
using System.Web.Mvc;

namespace Makale.MVC.Session
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
