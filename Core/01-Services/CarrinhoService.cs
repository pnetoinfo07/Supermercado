using Core._01_Services.Interfaces;
using Core._02_Repository.Interfaces;
using Core._03_Entidades.DTO.Carrinhos;
using Core.Entidades;
using TrabalhoFinal._02_Repository;

namespace TrabalhoFinal._01_Services;

public class CarrinhoService : ICarrinhoService
{
    private readonly ICarrinhoRepository _repository;
    public CarrinhoService(ICarrinhoRepository repository)
    {
        _repository = repository;
    }
    public void Adicionar(Carrinho carrinho)
    {
        _repository.Adicionar(carrinho);
    }

    public void Remover(int id)
    {
        _repository.Remover(id);
    }

    public List<Carrinho> Listar()
    {
        return _repository.Listar();
    }

    public List<ReadCarrinhoDTO> ListarCarrinhoDoUsuario(int usuarioId)
    {
        return _repository.ListarCarrinhoDoUsuario(usuarioId);
    }
    public Carrinho BuscarTimePorId(int id)
    {
        return _repository.BuscarPorId(id);
    }
    public void Editar(Carrinho editPessoa)
    {
        _repository.Editar(editPessoa);
    }
}
