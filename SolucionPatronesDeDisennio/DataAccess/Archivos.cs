using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace DataAccess
{
    public class Archivos
    {
        private static TextWriter archivo;
        private static string nombrearchivo = "Log_Aplicacion";
        private static string extencion = ".txt";
        private static string directorio = "C:\\LogsAplicacion\\";

        public static void GuardarLog(string mensaje)
        {
            string path = directorio + nombrearchivo + extencion;            
            
            StreamWriter stream = null;
            try
            {
                stream = File.AppendText(path);
                stream.WriteLine(string.Format("{0} - {1}.", DateTime.Now, mensaje));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
        }
        
    }
}
