using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceCheckout.App
{
    public class PedidoService
    {
         public class PerfilJogadorService
    {
        public string GerarCodigoRastreio(string regiao, int numeroPedido)
        {
            //Recebe "sudeste" e 42, deve retornar "SUDESTE-0042".
            return $"{regiao.ToUpperInvariant()}-{numeroPedido:D4}";
        }

        public int CalcularPontosFidelidade(int valorTotal)
        {
            //Recebe 150 (150 / 10 = 15 parcelas de R$10 -> 15 * 2),
            //deve retornar 30.
            return valorTotal / 10 * 2;
        }

        public bool TemDireitoAFreteGratis(int valorTotal, bool
        eClienteVIP)
        {

            //O frete é grátis se o valor total for maior ou igual a R$ 200 OU se o
           // comprador for um cliente VIP.
           //  o Exemplo: Recebe 150 e true -> Retorna true. Recebe 150 e false ->
           //  Retorna false.
            return valorTotal >= 200 || eClienteVIP;
        }
    }
}
    }
