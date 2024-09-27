using System.Net.Http.Json;

namespace FrontEnd.UseCases;

public class ProdutoUC
{
    private readonly HttpClient _client;
    public ProdutoUC(HttpClient cliente)
    {
        _client = cliente;
    }
    public List<Produto> ListarProduto()
    {
        return _client.GetFromJsonAsync<List<Produto>>("Produto/listar-produto").Result;
    }
    public void CadastrarProduto(Produto produto)
    {
        HttpResponseMessage response = _client.PostAsJsonAsync("Produto/adicionar-produto", produto).Result;
    }
}
