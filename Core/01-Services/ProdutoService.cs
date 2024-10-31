using Core._01_Services.Interfaces;
using Core._02_Repository.Interfaces;
using Core.Entidades;
using TrabalhoFinal._02_Repository;

namespace TrabalhoFinal._01_Services;

public class ProdutoService : IProdutoService
{
    private readonly IProdutoRepository _repository;
    public ProdutoService(IProdutoRepository repository)
    {
        _repository = repository;
    }
    public void Adicionar(Produto produto)
    {
        _repository.Adicionar(produto);
    }

    public void Remover(int id)
    {
        _repository.Remover(id);
    }

    public List<Produto> Listar()
    {
        return _repository.Listar();
    }
    public Produto BuscarTimePorId(int id)
    {
        return _repository.BuscarPorId(id);
    }
    public void Editar(Produto editPessoa)
    {
        _repository.Editar(editPessoa);
    }
}
