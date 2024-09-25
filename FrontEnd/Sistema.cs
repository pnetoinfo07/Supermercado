using Core._03_Entidades.DTO.Usuario;
using Core.Entidades;
using FrontEnd.UseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd;
public class Sistema
{
    private static Usuario UsuarioLogado { get; set; }
    private readonly UsuarioUC _usuarioUC;
    private readonly ProdutoUC _produtoUC;
    public Sistema(HttpClient cliente)
    {
        _usuarioUC = new UsuarioUC(cliente);
        _produtoUC = new ProdutoUC(cliente);
    }
    public void IniciarSistema()
    {
        int resposta = -1;
        while (resposta != 0)
        {
            if (UsuarioLogado == null)
            {
                resposta = ExibirLogin();

                if (resposta == 1)
                {
                    FazerLogin();
                }
                else if (resposta == 2)
                {
                    Usuario usuario = CriarUsuario();
                    _usuarioUC.CadastrarUsuario(usuario);
                    Console.WriteLine("Usuário cadastrado com sucesso");
                }
                else if (resposta == 3)
                {
                    List<Usuario> usuarios = _usuarioUC.ListarUsuarios();
                    foreach (Usuario u in usuarios)
                    {
                        Console.WriteLine(u.ToString());
                    }
                }
            }
            else
            {
                ExibirMenuPrincipal();
            }
        }
    }
    public int ExibirLogin()
    {
        Console.WriteLine("--------- LOGIN ---------");
        Console.WriteLine("1 - Deseja Fazer Login");
        Console.WriteLine("2 - Deseja se Cadastrar");
        Console.WriteLine("3 - Listar Usuario Cadastrados");
        return int.Parse(Console.ReadLine());
    }
    public Usuario CriarUsuario()
    {
        Usuario usuario = new Usuario();
        Console.WriteLine("Digite seu nome: ");
        usuario.Nome = Console.ReadLine();
        Console.WriteLine("Digite seu username: ");
        usuario.Username = Console.ReadLine();
        Console.WriteLine("Digite seu senha: ");
        usuario.Senha = Console.ReadLine();
        Console.WriteLine("Digite seu email: ");
        usuario.Email = Console.ReadLine();
        return usuario;
    }
    public Produto CriarProduto()
    {
        Produto usuario = new Produto();
        Console.WriteLine("Digite seu nome: ");
        usuario.Nome = Console.ReadLine();
        Console.WriteLine("Digite seu preco: ");
        usuario.Preco = double.Parse(Console.ReadLine());
        return usuario;
    }
    public void FazerLogin()
    {
        Console.WriteLine("Digite seu username: ");
        string username = Console.ReadLine();
        Console.WriteLine("Digite sua senha: ");
        string senha = Console.ReadLine();
        UsuarioLoginDTO usuDTO = new UsuarioLoginDTO
        {
            Username = username,
            Senha = senha
        };
        Usuario usuario = _usuarioUC.FazerLogin(usuDTO);
        if (usuario == null)
        {
            Console.WriteLine("Usuário ou senha inválidos!!!");
        }
        UsuarioLogado = usuario;
    }
    public void ExibirMenuPrincipal()
    {
        Console.WriteLine("1 - Listar Produtos");
        Console.WriteLine("2 - Cadastrar Produto");
        Console.WriteLine("3 - Realizar uma compra");
        Console.WriteLine("Qual operação deseja realizar?");
        int resposta = int.Parse(Console.ReadLine());

        if (resposta == 1)
        {
            List<Produto> produtos = _produtoUC.ListarProduto();
            foreach (Produto u in produtos)
            {
                Console.WriteLine(u.ToString());
            }
        }
        else if (resposta == 2)
        {
            Produto produto = CriarProduto();
            _produtoUC.CadastrarProduto(produto);
            Console.WriteLine("Usuário cadastrado com sucesso");
        }
    }
}
