using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeAmazon
{
    public class EnvioCuba : IEnvio
    {
        public string Enviar()
        {
            return "Pedido enviado a Cuba";
        }

        public string Entregar()
        {
            return "Pedido entregado a Cuba";
        }
    }
}
