using Microsoft.AspNetCore.Mvc;
using RegistrodeTecnico.Components.Models;
using RegistrodeTecnico.Services;

namespace RegistrodeTecnico.Controllers
{ 
    [Route("api/[controller]")]
    [ApiController]
    public class TipoTecnicoController : ControllerBase
    {
        private readonly TipoTecnicoService _tipoTecnicoService;

        public TipoTecnicoController(TipoTecnicoService tipoTecnicoService)
        {
            _tipoTecnicoService = tipoTecnicoService;
        }

        [HttpGet]
        public async Task<IEnumerable<TipoTecnico>> GetTiposTecnicos()
        {
            return await _tipoTecnicoService.GetTiposTecnicos();
        }

        [HttpPost]
        public async Task AddTipoTecnico([FromBody] TipoTecnico tipoTecnico)
        {
            await _tipoTecnicoService.AddTipoTecnico(tipoTecnico);
        }

        [HttpPut("{tipoId}")]
        public async Task UpdateTipoTecnico([FromBody] TipoTecnico tipoTecnico, [FromRoute] int tipoId)
        {
            tipoTecnico.TipoId = tipoId;
            await _tipoTecnicoService.UpdateTipoTecnico(tipoTecnico);
        }

        [HttpDelete("{tipoId}")]
        public async Task DeleteTipoTecnico([FromRoute] int tipoId)
        {
            await _tipoTec;
        }



            

    }
