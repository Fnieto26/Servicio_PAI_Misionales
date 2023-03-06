using ServicioPAI.commons.Dto;

namespace ServicioPAI.Service.Persona
{
    public interface IPersonaService
    {
        IEnumerable<PersonaResponseDTO> seleccionarPersonaBusqueda(seleccionarPersonaBusquedaRequestDTO requestDTO);
        IEnumerable<PersonaResponseDTO> seleccionarPersonaBusquedaAttr(SeleccionarPersonaBusquedaAttrRequestDTO requestDTO);        

    }
}
