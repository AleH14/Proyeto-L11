/*
 * Creado por SharpDevelop.
 * Usuario: Alejandro
 * Fecha: 3/2/2022
 * Hora: 20:29
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio_2
{
	class Program
	{
		public static void Main(string[] args)
		{
	// Programa realizado por Alejandro Hernandez
   // Día: Febrero 03,2022
   Console.WindowHeight = 25;  // alto de la ventana           
   Console.WindowWidth = 60; //ancho de la ventana
   Console.ForegroundColor = ConsoleColor.Black;
   Console.BackgroundColor = ConsoleColor.White;
   Console.Clear();
   Console.Title = "Ejercicio 2";

   // Declaracion de variables
   double catidad1, catidad2, catidad3,dolares, total, porciento1, porciento2, porciento3;
  


   // Entrada de datos
 
   Console.Write("Ingrese la cantidad que aporto Juan: ");
   catidad1 = double.Parse(Console.ReadLine());
   
   Console.Write("Ingrese la cantidad que aporto Raquel: ");
   catidad2 = double.Parse(Console.ReadLine());

   Console.Write("Ingrese la cantidad que aporto Daniel: ");
   catidad3 = double.Parse(Console.ReadLine());
   
   //Procesos
   dolares = catidad3 / 3.25;// conversion de soles a dolares
   total =catidad1 + catidad2 + dolares;
   
   porciento1 = (catidad1 * 100)/total;
   porciento2 = (catidad2 * 100)/total;
   porciento3 = (dolares * 100)/total;
   
   // Salida de los datos
   Console.WriteLine("\t-------------------------------------------");
   
   Console.WriteLine("El total de  dinero  es: $ {0}",Math.Round(total,2));
   Console.WriteLine("El porcentaje de Juan es : {0}  %",Math.Round(porciento1,2));
   Console.WriteLine("El porcentaje  de Raquel es : {0} %",Math.Round(porciento2,2));
   Console.WriteLine("El porcentaje  de Daniel es : {0} %",Math.Round(porciento3,2));

   Console.WriteLine("\t-------------------------------------------");
   Console.Write("\n\n");
   //Pantalla opcional
   Console.Write("\t");
   Console.ForegroundColor = ConsoleColor.White;
   Console.BackgroundColor = ConsoleColor.Green;
   Console.WriteLine("*********************************************");
   Console.ForegroundColor = ConsoleColor.Black;
   Console.BackgroundColor = ConsoleColor.White;
   Console.WriteLine("\t*                                           *");
   Console.WriteLine("\t*     Este programa fue diseñado por:       *");
   Console.WriteLine("\t*                                           *");
   Console.WriteLine("\t*       Alejandro Hernandez                 *");
   Console.WriteLine("\t*                                           *");
   Console.Write("\t");
   Console.ForegroundColor = ConsoleColor.White;
   Console.BackgroundColor = ConsoleColor.Green;
   Console.WriteLine("*********************************************");
   Console.ForegroundColor = ConsoleColor.Black;
   Console.BackgroundColor = ConsoleColor.White;
   Console.Write("\t");
   Console.WriteLine("--> Fin del Programa");
   Console.Write("\t");
   Console.ReadKey();
		}
	}
}