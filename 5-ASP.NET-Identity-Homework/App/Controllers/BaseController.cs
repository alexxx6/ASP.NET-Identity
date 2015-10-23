using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.AspNet.Identity;
using Models;
using Repositories.Contracts;

namespace App.Controllers
{
    public abstract class BaseController : Controller
    {
        private readonly IAppData data;
        private User user;

        protected BaseController(IAppData data)
        {
            this.data = data;
        }

        protected IAppData Data
        {
            get { return this.data; }
        }

        public User CurrUser
        {
            get { return user; }
            private set { this.user = value; }
        }

        protected override IAsyncResult BeginExecute(RequestContext requestContext, AsyncCallback callback, object state)
        {
            if (requestContext.HttpContext.User.Identity.IsAuthenticated)
            {
                var currUserId = requestContext.HttpContext.User.Identity.GetUserId();
                var currUser = this.Data.Users.All().FirstOrDefault(u => u.Id == currUserId);
                this.CurrUser = currUser;
            }

            return base.BeginExecute(requestContext, callback, state);
        }
    }
}
