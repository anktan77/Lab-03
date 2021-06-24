using System.Web;
using System.Web.Mvc;

namespace NguyenDaoDuyTan_1811063479_Lab03
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
