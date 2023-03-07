using ServicioPAI.commons.Dto;

namespace ServicioPAI.Service.Persona
{
    public interface IPersonaService
    {
        IEnumerable<PersonaResponseDTO> seleccionarPersonaBusqueda(seleccionarPersonaBusquedaRequestDTO requestDTO);
        IEnumerable<PersonaResponseDTO> seleccionarPersonaBusquedaAttr(SeleccionarPersonaBusquedaAttrRequestDTO requestDTO);
        Task<VacunaResponseDTO> seleccionarVacunasPersona(long per_Consecutivo);
        Task<VacunaResponseDTO> seleccionarUbicacionPersona(long per_Consecutivo);
        Task<AfiliacionPersonaResponseDTO> seleccionarAfiliacionPersona(long per_Consecutivo);
        Task<TablaDominioResponseDTO> seleccionarTablaDominio(short id_Tabla);

    }
}
