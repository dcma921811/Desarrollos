using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singleton
{
    static class Program
    {
        static void Main()
        {            
            
            Console.WriteLine(Singleton.getInstancia().mensaje);
        }
    }
}
