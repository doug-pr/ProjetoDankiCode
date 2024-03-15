using Microsoft.EntityFrameworkCore;
using ProjetoDankiCode.Models;

namespace ProjetoDankiCode.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { 
        }
        public DbSet<Usuario> Usuario {  get; set; }
    }
}
