using CustomLoginAndRole.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CustomLoginAndRole.Data
{
    public class AppDbContext : IdentityDbContext<Users>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
