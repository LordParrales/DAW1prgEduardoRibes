using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace TestPersona
{
   static class Programa
    {
      
       static void Main()
       {
           Persona p = new Persona();
           p.SetNombre("Rodolfo");
           Console.WriteLine(p.GetNombre());

           p.Nombre = "Pableete";
           Console.WriteLine(p.Nombre);
           Console.ReadKey();
       }



       //static void Mai/n()
      // {
           //Persona p;
           //p = new Persona();

           //Persona p2;
           //p2 = p;

           //p.Nombre = "Pepito";
           //p2.Apellido = "Lopez";
           //Console.WriteLine(p2.Nombre);
           //Console.ReadKey();


           //p2 = null;
           //if (p2 != null) ;
           //Console.WriteLine(p2.Nombre);

           //string presentacion = p.Presentarse();
           //TestPresentarse();

          // Console.ReadKey();

      // }

       static void TestPresentarse()
       {
           Persona p1 = new Persona();
           p1.Nombre = "Rodolfo";
           p1.Apellido = "Gomez";

           Persona p2 = new Persona();
           p2.Nombre = "Josep";
           p2.Apellido = "Cabrera";

           //string nc = p1.NombreCompleto();

           Console.WriteLine(p1.Presentarse());
           Console.WriteLine(p2.Presentarse());
       }
       static void TestPresentarAOtra()
       {
           Persona p1 = new Persona();
           p1.Nombre = "Rodolfo";
           p1.Apellido = "Gomez";

           Persona p2 = new Persona();
           p2.Nombre = "Josep";
           p2.Apellido = "Cabrera";

           //string nc = p1.NombreCompleto();

           Console.WriteLine(p1.PresentarA(p2));

       }
   }
}
