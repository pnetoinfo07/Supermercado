using Core._03_Entidades.DTO.Carrinhos;
using Core.Entidades;

namespace Core._01_Services.Interfaces;

public interface ICarrinhoService
{
    void Adicionar(Carrinho carrinho);
    void Remover(int id);
    List<Carrinho> Listar();
    List<ReadCarrinhoDTO> ListarCarrinhoDoUsuario(int usuarioId);
    Carrinho BuscarTimePorId(int id);
    void Editar(Carrinho editPessoa);
}
