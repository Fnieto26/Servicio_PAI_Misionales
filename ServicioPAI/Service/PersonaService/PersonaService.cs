using ServicioPAI.commons.Dto;
using ServicioPAI.Models.Entities;
using ServicioPAI.Repository.Entities;
using ServicioPAI.Service.LogService;
using System.Data;
using System.Data.SqlClient;
using System;
namespace ServicioPAI.Service.Persona
{
    public class PersonaService : IPersonaService
    {
        private readonly ILogService logService;

        public PersonaService(ILogService logService)
        {
            this.logService = logService;
        }
        public IEnumerable<PersonaResponseDTO> seleccionarPersonaBusqueda(seleccionarPersonaBusquedaRequestDTO requestDTO)
        {
            SqlParameter[] arParms = new SqlParameter[1];
            arParms[0] = new SqlParameter("@NumeroIdVacunado", 3);
            arParms[0].Value = requestDTO.NumeroIdVacunado;

            logService.InsertarLog("seleccionarPersonaBusqueda()", "CORRECTO", arParms);

            throw new NotImplementedException();
        }

        public IEnumerable<PersonaResponseDTO> seleccionarPersonaBusquedaAttr(SeleccionarPersonaBusquedaAttrRequestDTO requestDTO)
        {
            string connectionString = "Data Source=myServerAddress;Initial Catalog=myDataBase;User Id=myUsername;Password=myPassword;";

            SqlParameter[] arParms = new SqlParameter[15];

            arParms[0] = new SqlParameter("@TipoIdVacunado", 3);
            if (string.IsNullOrEmpty(requestDTO.TipoIdVacunado))
            {
                arParms[0].Value = DBNull.Value;
            }
            else
            {
                arParms[0].Value = requestDTO.TipoIdVacunado;
            }

            arParms[1] = new SqlParameter("@NumeroIdVacunado", 22);
            if (string.IsNullOrEmpty(requestDTO.NumeroIdVacunado))
            {
                arParms[0].Value = DBNull.Value;
            }
            else
            {
                arParms[0].Value = requestDTO.NumeroIdVacunado;
            }

            arParms[2] = new SqlParameter("@PrimerNombreVacunado", 22);
            if (string.IsNullOrEmpty(requestDTO.PrimerNombreVacunado))
            {
                arParms[0].Value = DBNull.Value;
            }
            else
            {
                arParms[0].Value = requestDTO.PrimerNombreVacunado;
            }

            arParms[3] = new SqlParameter("@SegundoNombreVacunado", 22);
            if (string.IsNullOrEmpty(requestDTO.SegundoNombreVacunado))
            {
                arParms[0].Value = DBNull.Value;
            }
            else
            {
                arParms[0].Value = requestDTO.SegundoNombreVacunado;
            }

            arParms[4] = new SqlParameter("@PrimerApellidoVacunado", 22);
            if (string.IsNullOrEmpty(requestDTO.PrimerApellidoVacunado))
            {
                arParms[0].Value = DBNull.Value;
            }
            else
            {
                arParms[0].Value = requestDTO.PrimerApellidoVacunado;
            }

            arParms[4] = new SqlParameter("@SegundoApellidoVacunado", 22);
            if (string.IsNullOrEmpty(requestDTO.SegundoApellidoVacunado))
            {
                arParms[4].Value = DBNull.Value;
            }
            else
            {
                arParms[4].Value = requestDTO.SegundoApellidoVacunado;
            }

            arParms[5] = new SqlParameter("@per_parInstitucion", 3);
            if (string.IsNullOrEmpty(requestDTO.per_parInstitucion))
            {
                arParms[5].Value = System.DBNull.Value;
            }
            else
            {
                arParms[5].Value = requestDTO.per_parInstitucion;
            }

            arParms[6] = new SqlParameter("@per_FechaNac", 31);
            arParms[6].Value = requestDTO.per_FechaNac;

            arParms[7] = new SqlParameter("@TipoIdentificacionMadre", 3);
            if (string.IsNullOrEmpty(requestDTO.TipoIdentificacionMadre))
            {
                arParms[7].Value = System.DBNull.Value;
            }
            else
            {
                arParms[7].Value = requestDTO.TipoIdentificacionMadre;
            }

            ///
            arParms[8] = new SqlParameter("@NumeroIdentificacionMadre", 22);
            if (string.IsNullOrEmpty(requestDTO.NumeroIdentificacionMadre))
            {
                arParms[8].Value = System.DBNull.Value;
            }
            else
            {
                arParms[8].Value = requestDTO.NumeroIdentificacionMadre;
            }

            arParms[9] = new SqlParameter("@PrimerNombreMadre", 22);
            if (string.IsNullOrEmpty(requestDTO.PrimerNombreMadre))
            {
                arParms[9].Value = System.DBNull.Value;
            }
            else
            {
                arParms[9].Value = requestDTO.PrimerNombreMadre;
            }

            arParms[10] = new SqlParameter("@SegundoNombreMadre", 22);
            if (string.IsNullOrEmpty(requestDTO.SegundoNombreMadre))
            {
                arParms[10].Value = System.DBNull.Value;
            }
            else
            {
                arParms[10].Value = requestDTO.SegundoNombreMadre;
            }

            arParms[11] = new SqlParameter("@PrimerApellidoMadre", 22);
            if (string.IsNullOrEmpty(requestDTO.PrimerApellidoMadre))
            {
                arParms[11].Value = System.DBNull.Value;
            }
            else
            {
                arParms[11].Value = requestDTO.PrimerApellidoMadre;
            }

            arParms[12] = new SqlParameter("@SegundoApellidoMadre", 22);
            if (string.IsNullOrEmpty(requestDTO.SegundoApellidoMadre))
            {
                arParms[12].Value = System.DBNull.Value;
            }
            else
            {
                arParms[12].Value = requestDTO.SegundoApellidoMadre;
            }

            arParms[13] = new SqlParameter("@grupoEtareo", 8);
            arParms[13].Value = requestDTO.GrupoEtareo;


            PersonaEntity personas = new PersonaEntity();
            return null;
        }

        public Task<VacunaResponseDTO> seleccionarVacunasPersona(long per_Consecutivo)
        {
            string cadena = "CADENA DE CONEXION"; // My.Settings.cadenaPai20
            //resultadoConsultaEntity oResultado = new resultadoConsultaEntity();

            SqlParameter[] arParms = new SqlParameter[1];
            arParms[0] = new SqlParameter("@per_Consecutivo", 0);
            arParms[0].Value = per_Consecutivo;

            DataSet dsVacuna = SqlHelper.ExecuteDataset(cadena, "pa_SeleccionarVacunasPersona", arParms);
            VacunaEntity vacunas = new VacunaEntity();
            foreach (DataRow dr in dsVacuna.Tables[0].Rows)
            {
                VacunaEntity vacuna = new VacunaEntity();
                vacuna.vac_id = Convert.ToInt32(dr["vac_Id"]);
                vacuna.dos_id = Convert.ToInt32(dr["dos_Id"]);
                vacuna.vac_FechaVacuna = Convert.ToDateTime(dr["vac_FechaVacuna"]);

                if (!dr["vac_EdadVacunaAnios"].GetType().ToString().Equals("System.DBNull"))
                {
                    vacuna.vac_EdadVacunaAnios = Convert.ToInt32(dr["vac_EdadVacunaAnios"]);
                }
                if (!dr["vac_EdadVacunaMeses"].GetType().ToString().Equals("System.DBNull"))
                {
                    vacuna.vac_EdadVacunaMeses = Convert.ToInt32(dr["vac_EdadVacunaMeses"]);
                }
                if (!dr["vac_EdadVacunaDias"].GetType().ToString().Equals("System.DBNull"))
                {
                    vacuna.vac_EdadVacunaDias = Convert.ToInt32(dr["vac_EdadVacunaDias"]);
                }
                vacuna.per_Consecutivo = per_Consecutivo;
                vacuna.pse_Id = DBNull.Value.Equals(dr["pse_Id"]) ? vacuna.pse_Id : Convert.ToInt32(dr["pse_Id"]);
                vacuna.pos_Id = DBNull.Value.Equals(dr["pos_Id"]) ? vacuna.pos_Id : Convert.ToInt32(dr["pos_Id"]);
                vacuna.com_Id = DBNull.Value.Equals(dr["com_Id"]) ? vacuna.com_Id : Convert.ToInt32(dr["com_Id"]);

                vacunas.Add(vacuna);

                logService.InsertarLog("seleccionarVacunasPersona()", "CORRECTO", arParms);
                //insertarLogBD("seleccionarVacunasPersona()", "CORRECTO", arParms);
                dsVacuna.Dispose();

                return vacunas;
            }
        }      

        Task<VacunaResponseDTO> IPersonaService.seleccionarUbicacionPersona(long per_Consecutivo)
        {
            string connectionString = "Data Source=myServerAddress;Initial Catalog=myDataBase;User Id=myUsername;Password=myPassword;";

            SqlParameter[] arParms = new SqlParameter[1];
            arParms[0] = new SqlParameter("@per_Consecutivo", 0);
            arParms[0].Value = per_Consecutivo;
            UbicacionEntity oPersonaUbicacion = new UbicacionEntity();
            DataSet dsPersonaUbicacion = SqlHelper.ExecuteDataset(connectionString, "pa_SeleccionarUbicacionPersona", arParms);
            if (dsPersonaUbicacion != null && dsPersonaUbicacion.Tables[0].Rows.Count > 0)
            {
                var row = dsPersonaUbicacion.Tables[0].Rows[0];
                oPersonaUbicacion.per_Consecutivo = Convert.ToInt64(row["per_Consecutivo"].ToString());
                oPersonaUbicacion.dir_Direccion = row["dir_Direccion"].ToString();
                oPersonaUbicacion.bar_Id = row["bar_Id"].ToString();
                oPersonaUbicacion.bar_Nombre = row["bar_Nombre"].ToString();
                if (!string.IsNullOrEmpty(row["upz_Id"].ToString()))
                {
                    oPersonaUbicacion.upz_Id = Convert.ToInt32(row["upz_Id"].ToString());
                }
                oPersonaUbicacion.upz_Nombre = row["upz_Nombre"].ToString();
                if (!string.IsNullOrEmpty(row["loc_Id"].ToString()))
                {
                    oPersonaUbicacion.loc_id = Convert.ToInt32(row["loc_Id"].ToString());
                }
                oPersonaUbicacion.loc_Nombre = row["loc_Nombre"].ToString();
                oPersonaUbicacion.dir_Codigo_direccion = row["dir_Codigo_direccion"].ToString();
                oPersonaUbicacion.dir_CoordenadaX = row["dir_CoordenadaX"].ToString();
                oPersonaUbicacion.dir_CoordenadaY = row["dir_CoordenadaY"].ToString();
                oPersonaUbicacion.tel_Contacto = row["tel_Contacto"].ToString();
                oPersonaUbicacion.tel_Telefono = row["tel_Telefono"].ToString();
                oPersonaUbicacion.cor_correo = row["cor_correo"].ToString();
                if (!string.IsNullOrEmpty(row["dir_mun_id"].ToString()))
                {
                    oPersonaUbicacion.dir_mun_id = Convert.ToInt32(row["dir_mun_id"].ToString());
                }
                if (!string.IsNullOrEmpty(row["dir_dep_Id"].ToString()))
                {
                    oPersonaUbicacion.dir_dep_Id = Convert.ToInt32(row["dir_dep_Id"].ToString());
                }
                oPersonaUbicacion.dir_pais_Id = row["dir_pais_Id"].ToString();
                if (!string.IsNullOrEmpty(row["dir_zon_Id"].ToString()))
                {
                    oPersonaUbicacion.dir_zon_Id = Convert.ToInt32(row["dir_zon_Id"].ToString());
                }

                logService.InsertarLog("seleccionarPersonaBusqueda()", "CORRECTO", arParms);
                //insertarLogBD("seleccionarUbicacionPersona()", "CORRECTO", arParms);
            }
            return oPersonaUbicacion;
        }

        public Task<AfiliacionPersonaResponseDTO> seleccionarAfiliacionPersona(long per_Consecutivo)
        {
            string cadena = ""; //My.Settings.cadenaPai20
            AfiliacionPersonaEntity oPersonaAfiliacion = new AfiliacionPersonaEntity();
            if (per_Consecutivo != 0)
            {
                SqlParameter[] arParms = new SqlParameter[1];
                arParms[0] = new SqlParameter("@per_Consecutivo", 0);
                arParms[0].Value = per_Consecutivo;

                DataSet dsPersonaAfiliacion = SqlHelper.ExecuteDataset(cadena, "pa_SeleccionarAfiliacionPersona", arParms);
                if (dsPersonaAfiliacion != null && dsPersonaAfiliacion.Tables[0].Rows.Count > 0)
                {
                    oPersonaAfiliacion.per_Consecutivo = Convert.ToInt64(dsPersonaAfiliacion.Tables[0].Rows[0]["per_Consecutivo"].ToString());
                    oPersonaAfiliacion.ase_id = dsPersonaAfiliacion.Tables[0].Rows[0]["ase_id"].ToString();
                    oPersonaAfiliacion.ase_nombre = dsPersonaAfiliacion.Tables[0].Rows[0]["ase_nombre"].ToString();
                    oPersonaAfiliacion.reg_id = Convert.ToInt32(dsPersonaAfiliacion.Tables[0].Rows[0]["reg_id"].ToString());
                    oPersonaAfiliacion.reg_Nombre = dsPersonaAfiliacion.Tables[0].Rows[0]["reg_Nombre"].ToString();
                    if (!string.IsNullOrEmpty(dsPersonaAfiliacion.Tables[0].Rows[0]["tia_id"].ToString()))
                    {
                        oPersonaAfiliacion.tia_id = Convert.ToInt32(dsPersonaAfiliacion.Tables[0].Rows[0]["tia_id"].ToString());
                    }
                }
                logService.InsertarLog("seleccionarVacunasPersona()", "CORRECTO", arParms);
                //insertarLogBD("seleccionarAfiliacionPersona()", "CORRECTO", arParms);
            }
            return oPersonaAfiliacion;
            throw new NotImplementedException();
        }

        public Task<TablaDominioResponseDTO> seleccionarTablaDominio(short id_Tabla)
        {
            string cadena = ""; // My.Settings.cadenaPai20
            TablaDominioEntity cTablaDominio = new TablaDominioEntity();

            SqlParameter[] arParms = new SqlParameter[1];
            arParms[0] = new SqlParameter("@id_Tabla", 16);
            arParms[0].Value = id_Tabla;

            DataSet dsTablaDominio = SqlHelper.ExecuteDataset(cadena, "pa_SeleccionarTablasDominio", arParms);

            if (dsTablaDominio != null && dsTablaDominio.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in dsTablaDominio.Tables[0].Rows)
                {
                    TablaDominioEntity eTablaDominio = new TablaDominioEntity();
                    eTablaDominio.td_id = dr[0].ToString();
                    eTablaDominio.td_descripcion = dr[1].ToString();
                    cTablaDominio.Add(eTablaDominio);
                }
            }
            return cTablaDominio;
        }
    }
}
