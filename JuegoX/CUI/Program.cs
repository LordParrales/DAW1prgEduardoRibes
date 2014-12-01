using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RibesE.Programación.Eval1.Logica;

namespace RibesE.Programación.Eval1.Logica.CUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int secreto = Juego.SecretoDeLaVida();
            Console.WriteLine("El seccrote de la vida es: " + secreto);
            Console.ReadKey();
        }
    }
}
