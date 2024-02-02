using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class BarContext : DbContext
    {
        //creamos constructor que recibe conjunto de opciones que van a tener la conexion, esto se pasa al padre la conexion
        public BarContext(DbContextOptions<BarContext> options) : base(options) 
        {

        }

        public DbSet<Beer> Beers { get; set; }
        public DbSet<Brand> Brands { get; set; }

        //si no se quiere usar en plural en objetos se hace lo siguiente sobreescritura
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().ToTable("Brand");
            modelBuilder.Entity<Beer>().ToTable("Beer");

        }
    }
}
