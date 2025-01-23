using Microsoft.AspNetCore.Mvc;
using CorreoApiServer.Models;
using System.IO;

namespace CorreoApiServer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CorreosController : ControllerBase
    {
        private readonly string _directoryPath = "C:\\Users\\brendalopes\\source\\repos\\CorreoDistribuidoREST\\CorreoApiServer\\CorreosPendientes";

        public CorreosController()
        {
            if (!Directory.Exists(_directoryPath))
            {
                Directory.CreateDirectory(_directoryPath);
            }
        }

        [HttpPost]
        public IActionResult CrearCorreo([FromBody] Correo correo)
        {
            if (correo == null || string.IsNullOrWhiteSpace(correo.Destinatario))
            {
                return BadRequest("El correo es inválido.");
            }

            // Guardar el correo como archivo JSON
            string fileName = $"{Guid.NewGuid()}.json";
            string filePath = Path.Combine(_directoryPath, fileName);

            var json = System.Text.Json.JsonSerializer.Serialize(correo);
            System.IO.File.WriteAllText(filePath, json);

            return Ok(new { message = "Correo guardado correctamente", filePath });
        }
    }
}
