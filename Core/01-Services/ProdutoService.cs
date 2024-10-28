using Core._02_Repository.Interfaces;
using Core.Entidades;
using TrabalhoFinal._02_Repository;

namespace TrabalhoFinal._01_Services;

public class ProdutoService
{
    public IProdutoRepository repository { get; set; }
    public ProdutoService(string _config)
    {
        repository = new ProdutoRepository(_config);
    }
    public void Adicionar(Produto produto)
    {
        repository.Adicionar(produto);
    }

    public void Remover(int id)
    {
        repository.Remover(id);
    }

    public List<Produto> Listar()
    {
        return repository.Listar();
    }
    public Produto BuscarTimePorId(int id)
    {
        return repository.BuscarPorId(id);
    }
    public void Editar(Produto editPessoa)
    {
        repository.Editar(editPessoa);
    }
}
