
namespace FrontEnd
{
    public class ReadCarrinhoDTO
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public Produto Produto { get; set; }

        public override string ToString()
        {
            return $"Usuario {Usuario.Nome} - Produto : {Produto.Nome} - Preço: {Produto.Preco}";
        }
        public string ToStringProduto()
        {
            return $"Produto : {Produto.Nome} - Preço: {Produto.Preco}";
        }
    }
}
