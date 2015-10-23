using Microsoft.AspNet.Identity.EntityFramework;
using Models;

namespace Repositories.Contracts
{
    public interface IAppData
    {
        IRepository<User> Users { get; }

        IRepository<IdentityRole> UserRoles { get; }

        int SaveChanges();
    }
}
