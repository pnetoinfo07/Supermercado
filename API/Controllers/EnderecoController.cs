using AutoMapper;
using Core.Entidades;
using Microsoft.AspNetCore.Mvc;
using TrabalhoFinal._01_Services;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class EnderecoController : ControllerBase
{
    private readonly EnderecoService _service;
    private readonly IMapper _mapper;
    public EnderecoController(IConfiguration config, IMapper mapper)
    {
        string _config = config.GetConnectionString("DefaultConnection");
        _service = new EnderecoService(_config);
        _mapper = mapper;
    }
    [HttpPost("adicionar-endereco")]
    public Usuario AdicionarAluno(Endereco enderecoDTO)
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
