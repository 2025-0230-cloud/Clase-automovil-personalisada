


using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro miCarro = new Carro();

            
            miCarro.marca = "Honda";
            miCarro.modelo = "Civic";
            miCarro.TipoCombustible = "Gasolina";
            miCarro.cantidadpuertas = 4;
            miCarro.velocidadmaxima = 240;

           
            miCarro.encender();

            
            Console.WriteLine("Estado: " + miCarro.getEstado());

            miCarro.Arrancar();
            miCarro.PrenderLuces();
            miCarro.TocarBocina();
            miCarro.Frenar();

            
            miCarro.apagar();

            Console.WriteLine("Estado final: " + miCarro.getEstado());

            Console.ReadKey();
        }
    }
}
