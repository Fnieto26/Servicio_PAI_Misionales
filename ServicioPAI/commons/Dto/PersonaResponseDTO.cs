namespace ServicioPAI.commons.Dto
{
    public class PersonaResponseDTO
    {
        public long PerConsecutivo { get; set; }
        public string PerTipoId { get; set; }
        public string PerId { get; set; }
        public string PerCertNacVivo { get; set; }
        public string PerCertDefuncion { get; set; }
        public string PerTipoIdM { get; set; }
        public string PerIdM { get; set; }
        public short PerNumeroHijoM { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellidoM { get; set; }
        public string SegundoApellidoM { get; set; }
        public string PrimerNombreM { get; set; }
        public string SegundoNombreM { get; set; }
        public DateTime PerFechaNac { get; set; }
        public string PerParInstitucion { get; set; }
        public DateTime PerFechaAlm { get; set; }
        public string PerFunc { get; set; }
        public string PerInstitucion { get; set; }
        public int PerEstado { get; set; }
        public int CniId { get; set; }
        public short EtnIdEtnia { get; set; }
        public string GruIdGrupo { get; set; }
        public string PerGenero { get; set; }
        public string PerGrupoSanguineo { get; set; }
        public string PerRh { get; set; }
        public int PerCausaNoVacuna { get; set; }
        public long PerConsecutivoM { get; set; }
        public string HisDocumentJson { get; set; }
        public string PesPeso { get; set; }
    }
}
