using System.Web;
using System.Web.Mvc;

namespace NiceBytes.Veterinary
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
