using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Creador
    {
        public const int vinotinto = 1;
        public const int cerveza = 2;

        public static  BebidaEnergizante CreadorBebida(int Tipo)
        {
            switch (Tipo)
            {
                case vinotinto:
                    return new VinoTinto();
                case cerveza:
                    return new Cerveza();
                default: return null;
            }
        }

    }
}
