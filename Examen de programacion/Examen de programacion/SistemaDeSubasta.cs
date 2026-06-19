using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Timers;

namespace Examen_de_programacion
{    
  

   public class ObraArte
   {
      public string Nombre { get; set; }
     public double PrecioBase { get; set; }
   }

   public class Postor
   {
     public string Nombre { get; set; }
     public double PresupuestoMaximo { get; set; }
   }

   public class Subasta
   {
      public static void Ejecutar()
      {
         Console.WriteLine("=== BIENVENIDO AL SISTEMA DE SUBASTAS EN LINEA ===");

         ObraArte laObra = new ObraArte();
         Console.Write("Ingrese el nombre de la obra de arte: ");
         laObra.Nombre = Console.ReadLine();

         Console.Write("Ingrese el precio base de la obra: ");
           
         laObra.PrecioBase = double.Parse(Console.ReadLine());

          
         Postor postor1 = new Postor { Nombre = "ALBERTO", PresupuestoMaximo = 10000.0 };
         Postor postor2 = new Postor { Nombre = "RUBEN", PresupuestoMaximo = 20000.0 };

           
         double ofertaMayorActual = laObra.PrecioBase;
         string ganadorActual = "0";
         bool subastaActiva = true; 

         Console.WriteLine($"\n--- INICIA LA SUBASTA POR: {laObra.Nombre} ---");
         Console.WriteLine($"Precio de salida: ${ofertaMayorActual}");



            while (subastaActiva)
            {
                Console.WriteLine("\nEscriba el nombre del postor ( Alberto / Ruben ) o 'VENDIDO' para cerrar:");
                string entradaPostor = Console.ReadLine();

               
                if (entradaPostor.Equals("VENDIDO", StringComparison.OrdinalIgnoreCase))
                {
                    subastaActiva = false;
                    break; 
                }

                
                Console.Write("Ingrese el monto de su oferta: ");
                double nuevaOferta = double.Parse(Console.ReadLine());

                
                if (nuevaOferta < ofertaMayorActual * 1.10)
                {
                    Console.WriteLine("OFERTA RECHAZADA: La oferta es muy baja. Debe superar el 10% del precio actual.");
                    continue; 
                }

                
                if (entradaPostor.ToUpper() == "ALBERTO")
                {
                    if (nuevaOferta > postor1.PresupuestoMaximo)
                    {
                        Console.WriteLine($"OFERTA RECHAZADA: Alberto solo tiene ${postor1.PresupuestoMaximo} de presupuesto.");
                        continue; 
                    }
                }
                else if (entradaPostor.ToUpper() == "RUBEN")
                {
                    if (nuevaOferta > postor2.PresupuestoMaximo)
                    {
                        Console.WriteLine($"OFERTA RECHAZADA: Ruben solo tiene ${postor2.PresupuestoMaximo} de presupuesto.");
                        continue;
                    }
                }
                else
                {
                    
                    Console.WriteLine("OFERTA RECHAZADA: Ese postor no está registrado en el sistema.");
                    continue; 
                }

                
                ofertaMayorActual = nuevaOferta;
                ganadorActual = entradaPostor;

                Console.WriteLine($"¡Oferta aceptada! El nuevo precio a vencer es: ${ofertaMayorActual}");
            }

            Console.WriteLine("\n=== SUBASTA FINALIZADA ===");

            double comisionDeLaCasa = ofertaMayorActual * 0.05;
            Console.WriteLine($"La comision de la venta para casa de subasta es: {comisionDeLaCasa} ");

            double TotalApagar = ofertaMayorActual + comisionDeLaCasa;
            Console.WriteLine($"El precio total es: {TotalApagar}");
            Console.WriteLine($"El ganador es: {ganadorActual}");



        }
    }
    

}

