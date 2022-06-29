using ExecPontoCertificadoSingular.Repositories;
using Microsoft.AspNetCore.Mvc;
using PontoCertificadoSingularExercicio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExecPontoCertificadoSingular.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        public readonly IFuncionarioRepository _funcionarioRepository;
        public FuncionarioController(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }
        [HttpGet]
        public async Task<IEnumerable<Funcionario>> GetFuncionarios()
        {
            return await _funcionarioRepository.Get();
        }

        [HttpGet("{cpf}")]
        public async Task<ActionResult<Funcionario>> ConsultaFuncionario(int cpf)
        {
            var funcionarios = await _funcionarioRepository.Get();
            int qtdFuncionarios = funcionarios.Count();
            var encontrou = funcionarios.Where(item => item.cpf == cpf).FirstOrDefault();

           if(encontrou == null)
            {
                return Ok("Não existe ninguem com esse cpf!");
            }
            else
            {
                return Ok(encontrou);
            }

        }

       

        [HttpPost]
        public async Task<ActionResult<Funcionario>> CadastroFuncionario([FromBody] Funcionario funcionario)
        {
            var newFuncionario = await _funcionarioRepository.Create(funcionario);
            return CreatedAtAction(nameof(GetFuncionarios), new {id = newFuncionario.id }, newFuncionario);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Funcionario>> Delete(int id)
        {
            var deleteFuncionario =  await _funcionarioRepository.ConsultaFuncionario(id);
            if(deleteFuncionario == null)
            {
                return NotFound();
            }
            await _funcionarioRepository.Delete(id);
            return NoContent();
        }

        
        
        [HttpPut]
        public async Task<ActionResult<Funcionario>> PutFuncionario(int id, [FromBody] Funcionario funcionario)
        {
            if(id != funcionario.id)
            {
                return BadRequest();
            }
                await _funcionarioRepository.Update(funcionario);
            return NoContent();
        }

    
    }

   
}
