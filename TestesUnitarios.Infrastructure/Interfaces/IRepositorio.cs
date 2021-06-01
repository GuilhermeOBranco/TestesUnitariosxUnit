using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestesUnitarios.Infraestructure.Interfaces
{
    public interface IRepositorio<T> where T : class
    {
        Task<T> Adicionar(T objeto);
        Task<T> Atualizar(T objeto);
        Task<List<T>> ListarTodos();
    }
}