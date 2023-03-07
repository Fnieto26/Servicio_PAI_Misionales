namespace ServicioPAI.Repository.Entities

{
    public class PersonaEntity
    {
        private long per_Consecutivo { get; set; }

        private string per_TipoId { get; set; }

        private string per_Id { get; set; }

        private string per_CertNacVivo { get; set; }

        private string per_CertDefuncion { get; set; }

        private string per_TipoIdM { get; set; }

        private string per_IdM { get; set; }

        private short per_NumeroHijoM { get; set; }

        private string primerApellido { get; set; }

        private string segundoApellido { get; set; }

        private string primerNombre { get; set; }

        private string segundoNombre { get; set; }

        private string primerApellidoM { get; set; }

        private string segundoApellidoM { get; set; }

        private string primerNombreM { get; set; }

        private string segundoNombreM { get; set; }

        private DateTime perFechaNac { get; set; }

        private string per_parInstitucion { get; set; }

        private DateTime per_FechaAlm { get; set; }

        private string per_Func { get; set; }

        private string per_Institucion { get; set; }

        private int per_Estado { get; set; }

        private int cni_id { get; set; }

        private short etn_idEtnia { get; set; }

        private string gru_IdGrupo { get; set; }

        private string per_Genero { get; set; }

        private string perGrupoSanguineo { get; set; }

        private string perRh { get; set; }

        private int per_causaNoVacuna { get; set; }

        private long per_ConsecutivoM { get; set; }

        private string hisDocumentJson { get; set; }

        private string pes_Peso { get; set; }
    }
}
