using System.Web.Mvc;
using App.Models.Users;
using AutoMapper;
using Repositories.Contracts;

namespace App.Areas.Admin.Controllers
{
    public class HomeController : AdminBaseController
    {
        public HomeController(IAppData data)
            : base(data)
        {
        }

        // GET: User
        public ActionResult Show()
        {
            var userModel = Mapper.Map<UserViewModelMinified>(base.CurrUser);

            return View(userModel);
        }
    }
}