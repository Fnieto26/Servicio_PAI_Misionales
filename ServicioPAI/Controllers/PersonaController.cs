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

        [HttpGet("seleccionarPersonaBusqueda")]

        public async Task<IEnumerable<PersonaResponseDTO>> seleccionarPersonaBusquedaAttr(SeleccionarPersonaBusquedaAttrRequestDTO requestDTO)
        {
            return personaService.seleccionarPersonaBusquedaAttr(requestDTO);
        }
    }
}
