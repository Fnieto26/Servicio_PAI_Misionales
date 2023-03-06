using System.Data.SqlClient;
using System.Reflection.Metadata;

namespace ServicioPAI.Service.LogService
{
    public class LogService : ILogService
    {

        private const string rutaLog = "C:\\temp\\";       

        void ILogService.InsertarLog(string metodo, string detalleError, SqlParameter[] arParms)
        {
            try
            {
                const string fic = rutaLog + "logServicioWebPAI4.txt";

                if (!File.Exists(fic))
                {
                    using (FileStream oArchivo = File.Create(fic))
                    {
                        oArchivo.Close();
                    }
                }

                using (StreamWriter sw = new StreamWriter(fic, true))
                {
                    sw.WriteLine("Metodo: " + metodo + ";PosibleError:" + detalleError + ";Fecha: " + DateTime.Now.ToString());
                    if (arParms != null)
                    {
                        string lineaParametro = string.Empty;
                        string lineaDatos = string.Empty;
                        foreach (SqlParameter param in arParms)
                        {
                            lineaParametro += param.ParameterName.ToString() + ";";
                            lineaDatos += param.Value.ToString() + ";";
                        }
                        sw.WriteLine(lineaParametro);
                        sw.WriteLine(lineaDatos);
                        sw.WriteLine("");
                    }
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                // manejo de excepciones
            }
        }
    }
}
