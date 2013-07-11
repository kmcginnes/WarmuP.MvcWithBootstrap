using System.Web.Mvc;

namespace __NAME__.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            "FilterConfig".Log().Info(() => "Registering MVC filters");
            filters.Add(new HandleErrorAttribute());
            "FilterConfig".Log().Info(() => "HandleError filter registered successfully");
        }
    }
}