using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jetsmart
{
    public class Program
    {
        static void Main(string[] args)
        {

            int numeroBoleto = 5;
            string nombrePasajero = "Juan Pérez";
            string destino = "Lima";
            string fechaSalida = "2023-10-02";
            string horaSalida = "10:00";

            ReemisionBoleto reemision = new ReemisionBoleto(numeroBoleto, nombrePasajero, destino, fechaSalida, horaSalida);

            reemision.NumeroBoleto = 10;
            reemision.NombrePasajero = "Pedro López";
            reemision.Destino = "Cusco";
            reemision.FechaSalida = "2023-10-03";
            reemision.HoraSalida = "12:00";

            Console.WriteLine("Datos del boleto reemitido:");
            Console.WriteLine("Número de boleto: {0}", reemision.NumeroBoleto);
            Console.WriteLine("Nombre del pasajero: {0}", reemision.NombrePasajero);
            Console.WriteLine("Destino: {0}", reemision.Destino);
            Console.WriteLine("Fecha de salida: {0}", reemision.FechaSalida);
            Console.WriteLine("Hora de salida: {0}", reemision.HoraSalida);
        }
    }

    public class ReemisionBoleto
    {
        private object value;
        private string v1;
        private string v2;
        private string v3;
        private string v4;

        public int NumeroBoleto { get; set; }
        public string NombrePasajero { get; set; }
        public string Destino { get; set; }
        public string FechaSalida { get; set; }
        public string HoraSalida { get; set; }

        public ReemisionBoleto(int numeroBoleto, string nombrePasajero, string destino, string fechaSalida, string horaSalida)
        {
            this.NumeroBoleto = numeroBoleto;
            this.NombrePasajero = nombrePasajero;
            this.Destino = destino;
            this.FechaSalida = fechaSalida;
            this.HoraSalida = horaSalida;
        }

        public ReemisionBoleto(object value, string v1, string v2, string v3, string v4)
        {
            this.value = value;
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }
    }
}