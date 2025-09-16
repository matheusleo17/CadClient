using CadClient.Application.Services;
using CadClient.Domain.Entities;
using CadClient.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CadClient.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly ClientService _service;
        public ClientController(ClientService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> InsertClient(Client client)
        {
            
                var result = await _service.AddClientAsync(client);
                if(result.Success== false)
                {
                    return BadRequest(result.ErrorMessage);
                }

                return Ok(result.Data);
           

        }



        [HttpGet("cpf/{cpf}")]
        public async Task<IActionResult> GetUserByCpf(string cpf)
        {
            
                var result = await _service.GetClientByCpfAsync(cpf);
                if (result.Success == false)
                {
                    return NotFound(result.ErrorMessage);
                }

                return Ok(result.Data);
               
           
        }
    }
}
