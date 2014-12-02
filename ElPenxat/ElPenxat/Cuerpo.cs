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
            palabra[3] = "mama";
            palabra[4] = "raton";
            palabra[5] = "potro";
            palabra[6] = "papa";
            palabra[7] = "pie";

           
            int totaletra = 0;// contar letras
            int numpalabra = 0; // numero para escojer la palabra
             

            string PalabraSecreta = "";
            string PalabraUsuario = "";

            Random aleapalabra = new Random();  //crear un metodo random para que escoja una variable al azar
             
            numpalabra = aleapalabra.Next(1, 7); // escoje una
            PalabraSecreta = palabra[numpalabra]; // pasa la palabra

            totaletra = PalabraSecreta.Length; //separa por caracteres para contar las letras.
            Console.WriteLine("La palabra tiene {0} letras", totaletra);

            for (int i = 0; i <= totaletra; i++)
            {
                if (PalabraSecreta.Substring(i, 1) != " ")       //para sustraer del numero i un caracter y si no es un espacio  
                    PalabraUsuario = PalabraUsuario + "$";               //cambia las letras por asteriscos

                else
                    PalabraUsuario = PalabraUsuario + " ";              //por si hay espacios para que no tenga errores
           
            }


            Console.Write("\n" + PalabraUsuario);

            int intentos = 0;

            do
            {
                string letrapulsada= "", letraelegida = "";
                bool exito = false;
                Console.Write("Inserte una letra en minuscula: ");
                letrapulsada = Console.ReadLine();
            

                
                for (int j=0; j<= totaletra -1;j++)  //para que analize letra por letra nustra palabra generada
                {
                    letraelegida = PalabraSecreta.Substring(j,1); //separar las letras para comprobar las letras y luego iguala para saber si la letra pulsada es igual a la letra de la palabra
                    if (letraelegida.Equals(letrapulsada))
                    {
                        PalabraUsuario = PalabraUsuario.Remove(j, 1);
                        PalabraUsuario  = PalabraUsuario.Insert(1, letrapulsada);
                        exito = true;                       // si es verdadero enhorabuena
                    }
                }
                if(exito)
                {
                    Console.Write("\nENHORABONA!" + PalabraUsuario);

                }
                else  // si no es verdad se incrementa el numero de intentoss
                {
                    intentos++;
                    Console.Write("\n HAS FALLAT CASURRO! PORTES {0} INTENTOS", intentos);
                }
                if (intentos == 0)
                {

                    Console.WriteLine(" _________");
                    Console.WriteLine(" |         |");
                    Console.WriteLine(" |         0");
                    Console.WriteLine(@" |        /|\");
                    Console.WriteLine(@" |        / \");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                }
                if (intentos == 1)
                {
                    Console.WriteLine(" _________");
                    Console.WriteLine(" |         |");
                    Console.WriteLine(" |         0");
                    Console.WriteLine(@" |        /|\");
                    Console.WriteLine(@" |        / ");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                }
                if (intentos == 2)
                {
                    Console.WriteLine(" _________");
                    Console.WriteLine(" |         |");
                    Console.WriteLine(" |         0");
                    Console.WriteLine(@" |        /|\");
                    Console.WriteLine(@" |         ");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                }
                if (intentos == 3)
                {
                    Console.WriteLine(" _________");
                    Console.WriteLine(" |         |");
                    Console.WriteLine(" |         0");
                    Console.WriteLine(@" |        /|");
                    Console.WriteLine(@" |         ");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                }
                if (intentos ==4)
                {
                    Console.WriteLine(" _________");
                    Console.WriteLine(" |         |");
                    Console.WriteLine(" |         0");
                    Console.WriteLine(@" |         |");
                    Console.WriteLine(@" |         ");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");

                    
                }
                if (intentos == 5)      //si llegas a 5 intentos game over
           {
               Console.WriteLine(" _________");
               Console.WriteLine(" |         |");
               Console.WriteLine(" |         X");
               Console.WriteLine(@" |         ");
               Console.WriteLine(@" |         ");
               Console.WriteLine(" |");
               Console.WriteLine(" |");

               Console.Write("\n GAAAAAME OVEEEEEEER!!!!");
           }
            if (PalabraSecreta == PalabraUsuario)   //si completas la palabra ganas el juego
            {
                Console.Write("\n ENHORABOOOONAAAA ERES EL GUANYADOR!!!");
                break;
            }
             
            }while (intentos <=5);

            Console.ReadKey();
    
        }

       
    }
}
