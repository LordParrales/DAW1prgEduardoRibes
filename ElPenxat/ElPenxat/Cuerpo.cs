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
                
 
  


            string[] word = new string[10]; //Creador de palabras
            word[1] = "manolo";
            word[2] = "pepito";
            word[3] = "mama";
            word[4] = "raton";
            word[5] = "potro";
            word[6] = "papa";
            word[7] = "pie";

           
            int totalletters = 0;// contar letras
            int wordnum = 0; // numero para escojer la palabra
             

            string SecretWord = "";
            string UserWord = "";

            Random RandomWord = new Random();  //crear un metodo random para que escoja una variable al azar
             
            wordnum = RandomWord.Next(1, 7); // escoje una
            SecretWord = word[wordnum]; // pasa la palabra

            totalletters = SecretWord.Length; //separa por caracteres para contar las letras.
            Console.WriteLine("La palabra tiene {0} letras", totalletters);

            for (int i = 0; i < totalletters; i++)
            {
                if (SecretWord.Substring(i, 1) != " ")       //para sustraer del numero i un caracter y si no es un espacio  
                    UserWord = UserWord + "$";               //cambia las letras por asteriscos

                else
                    UserWord = UserWord + " ";              //por si hay espacios para que no tenga errores
           
            }


            Console.Write("\n" + UserWord);

            int attempts = 0;

            do
            {
                char downlyrics, chosenletter; //crear una variable char para las letras de tipo char(letra pulsada,letra elegida)
                bool success = false;
                Console.Write("Inserte una letra en minuscula: ");
                downlyrics = Console.ReadLine()[0];  // para que coja la primer letra de cada palabra
            

                
                for (int j=0; j<= totalletters -1;j++)  //para que analize letra por letra nustra palabra generada
                {
                    chosenletter = SecretWord.Substring(j,1)[0]; //separar las letras para comprobar las letras y luego iguala para saber si la letra pulsada es igual a la letra de la palabra
                    if (chosenletter.Equals(downlyrics))
                    {
                        StringBuilder sboculto = new StringBuilder(UserWord);  //crear un stringbuilder en la palabra ocultada
                        sboculto[j] = downlyrics;
                        UserWord = sboculto.ToString();
                        // PalabraUsuario = PalabraUsuario.Remove(j, 1);
                        //PalabraUsuario  = PalabraUsuario.Insert(1, letrapulsada);
                        success = true;                       // si es verdadero enhorabuena
                    }
                }
                if(success)
                {
                    Console.Write("\nENHORABONA!" + UserWord);

                }
                else  // si no es verdad se incrementa el numero de intentoss
                {
                    attempts++;
                    Console.Write("\n HAS FALLAT CASURRO! PORTES {0} INTENTOS", attempts);
                }
                if (attempts == 0)
                {
                    Console.WriteLine("\n###########################################################################################");
                    Console.WriteLine(" _________");
                    Console.WriteLine(" |         |");
                    Console.WriteLine(" |         0");
                    Console.WriteLine(@" |        /|\");
                    Console.WriteLine(@" |        / \");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                }
                if (attempts == 1)
                {
                    Console.WriteLine("\n###########################################################################################");
                    Console.WriteLine(" _________");
                    Console.WriteLine(" |         |");
                    Console.WriteLine(" |         0");
                    Console.WriteLine(@" |        /|\");
                    Console.WriteLine(@" |        / ");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                }
                if (attempts == 2)
                {
                    Console.WriteLine("\n###########################################################################################");
                    Console.WriteLine(" _________");
                    Console.WriteLine(" |         |");
                    Console.WriteLine(" |         0");
                    Console.WriteLine(@" |        /|\");
                    Console.WriteLine(@" |         ");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                }
                if (attempts == 3)
                {
                    Console.WriteLine("\n###########################################################################################");
                    Console.WriteLine(" _________");
                    Console.WriteLine(" |         |");
                    Console.WriteLine(" |         0");
                    Console.WriteLine(@" |        /|");
                    Console.WriteLine(@" |         ");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                }
                if (attempts ==4)
                {
                    Console.WriteLine("\n###########################################################################################");
                    Console.WriteLine(" _________");
                    Console.WriteLine(" |         |");
                    Console.WriteLine(" |         0");
                    Console.WriteLine(@" |         |");
                    Console.WriteLine(@" |         ");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");

                    
                }
                if (attempts == 5)      //si llegas a 5 intentos game over
           {
               Console.WriteLine("\n###########################################################################################");
               Console.WriteLine(" _________");
               Console.WriteLine(" |         |");
               Console.WriteLine(" |         X");
               Console.WriteLine(@" |         ");
               Console.WriteLine(@" |         ");
               Console.WriteLine(" |");
               Console.WriteLine(" |");

               Console.Write("\n GAAAAAME OVEEEEEEER!!!!");
           }
            if (SecretWord == UserWord)   //si completas la palabra ganas el juego
            {
                Console.Write("\n ENHORABOOOONAAAA ERES EL GUANYADOR!!!");
                break;
            }
             
            }while (attempts <5);

            Console.ReadKey();
    
        }

       
    }
}
