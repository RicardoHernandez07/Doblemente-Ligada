using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_doblemente_ligada
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista l = new Lista();
            l.insertarnodo();
            l.insertarnodo();
            l.insertarnodo();
            l.insertarnodo();
            l.insertarnodo();
            Console.WriteLine("Del primero al Ultimo");
            l.desplegarlistaUP();
            Console.WriteLine("Del ultimo al primero");
            l.desplegarListaPU();
            Console.ReadLine();

        }
    }
}
