using Core._03_Entidades;
using Core._03_Entidades.DTO.Venda;

namespace Core._02_Repository.Interfaces;

public interface IVendaRepository
{
    void Adicionar(Venda venda);
    void Remover(int id);
    void Editar(Venda venda);
    List<Venda> Listar();
    ReadVendaReciboDTO BuscarPorId(int id);
}
