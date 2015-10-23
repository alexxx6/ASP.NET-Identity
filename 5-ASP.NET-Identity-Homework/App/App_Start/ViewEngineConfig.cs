using System.Web.Mvc;

namespace App.App_Start
{
    public class ViewEngineConfig
    {
        public static void RegisterViewEngines(ViewEngineCollection engines)
        {
            engines.Clear();
            engines.Add(new RazorViewEngine());
        }
    }
}