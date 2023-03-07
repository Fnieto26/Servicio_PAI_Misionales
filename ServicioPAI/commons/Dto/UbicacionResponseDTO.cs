namespace ServicioPAI.commons.Dto
{
    public class UbicacionResponseDTO
    {
        public long _per_Consecutivo;

        public string _dir_Direccion { get; set; }

        public string _bar_Id { get; set; }

        public string _bar_Nombre { get; set; }

        public int _upz_Id { get; set; }

        public string _upz_Nombre { get; set; }

        public int _loc_id { get; set; }

        public string _loc_Nombre { get; set; }

        public string _dir_Codigo_direccion { get; set; }

        public string _dir_CoordenadaX { get; set; }

        public string _dir_CoordenadaY { get; set; }

        public string _dir_Estrato { get; set; }

        public int _nac_mun_id { get; set; }

        public int _nac_dep_Id { get; set; }

        public string _nac_pais_Id { get; set; }

        public int _dir_mun_id { get; set; }

        public int _dir_dep_Id { get; set; }

        public string _dir_pais_Id { get; set; }

        public int _dir_zon_Id { get; set; }

        public string _tel_Telefono { get; set; }

        public string _tel_Contacto { get; set; }

        public string _cor_correo { get; set; }

        public DateTime _Fecha { get; set; }

        public bool _Activo { get; set; }
    }
}
