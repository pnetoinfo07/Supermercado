using Core.Entidades;

namespace Core._02_Repository.Interfaces;

public interface IUsuarioRepository
{
    void Adicionar(Usuario usuario);
    void Remover(int id);
    void Editar(Usuario usuario);
    List<Usuario> Listar();
    Usuario BuscarPorId(int id);
}
