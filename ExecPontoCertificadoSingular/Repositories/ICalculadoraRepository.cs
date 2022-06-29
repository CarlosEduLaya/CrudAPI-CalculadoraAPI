using ExecPontoCertificadoSingular.Model;
using PontoCertificadoSingularExercicio.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExecPontoCertificadoSingular.Repositories
{
    public interface ICalculadoraRepository
    {
        Task<IEnumerable<CalculadoraDTO>> Get();

        Task<CalculadoraDTO> Create(CalculadoraDTO calculadora);

    }
}
