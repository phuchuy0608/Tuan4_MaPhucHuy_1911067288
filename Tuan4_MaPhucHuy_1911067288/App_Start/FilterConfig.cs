using System.Web;
using System.Web.Mvc;

namespace Tuan4_MaPhucHuy_1911067288
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
