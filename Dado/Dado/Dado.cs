using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dado
{
    class Dado
    {
        private static Random rnd; // Static = mimsa lista para generar numeros aleatorios para todos los dados 
        private int _cara;

        public int lanzar()
        {
            int _cara = rnd.Next(1, 7);
            return _cara;
        }
        public Dado()
        {
            rnd = new Random(DateTime.Now.Millisecond);
        }
    }
}
