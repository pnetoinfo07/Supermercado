using AutoMapper;
using Core._03_Entidades.DTO.Usuarios;
using Core.Entidades;
using Microsoft.AspNetCore.Mvc;
using TrabalhoFinal._01_Services;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{
    private readonly UsuarioService _service;
    private readonly IMapper _mapper;
    public UsuarioController(IConfiguration config, IMapper mapper)
    {
        string _config = config.GetConnectionString("DefaultConnection");
        _service = new UsuarioService(_config);
        _mapper = mapper;
    }
    [HttpPost("adicionar-usuario")]
    public void AdicionarAluno(Usuario usuarioDTO)
    {
        _service.Adicionar(usuarioDTO);
    }
    [HttpPost("fazer-login")]
    public Usuario FazerLogin(UsuarioLoginDTO usuarioLogin)
    {
        Usuario usuario = _service.FazerLogin(usuarioLogin);
        return usuario;
    }
    [HttpGet("listar-usuario")]
    public List<Usuario> ListarAluno()
    {
        return _service.Listar();
    }
    [HttpPut("editar-usuario")]
    public void EditarUsuario(Usuario p)
    {
        _service.Editar(p);
    }
    [HttpDelete("deletar-usuario")]
    public void DeletarUsuario(int id)
    {
        _service.Remover(id);
    }
}
