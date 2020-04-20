using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Cerveza : BebidaEnergizante
    {
        public override int CuantoMeHeEmbriagadoPorHora()
        {
            return 5;
        }
    }
}
