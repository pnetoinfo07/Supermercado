using AutoMapper;
using Core._01_Services.Interfaces;
using Core.Entidades;
using Microsoft.AspNetCore.Mvc;
using TrabalhoFinal._01_Services;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class EnderecoController : ControllerBase
{
    private readonly IEnderecoService _service;
    private readonly IMapper _mapper;
    public EnderecoController(IMapper mapper, IEnderecoService service)
    {
        _mapper = mapper;
        _service = service;
    }
    [HttpPost("adicionar-endereco")]
    public Endereco AdicionarAluno(Endereco enderecoDTO)
    {
        Endereco endereco = _mapper.Map<Endereco>(enderecoDTO);
        _service.Adicionar(endereco);
         return endereco;
    }
    [HttpGet("listar-endereco-usuario")]
    public List<Endereco> ListarEnderecoAluno([FromQuery]int usuarioId)
    {
        return _service.ListarEnderecoAluno(usuarioId);
    }
    [HttpPut("editar-endereco")]
    public void EditarEndereco(Endereco p)
    {
        _service.Editar(p);
    }
    [HttpDelete("deletar-endereco")]
    public void DeletarEndereco(int id)
    {
        _service.Remover(id);
    }
}
