using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DataAccess
{
    public class Conexion
    {
        private static string cadena = "Data Source=localhost; Database=bdSistemaUsuarios; Uid= sa; Pwd=123";

        public static Boolean EjecutarInstruccionesSinRetorno(string instruccionSQL)
        {
            /* Ejecuta comandos en la base de datos como Insertar, Update o Delete que no retornan Data. 
             * Devuelve true si tuvo filas afectadas
             */

            Boolean respuesta = false;
            int filasafectadas = 0;
            SqlConnection conn = new SqlConnection(cadena);
            conn.Open();

            SqlCommand sql = new SqlCommand(instruccionSQL, conn);
            filasafectadas = sql.ExecuteNonQuery();
            conn.Close();

            if (!(filasafectadas == 0))
                respuesta = true;

            return respuesta;
        }
          
        public static DataSet EjecutarInstruccionesConRetorno(string instruccionSQL)
        {
            //Ejecuta instrucciones como Select en la base de datos y devuelve el resultado en un DataSet
            SqlConnection conn = new SqlConnection(cadena);
            conn.Open();

            //Creando los objetos para llenar el dataset
            DataSet ds = new DataSet();
            SqlDataAdapter dp = new SqlDataAdapter(instruccionSQL, conn);

            dp.Fill(ds);

            conn.Close();

            return ds;

        }

    }
}
