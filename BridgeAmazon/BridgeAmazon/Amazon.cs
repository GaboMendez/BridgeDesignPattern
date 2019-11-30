using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeAmazon
{
    public abstract class Amazon
    {
        protected IEnvio interfaceEnvio;

        public Amazon(IEnvio envio)
        {
            interfaceEnvio = envio;
        }

        public string EnviarPaquete()
        {
            return interfaceEnvio.Enviar();
        }

        public string EntregarPaquete()
        {
            return interfaceEnvio.Entregar();
        }

        public void AsignarEnvio(IEnvio envio)
        {
            interfaceEnvio = envio;
        }

        public IEnvio ObtenerEnvio()
        {
            return interfaceEnvio;
        }

    }
}
