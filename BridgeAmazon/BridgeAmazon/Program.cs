using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeAmazon
{
    class Program
    {
        static void Main(string[] args)
        {


            RepartoAmazon reparto = new RepartoAmazon("12345");
            Console.WriteLine(reparto.ObtenerEnvio());
            Console.WriteLine(reparto.EnviarPaquete());
            Console.WriteLine(reparto.EntregarPaquete());
            Console.WriteLine("////////////////////////////");
            Console.WriteLine();
            reparto.AsignarEnvio(new EnvioEspaña());
            Console.WriteLine(reparto.ObtenerEnvio());
            Console.WriteLine(reparto.EnviarPaquete());
            Console.WriteLine(reparto.EntregarPaquete());
            Console.WriteLine();
            Console.WriteLine("////////////////////////////");
            Console.ReadKey();
        }
    }
}
