namespace FrontEnd
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
                $"\nEndereço: {Endereco.Rua}, {Endereco.Bairro}, {Endereco.Numero}" +
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
