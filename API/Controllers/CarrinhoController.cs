using AutoMapper;
using Core._01_Services.Interfaces;
using Core._03_Entidades.DTO.Carrinhos;
using Core.Entidades;
using Microsoft.AspNetCore.Mvc;
using TrabalhoFinal._01_Services;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class CarrinhoController : ControllerBase
{
    private readonly ICarrinhoService _service;
    private readonly IMapper _mapper;
    public CarrinhoController(IMapper mapper, ICarrinhoService service)
    {
        _mapper = mapper;
        _service = service;
    }
    [HttpPost("adicionar-carrinho")]
    public void AdicionarAluno(Carrinho carrinhoDTO)
    {
        Carrinho carrinho = _mapper.Map<Carrinho>(carrinhoDTO);
        _service.Adicionar(carrinho);
    }
    [HttpGet("listar-carrinho")]
    public List<Carrinho> ListarAluno()
    {
        return _service.Listar();
    }
    [HttpGet("listar-carrinho-do-usuario")]
    public List<ReadCarrinhoDTO> ListarCarrinhoDoUsuario([FromQuery]int usuarioId)
    {
        return _service.ListarCarrinhoDoUsuario(usuarioId);
    }
    [HttpPut("editar-carrinho")]
    public void EditarCarrinho(Carrinho p)
    {
        _service.Editar(p);
    }
    [HttpDelete("deletar-carrinho")]
    public void DeletarCarrinho(int id)
    {
        _service.Remover(id);
    }
}
