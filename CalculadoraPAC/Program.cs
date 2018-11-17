using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            //En el siguiente paso vamos a proceder a declarar las variables para el funcionamiento del programa

            double primerNumero;
            double segundoNumero;
            double resultado;

            /* En el siguiente paso lo que haremos será que la consola nos solicite los 2 números necesarios para operar, obligándonos a convertir con "Parse"
            el tipo de datos a introducir por teclado en este caso en enteros */    

            Console.WriteLine("Introduzca un número ");

            primerNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca siguiente número para operar ");

            segundoNumero = int.Parse(Console.ReadLine());

            // En el siguiente paso lo que haremos será adecuar el código con las operaciones correspondientes para que nos muestre todas las operaciones deseadas por consola  
                
                resultado = (primerNumero + segundoNumero);
                Console.WriteLine("La suma de " + primerNumero + " y " + segundoNumero + " es " + resultado);

                resultado = (primerNumero - segundoNumero);
                Console.WriteLine("La resta de " + primerNumero + " y " + segundoNumero + " es " + resultado);

                resultado = (primerNumero * segundoNumero);
                Console.WriteLine("La multiplicación de " + primerNumero + " y " + segundoNumero + " es " + resultado);

                resultado = (primerNumero / segundoNumero);
                Console.WriteLine("La división de " + primerNumero + " y " + segundoNumero + " es " + resultado);

            // El siguiente comando lo utilizaremos para que el programa espere a una pulsación de teclado para finalizarlo

            Console.ReadKey();

        }
    }
}


            
