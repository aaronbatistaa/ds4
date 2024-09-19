using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio86
{
    class ClaseBase
    {
        public void test()
        {

        }
        public virtual void masTests() //al cambiar la palabra reservada virtual por sealed, permite que el método se pueda sobreescribir en ClaseHijo que sería la clase derivada
        {

        }
    }
}
