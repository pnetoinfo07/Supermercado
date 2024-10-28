using Core.Entidades;

namespace Core._01_Services.Interfaces;

public interface IProdutoService
{
    void Adicionar(Produto produto);
    void Remover(int id);
    List<Produto> Listar();
    Produto BuscarTimePorId(int id);
    void Editar(Produto editPessoa);

}
