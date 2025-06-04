using EstuidiantConApi.Models;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace EstuidiantConApi
{
    public partial class Form1 : Form
    {
        public string baseUrl = "https://localhost:7212/api/Estudiantes";
        HttpClient Cle = new HttpClient();
        public Form1()
        {
            InitializeComponent();
            CargarInfo();
        }
        public async void CargarInfo()
        {
            var response = await Cle.GetAsync(baseUrl);
            var json = await response.Content.ReadAsStringAsync();
            var list = JsonConvert.DeserializeObject<List<Estudinate>>(json);
            dgvEstudiante.DataSource = list;
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            var estudiante = new Estudinate
            {

                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Edad = int.Parse(txtEdad.Text),
                Email = txtEmail.Text
            };
            var response = await Cle.PostAsJsonAsync(baseUrl, estudiante);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Agregardo Correctamente", "Exito");
                CargarInfo();
            }
            else
            {
                var error = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Error: {error}");
            }
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            if (dgvEstudiante.CurrentRow != null)
            {
                var estudiante = (Estudinate)dgvEstudiante.CurrentRow.DataBoundItem;
                estudiante.Nombre = txtNombre.Text;
                estudiante.Apellido = txtApellido.Text;
                estudiante.Edad = int.Parse(txtEdad.Text);
                estudiante.Email = txtEmail.Text;
                var response = Cle.PutAsJsonAsync($"{baseUrl}/{estudiante.IdEstudiante}", estudiante).Result;
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Actualizado Correctamente", "Exito");
                    CargarInfo();
                }
                else
                {
                    var error = response.Content.ReadAsStringAsync().Result;
                    MessageBox.Show($"Error: {error}");
                }

            }
            else
            {
                MessageBox.Show("Seleccione un estudiante para actualizar", "Error");
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEstudiante.CurrentRow != null)
            {
                var estudiante = (Estudinate)dgvEstudiante.CurrentRow.DataBoundItem;
                var response = await Cle.DeleteAsync($"{baseUrl}/{estudiante.IdEstudiante}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Eliminado Correctamente", "Exito");
                    CargarInfo();
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error: {error}");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un estudiante para eliminar", "Error");
            }
        }
    }
}

