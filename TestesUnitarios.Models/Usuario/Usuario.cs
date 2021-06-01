using System;

namespace TestesUnitarios.Models.Usuario
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int PerfilId { get; set; }
    }
}