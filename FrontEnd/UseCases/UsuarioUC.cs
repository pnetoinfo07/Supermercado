using System.Net.Http.Json;
using System.Text.Json;

namespace FrontEnd.UseCases;

public class UsuarioUC
{
    private readonly HttpClient _httpClient;
    public UsuarioUC(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public List<Usuario> ObterProdutosAsync()
    {
        return _httpClient.GetFromJsonAsync<List<Usuario>>("Usuario/listar-usuario").Result;
    }

    public void CriarProdutoAsync(Usuario usuario)
    {
        var response = _httpClient.PostAsJsonAsync("Usuario/adicionar-usuario", usuario).Result;
    }

    public void AtualizarProdutoAsync(Usuario usuario)
    {
        var response = _httpClient.PutAsJsonAsync($"Usuario/editar-usuario", usuario).Result;
    }

    public void DeletarProdutoAsync(int id)
    {
        var response = _httpClient.DeleteAsync($"Usuario/deletar-usuario/?id={id}").Result;
    }
}
