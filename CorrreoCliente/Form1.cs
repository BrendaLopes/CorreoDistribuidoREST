using System.Net.Http;
using System.Net.Http.Json;
using CorreoCliente;

namespace CorrreoCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGuardarCorreo_Click(object sender, EventArgs e)
        {
            // Crear un objeto Correo
            var correo = new Correo
            {
                Destinatario = txtDestinatario.Text,
                Asunto = txtAsunto.Text,
                Mensaje = txtMensaje.Text,
                FechaCreacion = DateTime.Now
            };

            // Validar los campos
            if (string.IsNullOrWhiteSpace(correo.Destinatario) ||
                string.IsNullOrWhiteSpace(correo.Asunto) ||
                string.IsNullOrWhiteSpace(correo.Mensaje))
            {
                lblEstado.Text = "Todos los campos son obligatorios.";
                return;
            }

            // Enviar el correo al servidor usando la API REST
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7098/api/");

                try
                {
                    // Realizar la solicitud POST
                    var response = await client.PostAsJsonAsync("correos", correo);

                    if (response.IsSuccessStatusCode)
                    {
                        lblEstado.Text = "Correo guardado correctamente.";
                        LimpiarCampos();
                    }
                    else
                    {
                        lblEstado.Text = "Error al guardar el correo en el servidor.";
                    }
                }
                catch (Exception ex)
                {
                    lblEstado.Text = $"Error: {ex.Message}";
                }
            }
        }

        // Método para limpiar los campos después de guardar
        private void LimpiarCampos()
        {
            txtDestinatario.Text = "";
            txtAsunto.Text = "";
            txtMensaje.Text = "";
        }


    }
}
