using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd;
public class Sistema
{
    public void IniciarSistema()
    {
        int resposta = ExibirLogin();
    }
    public int ExibirLogin()
    {
        Console.WriteLine("--------- LOGIN ---------");
        Console.WriteLine("1 - Deseja Fazer Login");
        Console.WriteLine("2 - Deseja se Cadastrar");
        return int.Parse(Console.ReadLine());
    }
}
