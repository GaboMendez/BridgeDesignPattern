using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeAmazon
{
    public class EnvioEspaña : IEnvio
    {
        public string Enviar()
        {
            return "Pedido enviado a España";
        }

        public string Entregar()
        {
            return "Pedido entregado a España";
        }
    }
}
