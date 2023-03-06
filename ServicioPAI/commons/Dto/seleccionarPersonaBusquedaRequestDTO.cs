namespace ServicioPAI.commons.Dto
{
    public class seleccionarPersonaBusquedaRequestDTO
    {
        public String TipoIdVacunado { get; set; }
        public String NumeroIdVacunado { get; set; }
        public String PrimerNombreVacunado { get; set; }
        public String SegundoNombreVacunado { get; set; }
        public String PrimerApellidoVacunado { get; set; }
        public String SegundoApellidoVacunado { get; set; }
        public String per_parInstitucion { get; set; }
        public DateTime per_FechaNac { get; set; }
        public String TipoIdentificacionMadre { get; set; }
        public String NumeroIdentificacionMadre { get; set; }
        public String PrimerNombreMadre { get; set; }
        public String SegundoNombreMadre { get; set; }
        public String PrimerApellidoMadre { get; set; }
        public String SegundoApellidoMadre { get; set; }
        public int GrupoEtareo { get; set; }
    }
}
