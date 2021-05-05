using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace Intech.Ferramentas.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VersaoController : ControllerBase
    {
        [HttpPost("[action]"), DisableRequestSizeLimit]
        public IActionResult Enviar([FromForm] FileUploadEntidade files)
        {
            try
            {
                var file = files.File;

                var diretorioUpload = Path.Combine(Environment.CurrentDirectory, "Upload");

                if (!Directory.Exists(diretorioUpload))
                    Directory.CreateDirectory(diretorioUpload);

                if (file.Length > 0)
                {
                    string fileName = file.FileName;

                    string fullPath = Path.Combine("Upload", fileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                    return Ok($"Arquivo enviado com sucesso.");
                }

                return Ok("Nenhum arquivo enviado");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }

    public class FileUploadEntidade
    {
        public IFormFile File { get; set; }
        public string source { get; set; }
        public long Size { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Extension { get; set; }
    }
}
