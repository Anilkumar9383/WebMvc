using Microsoft.EntityFrameworkCore;
using FirstWebMvc.Models;

namespace FirstWebMvc.Models
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions options)
            : base(options) 
        {

        }
        public DbSet<LoginData> LoginData { get; set; }
        public DbSet<SignUpData> SignUpData { get; set; }
    }
}
