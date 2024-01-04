using Domain.Commands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        [HttpPost("CadastrarVeiculo")]
        public IActionResult PostAsync([FromBody] VeiculoCommand Command)
        {
            return Ok();
        }
        public IActionResult SimularAluguel() 
        {
            return Ok();
        }
        public IActionResult Alugar()
        {
            return Ok();
        }
    }
}
