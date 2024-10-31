using Core._01_Services.Interfaces;
using Core._02_Repository.Interfaces;
using Core.Entidades;
using TrabalhoFinal._02_Repository;

namespace TrabalhoFinal._01_Services;

public class EnderecoService : IEnderecoService
{
    private readonly IEnderecoRepository _repository;
    public EnderecoService(IEnderecoRepository repository)
    {
        _repository = repository;
    }
    public void Adicionar(Endereco endereco)
    {
        _repository.Adicionar(endereco);
    }

    public void Remover(int id)
    {
        _repository.Remover(id);
    }

    public List<Endereco> Listar()
    {
        return _repository.Listar();
    }
    public List<Endereco> ListarEnderecoAluno(int usuarioId)
    {
        return _repository.ListarEnderecoAluno(usuarioId);
    }
    public Endereco BuscarTimePorId(int id)
    {
        return _repository.BuscarPorId(id);
    }
    public void Editar(Endereco editPessoa)
    {
        _repository.Editar(editPessoa);
    }
}
