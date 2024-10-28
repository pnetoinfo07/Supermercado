using Core._03_Entidades;
using Core._03_Entidades.DTO.Venda;

namespace Core._01_Services.Interfaces;

public interface IVendaService
{
    void Adicionar(Venda venda);
    void Remover(int id);
    List<Venda> Listar();
    ReadVendaReciboDTO BuscarVendaPorId(int id);
    void Editar(Venda editPessoa);
}
