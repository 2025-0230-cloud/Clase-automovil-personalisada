using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Vehiculos
    {
        public string marca;
        public string modelo;
        public string anioFabricacion;
        public string color;
        public string matricula;
        public bool tieneLuces;
        public string tipo;
        public string maxVelocity;
        public bool esElectrico;
        public string placa;
        private bool estado;


        public Vehiculos() { }

        public bool encender()
        {

            return this.estado = true;
        }

        public bool apagar()
        {

            return this.estado = false;
        }

        public string getEstado()
        {
            if (this.estado == true)
            {
                return "Encendido";
            }

            return "Apagado";
        }

    }

}

