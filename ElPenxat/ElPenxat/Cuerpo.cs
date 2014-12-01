using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElPenxat8
{
    class Cuerpo
    {
        static void Main(string[] args)
        {
            Console.Title = "El Penxat";
            Console.WriteLine(@"  ______     __            ______   ______     __   __     __  __     ______     ______ ");
            Console.WriteLine(@" /\  ___\   /\ \          /\  == \ /\  ___\   /\ -. \ \   /\_\_\_\   /\  __ \   /\__  _\");
            Console.WriteLine(@" \ \  __\   \ \ \____     \ \  _-/ \ \  __\   \ \ \-.  \  \/_/\_\/_  \ \  __ \  \/_/\ \/");
            Console.WriteLine(@"  \ \_____\  \ \_____\     \ \_\    \ \_____\  \ \_\\ \_\   /\_\/\_\  \ \_\ \_\    \ \_\");
            Console.WriteLine(@"   \/_____/   \/_____/      \/_/     \/_____/   \/_/ \/_/   \/_/\/_/   \/_/\/_/     \/_/");

            Console.WriteLine("###########################################################################################");

            Console.WriteLine("Voste va ha jugar al PENXAT");
            Console.WriteLine("Creat per Eduardo Ribes Arocas");
            Console.WriteLine("Treball primer trimestre");
            Console.ReadKey();
                
 
  


            string[] palabra = new string[10]; //Creador de palabras
            palabra[1] = "manolo";
            palabra[2] = "pepito";
            palabra[3] = "programacion";
            palabra[4] = "raton";
            palabra[5] = "potro";
            palabra[6] = "impresora";
            palabra[7] = "pie";

            int contador = 0; //id del contador
            int totaletra = 0;// contar letras
            int numpalabra = 0; // numero para escojer la palabra
             

            string palabra2 = "";
            string palabra3 = "";

            Random aleapalabra = new Random();  //crear un metodo random para que escoja una variable al azar
             
            numpalabra = aleapalabra.Next(1, 8); // escoje una
            palabra2 = palabra[numpalabra]; // pasa la palabra

            totaletra = palabra2.Length; //separa por caracteres para contar las letras.
            Console.WriteLine("La palabra tiene {0} letras", totaletra);

            for (int i = 0; i <= totaletra; i++)
            {
                if (palabra2.Substring(i, 1) != " ")       //para sustraer del numero i un caracter y si no es un espacio hara esto 
                    palabra3 = palabra3 + "$";               //cambia las letras por asteriscos

                else
                    palabra3 = palabra3 + " ";              //por si hay espacios para que no tenga errores
           
            }


            Console.Write("\n" + palabra3);

            int intentos = 0;

            do
            {
                string letrapulsada= "", le = "";
                bool exito = false;
                Console.Write("Inserte una letra en minuscula: ");
                letrapulsada = Console.ReadLine();
            

                
                for (i=0; i<= totaletra -1;i++)
                {

                }

                
           
     
            



          


            Console.WriteLine(" _________");
            Console.WriteLine(" |         |");
            Console.WriteLine(" |         0");
            Console.WriteLine(@" |        /|\");
            Console.WriteLine(@" |        / \");
            Console.WriteLine(" |");
            Console.WriteLine(" |");


            Console.WriteLine(" _________");
            Console.WriteLine(" |         |");
            Console.WriteLine(" |         0");
            Console.WriteLine(@" |        /|\");
            Console.WriteLine(@" |        / ");
            Console.WriteLine(" |");
            Console.WriteLine(" |");

            Console.WriteLine(" _________");
            Console.WriteLine(" |         |");
            Console.WriteLine(" |         0");
            Console.WriteLine(@" |        /|\");
            Console.WriteLine(@" |         ");
            Console.WriteLine(" |");
            Console.WriteLine(" |");


            Console.WriteLine(" _________");
            Console.WriteLine(" |         |");
            Console.WriteLine(" |         0");
            Console.WriteLine(@" |        /|");
            Console.WriteLine(@" |         ");
            Console.WriteLine(" |");
            Console.WriteLine(" |");


            Console.WriteLine(" _________");
            Console.WriteLine(" |         |");
            Console.WriteLine(" |         0");
            Console.WriteLine(@" |         |");
            Console.WriteLine(@" |         ");
            Console.WriteLine(" |");
            Console.WriteLine(" |");


            Console.WriteLine(" _________");
            Console.WriteLine(" |         |");
            Console.WriteLine(" |         0");
            Console.WriteLine(@" |         ");
            Console.WriteLine(@" |         ");
            Console.WriteLine(" |");
            Console.WriteLine(" |");

            Console.WriteLine(" _________");
            Console.WriteLine(" |         |");
            Console.WriteLine(" |         X");
            Console.WriteLine(@" |         ");
            Console.WriteLine(@" |         ");
            Console.WriteLine(" |");
            Console.WriteLine(" |");


            Console.ReadKey();
        }
    }
}
