using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestesUnitarios.Infraestructure.Context;
using TestesUnitarios.Infraestructure.Interfaces;

namespace TestesUnitarios.Infraestructure.Repository
{
    public class Repositorio<T> : IRepositorio<T> where T : class
    {
        private readonly DatabaseConnection _context;
        private readonly DbSet<T> _dataSet;

        public Repositorio(DatabaseConnection context)
        {
            _context = context;
            _dataSet = _context.Set<T>();
        }
        public async Task<T> Adicionar(T objeto)
        {
            try
            {
                _dataSet.Add(objeto);
                await _context.SaveChangesAsync();
                return objeto;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public async Task<T> Atualizar(T objeto)
        {
            try
            {
                _dataSet.Update(objeto);
                await _context.SaveChangesAsync();
                return objeto;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public async Task<List<T>> ListarTodos()
        {
            try
            {
                return await _dataSet.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}