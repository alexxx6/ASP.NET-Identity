using System.Web.Mvc;
using App.Models.Users;
using AutoMapper;
using Repositories.Contracts;

namespace App.Controllers
{
    [Authorize]
    public class UserController : BaseController
    {
        public UserController(IAppData data)
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