using ExecPontoCertificadoSingular.Model;
using Microsoft.EntityFrameworkCore;
using PontoCertificadoSingularExercicio.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExecPontoCertificadoSingular.Repositories
{
    public class CalculadoraRepository : ICalculadoraRepository
    {
        public readonly CalculadoraContext _context;
        public CalculadoraRepository(CalculadoraContext context)
        {
            _context = context;
        }
        public async Task<CalculadoraDTO> Create(CalculadoraDTO calculadora)
        {
            _context.Calculadoras.Add(calculadora);
            await _context.SaveChangesAsync();
            return calculadora;
        }


        public async Task<IEnumerable<CalculadoraDTO>> Get()
        {
            return await _context.Calculadoras.ToListAsync();
        }
    }
       
}
