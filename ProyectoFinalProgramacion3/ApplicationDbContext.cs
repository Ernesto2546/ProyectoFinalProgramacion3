using Microsoft.EntityFrameworkCore;
using ProyectoFinalProgramacion3.Models;

namespace ProyectoFinalProgramacion3
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<INVCONTEO> INVCONTEO { get; set; }
    }
}
