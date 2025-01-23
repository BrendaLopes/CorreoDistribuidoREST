namespace CorreoApiServer.Models
{
    public class Correo
    {
        public string Destinatario { get; set; }
        public string Asunto { get; set; }
        public string Mensaje { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}

