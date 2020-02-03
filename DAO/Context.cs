using Microsoft.EntityFrameworkCore;

namespace testes_crud
{
    public class PessoasContext : DbContext
    {
        public DbSet<Models.Pessoa> Pessoas { get; set; }

        public PessoasContext(DbContextOptions<PessoasContext> options) :
            base(options)
        {
        }

    }
}