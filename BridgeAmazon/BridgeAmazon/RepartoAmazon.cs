using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeAmazon
{
    public class RepartoAmazon : Amazon
    {
        private String numPedido;

        public RepartoAmazon(String idPedido) : base(new EnvioCuba())
        {
            this.numPedido = idPedido;
        }
        public RepartoAmazon(String idPedido, IEnvio envio) : base(envio)
        {
            this.numPedido = idPedido;
        }

        public string idPedido()
        {
            return $"Nuestro pedido es: {numPedido}";
        }
    }
}
