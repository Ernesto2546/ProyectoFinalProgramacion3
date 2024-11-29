using ProyectoFinal.Models;
using Microsoft.EntityFrameworkCore;

namespace ProyectoFinal
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

       
        public DbSet<ProyectoFinal.Models.INVCONTEO> INVCONTEO { get; set; } = default!;
    }
}
