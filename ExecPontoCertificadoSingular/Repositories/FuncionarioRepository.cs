using Microsoft.EntityFrameworkCore;
using PontoCertificadoSingularExercicio.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExecPontoCertificadoSingular.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        public readonly FuncionarioContext _context;
        public FuncionarioRepository(FuncionarioContext context)
        {
            _context = context;
        }
        public async Task<Funcionario> Create(Funcionario funcionario)
        {
            _context.Funcionarios.Add(funcionario);
           await _context.SaveChangesAsync();
            return funcionario;
        }

        public async Task Delete(int id)
        {
            var funcionarioDelete = await _context.Funcionarios.FindAsync(id);
            _context.Funcionarios.Remove(funcionarioDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Funcionario>> Get()
        {
          return  await _context.Funcionarios.ToListAsync();
        }

        public async Task<Funcionario> ConsultaFuncionario(int id)
        {
          return await _context.Funcionarios.FindAsync(id);

        }

        public async Task Update(Funcionario funcionario)
        {
            _context.Entry(funcionario).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
