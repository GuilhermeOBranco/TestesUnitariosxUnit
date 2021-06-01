using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestesUnitarios.Models.Usuario;

namespace TestesUnitarios.Api.Controllers
{
    [Controller]
    public class UsuarioController : ControllerBase
    {

        [HttpPost]
        public IActionResult CriarUsuario(Usuario usuario)
        {
            return Ok("Sucesso");
        }

    }
}