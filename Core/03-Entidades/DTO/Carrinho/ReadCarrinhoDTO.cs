using Core.Entidades;

namespace Core._03_Entidades.DTO.Carrinhos
{
    public class ReadCarrinhoDTO
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public Produto Produto { get; set; }

    }
}
