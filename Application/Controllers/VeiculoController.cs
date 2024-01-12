using Domain.Commands;
using Domain.NovaPasta;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        private readonly IVeiculoService _veiculoservice;
        private object command;

        public VeiculoController(IVeiculoService veiculoservice)
        {
            _veiculoservice = veiculoservice;
        }

        [HttpPost]
        [Route("CadastrarVeiculo")]
        public async Task<IActionResult> PostAsync([FromBody] VeiculoCommand command)
        {
            
            return Ok(await _veiculoservice.PostAsync(command));
        }
        [HttpGet]
        [Route("SimularAluguel")]
        public IActionResult GetAsync() 
        {
            return Ok();
        }
        [HttpPost]
        [Route("Alugar")]
        public IActionResult PostAsync()
        {
            return Ok();
        }
    }
}
