using FrontEnd.UseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd;
public class Sistema
{
    private readonly UsuarioUC _usuarioUC;
    public Sistema(HttpClient cliente)
    {
        _usuarioUC = new UsuarioUC(cliente);
    }
    public void IniciarSistema()
    {
        int resposta = ExibirLogin();
        if(resposta == 2)
        {
            Usuario usuario = CriarUsuario();
            _usuarioUC.CriarProdutoAsync(usuario);
        }
    }
    public int ExibirLogin()
    {
        Console.WriteLine("--------- LOGIN ---------");
        Console.WriteLine("1 - Deseja Fazer Login");
        Console.WriteLine("2 - Deseja se Cadastrar");
        return int.Parse(Console.ReadLine());
    }
    public Usuario CriarUsuario()
    {
        Usuario usuario = new Usuario();
        Console.WriteLine("Digite seu nome: ");
        usuario.nome = Console.ReadLine();
        Console.WriteLine("Digite seu username: ");
        usuario.username = Console.ReadLine();
        Console.WriteLine("Digite seu senha: ");
        usuario.senha = Console.ReadLine();
        Console.WriteLine("Digite seu email: ");
        usuario.email = Console.ReadLine();
        return usuario;
    }
}
