using Core._02_Repository.Interfaces;
using Core._03_Entidades;
using Core._03_Entidades.DTO.Venda;
using Core.Entidades;
using Dapper.Contrib.Extensions;
using System.Data.SQLite;

namespace TrabalhoFinal._02_Repository;

public class VendaRepository : IVendaRepository
{
    private readonly string ConnectionString;
    private readonly ICarrinhoRepository _repositoryCarrinho;
    private readonly IUsuarioRepository _repositoryUsuario;
    private readonly IEnderecoRepository _repositoryEndereco;
    public VendaRepository(string connectioString)
    {
        ConnectionString = connectioString;
        _repositoryCarrinho = new CarrinhoRepository(connectioString);
        _repositoryUsuario = new UsuarioRepository(connectioString);
        _repositoryEndereco = new EnderecoRepository(connectioString);
    }
    public void Adicionar(Venda venda)
    {
        using var connection = new SQLiteConnection(ConnectionString);
        connection.Insert<Venda>(venda);
    }
    public void Remover(int id)
    {
        using var connection = new SQLiteConnection(ConnectionString);
        Venda venda = new Venda();//BuscarPorId(id);
        connection.Delete<Venda>(venda);
    }
    public void Editar(Venda venda)
    {
        using var connection = new SQLiteConnection(ConnectionString);
        connection.Update<Venda>(venda);
    }
    public List<Venda> Listar()
    {
        using var connection = new SQLiteConnection(ConnectionString);
        return connection.GetAll<Venda>().ToList();
    }
    public ReadVendaReciboDTO BuscarPorId(int id)
    {
        using var connection = new SQLiteConnection(ConnectionString);
        Venda v = connection.Get<Venda>(id);
        ReadVendaReciboDTO vendaDTO = new ReadVendaReciboDTO();
        vendaDTO.Endereco = _repositoryEndereco.BuscarPorId(v.EnderecoId);
        vendaDTO.NomeUsuario = _repositoryUsuario.BuscarPorId(vendaDTO.Endereco.UsuarioId).Nome;
        vendaDTO.MetodoPagamento = v.MetodoPagamento;
        vendaDTO.Produtos = _repositoryCarrinho.ListarCarrinhoDoUsuario(vendaDTO.Endereco.UsuarioId);
        vendaDTO.ValorFinal = v.ValorFinal;
        return vendaDTO;
    }
}
