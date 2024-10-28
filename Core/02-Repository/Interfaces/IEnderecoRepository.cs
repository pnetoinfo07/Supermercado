using Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._02_Repository.Interfaces;

public interface IEnderecoRepository
{
    void Adicionar(Endereco endereco);
    void Remover(int id);
    void Editar(Endereco endereco);
    List<Endereco> Listar();
    List<Endereco> ListarEnderecoAluno(int usuarioId);
    Endereco BuscarPorId(int id);
}
