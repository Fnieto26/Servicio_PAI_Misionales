namespace ServicioPAI.Models.Entities
{
    public class UbicacionEntity
    {
        public long per_Consecutivo;

        public string dir_Direccion { get; set; }

        public string bar_Id { get; set; }

        public string bar_Nombre { get; set; }

        public int upz_Id { get; set; }

        public string upz_Nombre { get; set; }

        public int loc_id { get; set; }

        public string loc_Nombre { get; set; }

        public string dir_Codigo_direccion { get; set; }

        public string dir_CoordenadaX { get; set; }

        public string dir_CoordenadaY { get; set; }

        public string dir_Estrato { get; set; }

        public int nac_mun_id { get; set; }

        public int nac_dep_Id { get; set; }

        public string nac_pais_Id { get; set; }

        public int dir_mun_id { get; set; }

        public int dir_dep_Id { get; set; }

        public string dir_pais_Id { get; set; }

        public int dir_zon_Id { get; set; }

        public string tel_Telefono { get; set; }

        public string tel_Contacto { get; set; }

        public string cor_correo { get; set; }

        public DateTime Fecha { get; set; }

        public bool Activo { get; set; }
    }
}
