using System.Web;
using System.Web.Mvc;

namespace SCGREEN_Web_Union.com
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
