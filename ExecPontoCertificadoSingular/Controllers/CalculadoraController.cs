using ExecPontoCertificadoSingular.Model;
using ExecPontoCertificadoSingular.Repositories;
using Microsoft.AspNetCore.Mvc;
using PontoCertificadoSingularExercicio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExecPontoCertificadoSingular.Controllers
{
    [Route("api/calculadora/controller")]
    [ApiController]
    public class CalculadoraController : ControllerBase
    {
        public readonly ICalculadoraRepository _calculadoraRepository;
        public CalculadoraController(ICalculadoraRepository calculadoraRepository)
        {
            _calculadoraRepository = calculadoraRepository;
        }
        [HttpGet]
        public async Task<IEnumerable<CalculadoraDTO>> GetCalculadoras()
        {
            return await _calculadoraRepository.Get();
        }

        

       

        [HttpPost]
        public async Task<ActionResult<Calculadora>> CadastroCalculadora([FromBody] Calculadora calculadora)
        {
            var primeiraParte = calculadora.primeiraParte;
            var segundaParte = calculadora.segundaParte;
            decimal resultadoOperacao = 0;
            if (calculadora.operacao == "*")
            {
                 resultadoOperacao = primeiraParte * segundaParte;
            }
            else if (calculadora.operacao == "/")
            {
                 resultadoOperacao = primeiraParte / segundaParte;

            }
            else if (calculadora.operacao == "-")
            {
                 resultadoOperacao = primeiraParte - segundaParte;

            }
            else if(calculadora.operacao == "+") 
            {
                 resultadoOperacao = primeiraParte + segundaParte;

            }
            else
            {
                resultadoOperacao = 0;
            }
            
            CalculadoraDTO CalculadoraDTO = new CalculadoraDTO();
            CalculadoraDTO.resultado = $"{primeiraParte}{calculadora.operacao}{segundaParte}={resultadoOperacao}";
            var newCalculadora = await _calculadoraRepository.Create(CalculadoraDTO);
            return CreatedAtAction(nameof(GetCalculadoras), new {id = newCalculadora.id }, newCalculadora);
        }

     
        
    

    
    }

   
}
