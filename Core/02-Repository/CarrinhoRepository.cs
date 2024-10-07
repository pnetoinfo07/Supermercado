using Core._03_Entidades.DTO.Carrinhos;
using Core.Entidades;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Collections.Generic;
using System.Data.SQLite;

namespace TrabalhoFinal._02_Repository;

public class CarrinhoRepository
{
    private readonly string ConnectionString;
    private readonly ProdutoRepository _repositoryProduto;
    private readonly UsuarioRepository _repositoryUsuario;
    private readonly EnderecoRepository _repositoryEndereco;
    public CarrinhoRepository(string connectioString)
    {
        ConnectionString = connectioString;
        _repositoryProduto = new ProdutoRepository(connectioString);
        _repositoryUsuario = new UsuarioRepository(connectioString);
        _repositoryEndereco = new EnderecoRepository(connectioString);
    }
    public void Adicionar(Carrinho carrinho)
    {
        using var connection = new SQLiteConnection(ConnectionString);
        connection.Insert<Carrinho>(carrinho);
    }
    public void Remover(int id)
    {
        using var connection = new SQLiteConnection(ConnectionString);
        Carrinho carrinho = BuscarPorId(id);
        connection.Delete<Carrinho>(carrinho);
    }
    public void Editar(Carrinho carrinho)
    {
        using var connection = new SQLiteConnection(ConnectionString);
        connection.Update<Carrinho>(carrinho);
    }
    public List<Carrinho> Listar()
    {
        using var connection = new SQLiteConnection(ConnectionString);
        List<Carrinho> list = connection.GetAll<Carrinho>().ToList();
        //TransformarListaCarrinhoEmCarrinhoDTO();
       return list;
    }

    private List<ReadCarrinhoDTO> TransformarListaCarrinhoEmCarrinhoDTO(List<Carrinho> list)
    {
        List<ReadCarrinhoDTO> listDTO = new List<ReadCarrinhoDTO>();

        foreach (Carrinho car in list)
        {
            ReadCarrinhoDTO readCarrinho = new ReadCarrinhoDTO();
            readCarrinho.Produto = _repositoryProduto.BuscarPorId(car.ProdutoId);
            readCarrinho.Usuario = _repositoryUsuario.BuscarPorId(car.UsuarioId);
            listDTO.Add(readCarrinho);
        }
        return listDTO;
    }

    public List<ReadCarrinhoDTO> ListarCarrinhoDoUsuario(int usuarioId)
    {
        using var connection = new SQLiteConnection(ConnectionString);
        List<Carrinho> list = connection.Query<Carrinho>($"SELECT Id, UsuarioId, ProdutoId FROM Carrinhos WHERE UsuarioId = {usuarioId}").ToList();
        List<ReadCarrinhoDTO> listDTO = TransformarListaCarrinhoEmCarrinhoDTO(list);
        return listDTO;
    }
    public Carrinho BuscarPorId(int id)
    {
        using var connection = new SQLiteConnection(ConnectionString);
        return connection.Get<Carrinho>(id);
    }
}
