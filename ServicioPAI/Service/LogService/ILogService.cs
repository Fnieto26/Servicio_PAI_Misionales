using System.Data.SqlClient;

namespace ServicioPAI.Service.LogService
{
    public interface ILogService
    {
        public void InsertarLog(string metodo, string detalleError, SqlParameter[] arParms);

    }
}
