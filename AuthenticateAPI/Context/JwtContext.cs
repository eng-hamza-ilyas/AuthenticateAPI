using AuthenticateAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace AuthenticateAPI.Context
{
    public class JwtContext : DbContext
    {
        public JwtContext(DbContextOptions<JwtContext> options) : base(options) 
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Employe> Employees { get; set; }
    }
}
