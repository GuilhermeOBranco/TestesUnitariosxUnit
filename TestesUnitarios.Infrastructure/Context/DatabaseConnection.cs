using System;
using Microsoft.EntityFrameworkCore;
using TestesUnitarios.Models.Sistema;
using TestesUnitarios.Models.Usuario;

namespace TestesUnitarios.Infraestructure.Context
{
    public class DatabaseConnection: DbContext
    {
        public DatabaseConnection(DbContextOptions<DatabaseConnection> options) : base(options){}
        public DbSet<Usuario> Usuario {get; set;}
        public DbSet<Perfil> Perfil {get; set;}
        public DbSet<Sistema> Sistema {get; set;}
    }
}