using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApi.Data;
using WebApi.Models;


namespace WebApi.Controllers
{
    public class UsuarioController : ApiController
    {
        // GET: Usuario
        public List<Usuario> Get()
        {
            return UsuarioData.Listar();
        }


        public bool Post([FromBody] Usuario usuario)
        { 
            return false; 
        }

    }
}
