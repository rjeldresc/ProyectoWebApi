using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Archivo
    {
        public int IdBanco { get; set; }

        public IFormFile archivoTxtEntrada { get; set; }

    }
}