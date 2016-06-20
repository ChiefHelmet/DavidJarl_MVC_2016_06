using System.Web;
using System.Web.Mvc;

namespace DavidJarl_MVC_2016_06
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
