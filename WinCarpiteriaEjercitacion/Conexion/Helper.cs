using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WinCarpiteriaEjercitacion
{
    internal class Helper
    {
        private SqlConnection cnn ;
        
        public Helper()
        {
            cnn = new SqlConnection(Properties.Resources.String1);
        }

        internal DataTable ConsultaSQL(string sp_nombre)
        {
           SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.CommandText=sp_nombre;
            dt.Load(cmd.ExecuteReader());
            cnn.Close();
            return dt;
        }
    }
}
