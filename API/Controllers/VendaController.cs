using AutoMapper;
using Core._01_Services.Interfaces;
using Core._03_Entidades;
using Core._03_Entidades.DTO.Venda;
using Microsoft.AspNetCore.Mvc;
using TrabalhoFinal._01_Services;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class VendaController : ControllerBase
{
    private readonly IVendaService _service;
    private readonly IMapper _mapper;
    public VendaController(IConfiguration config, IMapper mapper)
    {
        string _config = config.GetConnectionString("DefaultConnection");
        _service = new VendaService(_config);
        _mapper = mapper;
    }
    [HttpPost("adicionar-venda")]
    public Venda AdicionarAluno(Venda vendaDTO)
    {
        Venda venda = _mapper.Map<Venda>(vendaDTO);
        _service.Adicionar(venda);
        return venda;
    }
    [HttpGet("listar-venda")]
    public List<Venda> ListarAluno()
    {
        return _service.Listar();
    }
    [HttpGet("buscar-por-id")]
    public ReadVendaReciboDTO BuscarVendaPorId(int id)
    {
        return _service.BuscarVendaPorId(id);
    }
    [HttpPut("editar-venda")]
    public void EditarVenda(Venda p)
    {
        _service.Editar(p);
    }
    [HttpDelete("deletar-venda")]
    public void DeletarVenda(int id)
    {
        _service.Remover(id);
    }
}
