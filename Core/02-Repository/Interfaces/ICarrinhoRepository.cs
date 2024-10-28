using Core._03_Entidades.DTO.Carrinhos;
using Core.Entidades;

namespace Core._02_Repository.Interfaces;

public interface ICarrinhoRepository
{
    void Adicionar(Carrinho carrinho);
    void Remover(int id);
    void Editar(Carrinho carrinho);
    List<Carrinho> Listar();
    List<ReadCarrinhoDTO> ListarCarrinhoDoUsuario(int usuarioId);
    Carrinho BuscarPorId(int id);
}
