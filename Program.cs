using System;

namespace segundo_proyecto
{
    class Program
    {
        public static void Main(string[] args)
        {
                Console.WriteLine("ENUNCIADO");
                Console.WriteLine("Hacer un programa el cual filtre por medio de la edad y");
	            Console.WriteLine("de la estatura a las personas que desean entrar a un parque.");

                string cadena ="";
                int edad = 0;
                double altura = 0.0;
          
                Console.WriteLine();
                Console.WriteLine("Buenas, por favor ingrese su Edad:");
                cadena = Console.ReadLine();
                edad = Convert.ToInt32(cadena);
            
                 if(edad >= 18)
                {
                Console.WriteLine("Disculpe ha superado el limite de Edad para ingresar al Parque.");
                Console.WriteLine("Hasta Luego");
                }
                else
                {          
                Console.WriteLine("BIENVENIDO");
                Console.WriteLine();
                Console.WriteLine("¿Favor Ingresar su Altura? en metros y usando coma");
                cadena = Console.ReadLine();
                altura = Convert.ToDouble(cadena);
                                
                if(altura < 1.6)
                {
                    Console.WriteLine("Puedes ir a la Casa Encantada, el Gusanito y el Carrusel");    
                }
                else
                {
                    Console.WriteLine("Puedes ir a la Casa Encantada, el Gusanito, el Carrusel y a la Montaña Rusa");      
                }
                    Console.WriteLine("¡Vuelve Prontooo!");   
                }
            
            
            
            
            Console.ReadKey();
        }
    }
}
