using Microsoft.AspNetCore.Mvc;
using ServicioPAI.commons.Dto;
using ServicioPAI.Service.Persona;

namespace ServicioPAI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class PersonaController : Controller
    {
        private readonly IPersonaService personaService;

        public PersonaController(IPersonaService personaService)
        {
            this.personaService = personaService;
        }

        [HttpGet("seleccionarPersonaBusqueda")]
        public async Task<IEnumerable<PersonaResponseDTO>> seleccionarPersonaBusqueda(seleccionarPersonaBusquedaRequestDTO requestDTO)
        {
            return personaService.seleccionarPersonaBusqueda(requestDTO);

        }

        [HttpGet("seleccionarPersonaBusquedaAttr")]

        public async Task<IEnumerable<PersonaResponseDTO>> seleccionarPersonaBusquedaAttr(SeleccionarPersonaBusquedaAttrRequestDTO requestDTO)
        {
            return personaService.seleccionarPersonaBusquedaAttr(requestDTO);
        }

        [HttpGet("SeleccionarVacunasPersona")]
        public async Task<VacunaResponseDTO> SeleccionarVacunasPersona(long per_Consecutivo)
        {
            return await personaService.seleccionarVacunasPersona(per_Consecutivo);
        }

        [HttpGet("seleccionarUbicacionPersona")]
        public async Task<VacunaResponseDTO> seleccionarUbicacionPersona(long per_Consecutivo)
        {
            return await personaService.seleccionarUbicacionPersona(per_Consecutivo);

        }
        [HttpGet("seleccionarAfiliacionPersona")]
        public async Task<AfiliacionPersonaResponseDTO> seleccionarAfiliacionPersona(long per_Consecutivo)
        {
            return await personaService.seleccionarAfiliacionPersona(per_Consecutivo);

        }
        
    }
}
