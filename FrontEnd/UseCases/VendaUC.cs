using System.Net.Http.Json;

namespace FrontEnd.UseCases
{
    public class VendaUC
    {
        private readonly HttpClient _client;
        public VendaUC(HttpClient cliente)
        {
            _client = cliente;
        }
        public Venda CadastrarVenda(Venda venda)
        {
            HttpResponseMessage response = _client.PostAsJsonAsync("Venda/adicionar-venda", venda).Result;

            Venda vendaCadastrada = response.Content.ReadFromJsonAsync<Venda>().Result;
            return vendaCadastrada;
        }

        public ReadVendaReciboDTO BuscarVendaPorId(int id)
        {
            return _client.GetFromJsonAsync<ReadVendaReciboDTO>("Venda/buscar-por-id?id=" + id).Result;
        }
    }
}
