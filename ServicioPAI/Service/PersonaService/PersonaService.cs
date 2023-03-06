using Microsoft.AspNetCore.Mvc.Routing;
using ServicioPAI.commons.Dto;
using ServicioPAI.Repository.Entities;
using ServicioPAI.Service.LogService;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

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


    }
}

