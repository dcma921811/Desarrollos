using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BebidaEnergizante bebida = Creador.CreadorBebida(Creador.cerveza);
            Console.WriteLine(bebida.CuantoMeHeEmbriagadoPorHora());
        }
    }
}
