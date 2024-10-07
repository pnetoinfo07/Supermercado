using Core._03_Entidades.DTO.Carrinhos;
using Core.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._03_Entidades.DTO.Venda
{
    public class ReadVendaReciboDTO
    {
        public Endereco Endereco { get; set; }
        public string NomeUsuario { get; set; }
        public string MetodoPagamento { get; set; }
        public List<ReadCarrinhoDTO> Produtos { get; set; }
        public double ValorFinal { get; set; }

        public override string ToString()
        {
            string mensagemRecibo = $"\nNome usuário {NomeUsuario}" +
                $"\nEndereço: {Endereco.Rua}, {Endereco.Bairro},nº {Endereco.Numero}" +
                $"\nMetodo de Pagamento: {MetodoPagamento}";

            foreach (ReadCarrinhoDTO p in Produtos)
            {
                mensagemRecibo += $"\n{p.ToStringProduto()}";
            }

            mensagemRecibo += $"\n---------- Valor Final: {ValorFinal} ----------";
            return mensagemRecibo;
        }

    }
}
