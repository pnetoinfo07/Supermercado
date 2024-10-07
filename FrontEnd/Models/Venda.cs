using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd;

public class Venda
{
    public int Id { get; set; }
    public int EnderecoId { get; set; }
    public string MetodoPagamento { get; set; }
    public double ValorFinal { get; set; }
    public string GetMetodoPagamentoById(int opcaoSelecionada)
    {
        switch (opcaoSelecionada)
        {
            case 1:
                return "PIX";
            case 2:
                return "Débito";
            case 3:
                return "Crédito";
            default:
                return null;
        }

    }
}
