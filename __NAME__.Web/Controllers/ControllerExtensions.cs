using System.Web.Mvc;

namespace __NAME__.Web.Controllers
{
    public static class ControllerExtensions
    {
        public static void Attention(this Controller controller, string message)
        {
            controller.TempData.Add(Alerts.ATTENTION, message);
        }

        public static void Success(this Controller controller, string message)
        {
            controller.TempData.Add(Alerts.SUCCESS, message);
        }

        public static void Information(this Controller controller, string message)
        {
            controller.TempData.Add(Alerts.INFORMATION, message);
        }

        public static void Error(this Controller controller, string message)
        {
            controller.TempData.Add(Alerts.ERROR, message);
        }
    }
}