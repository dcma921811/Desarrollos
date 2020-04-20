using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        //Declaracion de la variable
        private static Singleton instancia = null;
        public string mensaje = "";
                

        //Contructor privado
        protected Singleton() {
            mensaje = "Hola mundo";
        }

        public static Singleton getInstancia() {

                if (instancia == null)
                {
                    instancia = new Singleton();
                    Console.WriteLine("Dentro del if");
                }
                
            return instancia;
        }
               

    }
}
