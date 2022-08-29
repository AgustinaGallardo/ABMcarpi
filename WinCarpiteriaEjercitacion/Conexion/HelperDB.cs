using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace WinCarpiteriaEjercitacion
{
    internal class HelperDB
    {
        private SqlConnection cnn;

        public HelperDB()
        {
            cnn = new SqlConnection(Properties.Resources.String1);
        }

        internal DataTable ConsultarSQL(string SP_nombre)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable t = new DataTable();
            cnn.Open();
            cmd.Connection=cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = SP_nombre;
            t.Load(cmd.ExecuteReader());
            cnn.Close();
            return t;

        }
    }
}
