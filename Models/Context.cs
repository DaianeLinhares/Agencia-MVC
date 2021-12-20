using Microsoft.EntityFrameworkCore;

namespace AgenciaComBack.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Cliente> cliente { get; set; }
        public DbSet<Destino> destino { get; set; }
        public DbSet<Contato> contato { get; set; }
    }
    
}
