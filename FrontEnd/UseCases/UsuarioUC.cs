using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FrontEnd.UseCases
{
    public class UsuarioUC
    {
        public async void ListarUsuarios()
        {
            string apiURL = "https://localhost:7096/Usuario/listar-usuario";

            using HttpClient cliente = new HttpClient();
            HttpResponseMessage response = await cliente.GetAsync(apiURL);
            string resposta = await response.Content.ReadAsStringAsync();
            List<Usuario> usu = JsonSerializer.Deserialize<List<Usuario>>(resposta);
        }
        public async void CadastrarUsuario(Usuario usuario)
        {
            string apiURL = "https://localhost:7096/Usuario/adicionar-usuario";
            using HttpClient cliente = new HttpClient();
            string jsonRequest = JsonSerializer.Serialize(usuario);
            HttpResponseMessage response = await cliente.PostAsJsonAsync(apiURL, jsonRequest);            
        }
    }
}
