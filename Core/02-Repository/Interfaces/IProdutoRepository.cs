using Core.Entidades;

namespace Core._02_Repository.Interfaces;

public interface IProdutoRepository
{
    void Adicionar(Produto produto);
    void Remover(int id);
    void Editar(Produto produto);
    List<Produto> Listar();
    Produto BuscarPorId(int id);
    List<Produto> ListarProdutoDoUsuario(int usuarioId);
}
