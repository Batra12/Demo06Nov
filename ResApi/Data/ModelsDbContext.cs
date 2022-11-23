using Microsoft.EntityFrameworkCore;
using ResApi.Data.DbModels;

namespace ResApi.Data
{
    public class ModelsDbContext:DbContext
    {
        public ModelsDbContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<User> Users { get; set; }
    }
}
