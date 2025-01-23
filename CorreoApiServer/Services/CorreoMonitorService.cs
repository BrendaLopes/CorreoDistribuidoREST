using System.IO;
using System.Timers;
using CorreoApiServer.Models;

namespace CorreoApiServer.Services
{
    public class CorreoMonitorService
    {
        private readonly string _directoryPath = "C:\\Users\\brendalopes\\source\\repos\\CorreoDistribuidoREST\\CorreoApiServer\\CorreosPendientes";
        private readonly string _processedDirectory = "C:\\Users\\brendalopes\\source\\repos\\CorreoDistribuidoREST\\CorreoApiServer\\CorreosProcesados";
        private readonly System.Timers.Timer _timer;

        public CorreoMonitorService()
        {
            if (!Directory.Exists(_processedDirectory))
            {
                Directory.CreateDirectory(_processedDirectory);
            }

            _timer = new System.Timers.Timer(10000); // Revisa cada 10 segundos
            _timer.Elapsed += ProcessFiles;
            _timer.Start();
        }

        private void ProcessFiles(object sender, ElapsedEventArgs e)
        {
            var files = Directory.GetFiles(_directoryPath, "*.json");

            foreach (var file in files)
            {
                var content = File.ReadAllText(file);
                var correo = System.Text.Json.JsonSerializer.Deserialize<Correo>(content);

                // Simula el envío del correo (puedes implementar SMTP aquí)
                Console.WriteLine($"Correo enviado a {correo.Destinatario}: {correo.Asunto}");

                // Mover a procesados
                var destPath = Path.Combine(_processedDirectory, Path.GetFileName(file));
                File.Move(file, destPath);
            }
        }
    }
}
