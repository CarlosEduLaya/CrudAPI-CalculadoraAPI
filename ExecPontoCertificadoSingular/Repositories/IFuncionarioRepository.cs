using PontoCertificadoSingularExercicio.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExecPontoCertificadoSingular.Repositories
{
    public interface IFuncionarioRepository
    {
        Task<IEnumerable<Funcionario>> Get();

        Task<Funcionario> ConsultaFuncionario(int id);

        Task<Funcionario> Create(Funcionario funcionario);
        Task Update(Funcionario funcionario);

        Task Delete(int cpf);

    }
}
