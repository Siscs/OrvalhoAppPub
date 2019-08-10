using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OrvalhoApp.Domain.Models;
using OrvalhoApp.Infra.Data.Mappings;

namespace OrvalhoApp.Infra.Data.Contexto
{
    public class OrvalhoContext : DbContext, IOrvalhoContext
    {
        public DbSet<UnidadeMedida> UnidadeMedidas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        public OrvalhoContext()
        {
        }

        public OrvalhoContext(DbContextOptions<OrvalhoContext> options) 
            : base(options)
        {
  
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new UnidadeMedidaMap());
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder ) {
             builder.UseSqlServer(@"server=localhost;Database=ORVALHO;User=cesar;pwd=ryan123");


            // // get the configuration from the app settings
            // var config = new ConfigurationBuilder()
            //     .SetBasePath(Directory.GetCurrentDirectory())
            //     .AddJsonFile("appsettings.json")
            //     .Build();
            
            // // define the database to use
            // optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));

        }

        // em startup.cs
        // services.AddDbContext<OrvalhoContext>(options => { 
        //     options.UseSqlServer(Configuration.GetConnectionString("SqlServer"));
        // } );
        
    }
}