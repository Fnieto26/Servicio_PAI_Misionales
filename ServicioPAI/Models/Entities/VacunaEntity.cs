namespace ServicioPAI.Models.Entities
{
    public class VacunaEntity
    {
        public int vac_id { get; set; }

        public string vac_Nombre { get; set; }

        public int grup_Id { get; set; }

        public int grup_Orden_vacuna { get; set; }

        public int dos_id { get; set; }

        public string dos_Nombre { get; set; }

        public DateTime vac_FechaVacuna { get; set; }

        public string Ins_nombre { get; set; }

        public string pos_nombre { get; set; }

        public int pos_Id { get; set; }

        public int vac_EdadVacunaAnios { get; set; }

        public int vac_EdadVacunaMeses { get; set; }

        public int vac_EdadVacunaDias { get; set; }

        public long per_Consecutivo { get; set; }

        public int pse_Id { get; set; }

        public int com_Id { get; set; }

        public string com_nombre { get; set; }

        public string grup_nombre { get; set; }

        public string Pse_Nombre { get; set; }
    }
}
