using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
//using System.Web.Mvc;
using WebApi.Models;


namespace WebApi.Controllers
{
    public class ArchivoController : ApiController
    {
        [HttpPost]
        [Route("api/CargarArchivo/upload")]
        public async Task<string> uploadFile()
        {
            var idBanco = HttpContext.Current.Request.Form.ToString();

            var ctx = HttpContext.Current;
            
            var root = ctx.Server.MapPath("~/App_Data");
            var provider = 
                new MultipartFormDataStreamProvider(root);
            try
            {
                await Request.Content.ReadAsMultipartAsync(provider);

                foreach (var file in provider.FileData) 
                {
                    var name = file.Headers.ContentDisposition.FileName;
                    name = name.Trim('"');

                    var localFileName = file.LocalFileName;
                    var filePath = Path.Combine(root, name);

                    File.Move(localFileName, filePath);
                }
                //negocio.convertir(idBanco,filePath)
            }
            catch (Exception e)
            {
                return $"error: {e.Message}";
            }

            return "File upload";
        }
    }

}
