using EstuidiantConApi.Models;
using Newtonsoft.Json;

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
    }
}
