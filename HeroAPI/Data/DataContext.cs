using Microsoft.EntityFrameworkCore;

namespace HeroAPI.Data
{
    public class DataContext : DbContext
    {
        //Aqui faremos a injeção de contexto para que possamos acessar as informações dos heróis no banco de dados

        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Hero> Heroes { get; set; }


    }
}
