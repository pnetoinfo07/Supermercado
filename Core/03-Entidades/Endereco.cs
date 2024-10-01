using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entidades;

public class Endereco
{
    public int Id { get; set; }
    public string Rua { get; set; }
    public string Bairro { get; set; }
    public int Numero { get; set; }
    public int UsuarioId { get; set; }
}

