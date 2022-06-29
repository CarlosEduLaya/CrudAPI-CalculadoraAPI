using ExecPontoCertificadoSingular.Model;
using Microsoft.EntityFrameworkCore;

namespace PontoCertificadoSingularExercicio.Model
{
    public class FuncionarioContext : DbContext
    {
        public FuncionarioContext(DbContextOptions<FuncionarioContext> options) : base(options)
        {
            bool v = Database.EnsureCreated();
        }

        public DbSet<Funcionario> Funcionarios { get; set; }

    }
}
