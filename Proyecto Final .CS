using System;

namespace sistema_de_acceso
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] user1;

            user1 = new string[5];

            user1[0] = "Pedro";//nombre
            user1[1] = "00105121041";//username
            user1[2] = "151530";//clave
            user1[3] = "administrador";//rol
            user1[4] = "5-10-19";//fecha de creacion
            

            string[] user2;

            user2 = new string[5];

            user2[0] = "Carlos";//nombre
            user2[1] = "00205122042";//username
            user2[2] = "131340";//clave
            user2[3] = "supervisor";//rol
            user2[4] = "7-8-19";//fecha de creacion 

            string[] user3;

            user3 = new string[5];

            user3[0] = "Manuel"; // nombre
            user3[1] = "00306122043"; //username
            user3[2] = "161680";// clave
            user3[3] = "vendedor";// rol
            user3[4] = "2-5-19"; // fecha de creacion

            // comprobacion de estado de usuario
            var random = new Random();
            var estado = random.Next(0, 2);
          
             
            Console.WriteLine("ingrese su username");
            string username = Console.ReadLine();
            Console.WriteLine("ingrese su clave");
            string clave = Console.ReadLine();

            if (username == user1[1] && clave == user1[2] && estado == 0)
            {

                Console.WriteLine("su cuenta esta inactiva");
               

            }

           else  if (username == user1[1] && clave == user1[2] && estado == 1)
            {

                Console.WriteLine("Bienvenido " + user1[0] + " acaba de ingresar con el username " + user1[1] + " y su rol es " + user1[3]);
                Console.WriteLine("facha de creacion de usuario : " + user1[4]);
            }


            else if (username == user2[1] && clave == user2[2] && estado == 0)
            {
                Console.WriteLine("su cuenta esta inactiva");

            }

            else if (username == user2[1] && clave == user2[2] && estado == 1)
            {
               
                
                Console.WriteLine("Bienvenido " + user2[0] + " acaba de ingresar con el username " + user2[1] + " y su rol es " + user2[3]);
                Console.WriteLine("facha de creacion de usuario : " + user2[4]);
            }

           else if (username == user3[1] && clave == user3[2] && estado == 0)
            {
                Console.WriteLine("su cuenta esta inactiva");

            }
            else if (username == user3[1] && clave == user3[2] && estado == 1)
            {
                Console.WriteLine(" Bienvenido " + user3[0] + " acaba de ingresar con el username " + user3[1] + " y su rol es " + user3[3]);
                Console.WriteLine("facha de creacion de usuario : " + user3[4]);
            }

            else
            {

                Console.WriteLine(" ERROR su username o clave han sido incorrectos ingrese los datos nuevamente ");
            }
        }


    }
}