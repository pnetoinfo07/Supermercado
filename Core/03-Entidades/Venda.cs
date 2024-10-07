using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._03_Entidades;

public class Venda
{
    public int Id { get; set; }
    public int EnderecoId { get; set; }
    public string MetodoPagamento { get; set; }
    public double ValorFinal { get; set; }
}
