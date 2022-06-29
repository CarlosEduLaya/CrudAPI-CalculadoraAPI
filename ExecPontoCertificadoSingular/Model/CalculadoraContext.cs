using ExecPontoCertificadoSingular.Model;
using Microsoft.EntityFrameworkCore;

namespace PontoCertificadoSingularExercicio.Model
{
    public class CalculadoraContext : DbContext
    {
        public CalculadoraContext(DbContextOptions<CalculadoraContext> options) : base(options)
        {
            bool v = Database.EnsureCreated();
        }

        public DbSet<CalculadoraDTO> Calculadoras { get; set; }
    }
}
