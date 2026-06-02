using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Carro : Vehiculos
    {
        public string Acondicionado;
        public int cantidadpuertas;
        public string TipoCombustible;
        public string TipoTransmicion;
        public int velocidadmaxima;

        
        public void EncenderAireAcondiocionado()
        {
              Console.WriteLine("Encender: El carro esta ensendido");
        }

        public void Arrancar()
        {
            Console.WriteLine("El carro esta arrancando");
            if (this.getEstado() == "Encendido")
            {
                Console.WriteLine("El carro esta arrancando");
            }
            else
            {
                Console.WriteLine("El carro no se puede arrancar porque esta apagado");
            }

        }

        public void PrenderLuces()
        {
            Console.WriteLine("Prender: Luces encendidas");

        }

        public void ApagarLuces()
        {
            Console.WriteLine(" Apagar: Luces apagadas");
        }

        public void Frenar()
        {
            Console.WriteLine("Frenar: El carro esta frenado");

        }

        public void RecargarCombistible()
        {
             Console.WriteLine(" Echar combustible: El carro esta recargando combustible");
        }

        public void TocarBocina()
        {
            Console.WriteLine("Tocar bocina: Piii Piii!!!");
        }

        public void Abrirpuetas()
        {
            Console.WriteLine("Abrir puertas: Las puestas estan abietas");
        }

        public void Cerrarpuertas()
        {
            Console.WriteLine("Cerrarpuertas: Las puertas estan cerradas");
        }

        
    }
}
 