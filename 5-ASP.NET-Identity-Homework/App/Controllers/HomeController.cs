using System.Web.Mvc;
using Repositories.Contracts;

namespace App.Controllers
{
    public class HomeController : BaseController
    {

        public HomeController(IAppData data)
            : base(data)
        {
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}