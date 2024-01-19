using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EjercicioForm.Modelo;

namespace EjercicioForm
{
    public partial class Form2 : Form
    {
        string url = "https://dummyjson.com/products";
        //DBApi db = new DBApi();
        public Form2()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            /*var respuesta = await GetHttp();
            MessageBox.Show(respuesta);
            List<Product> lst = JsonConvert.DeserializeObject<List<Product>>(respuesta);
            lista.DataSource = lst;*/

            /*Product[] lst = JsonConvert.DeserializeObject<Product[]>(respuesta);
            lista.DataSource = lst;*/

            /*RestClient cliente = new RestClient("https://dummyjson.com/products");
            string Respuesta;

            RestRequest request = new RestRequest();
            var response = cliente.Get(request);

            Respuesta = response.Content;

            Lista oResultado = JsonConvert.DeserializeObject<Lista>(Respuesta);
            Product oUsuario = oResultado.products[0];*/
            //lista.DataSource = oUsuario;

            /*using (var client = new HttpClient())
            {
                string url = "https://dummyjson.com/products";

                client.DefaultRequestHeaders.Clear();

                var response = client.GetAsync(url).Result;

                var res = response.Content.ReadAsStringAsync().Result;
                dynamic r = JObject.Parse(res);
                //Console.WriteLine(r.products);
                //List<Product> lst = r.products;
                lista.DataSource = r.products;
            }*/
            Get();
        }

        public async void Get()
        {
            using (var client = new HttpClient())
            {
                string url = "https://dummyjson.com/products";

                client.DefaultRequestHeaders.Clear();

                var response = client.GetAsync(url).Result;

                var res = response.Content.ReadAsStringAsync().Result;
                dynamic r = JObject.Parse(res);
                //Console.WriteLine(r.products);
                //List<Product> lst = r.products;
                lista.DataSource = r.products;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if(name.Text == "" && desc.Text == "" && descripcion.Text == "" && price.Text == "" &&
                exist.Text == "" && marca.Text == "" && calif.Text == "" && cat.Text == "")
            {
                MessageBox.Show("Favor de ingresar los datos");
            } else
            {
                MessageBox.Show("Datos guardados con éxito");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (name.Text == "" && desc.Text == "" && descripcion.Text == "" && price.Text == "" &&
                exist.Text == "" && marca.Text == "" && calif.Text == "" && cat.Text == "")
            {
                MessageBox.Show("Favor de ingresar los datos");
            }
            else
            {
                MessageBox.Show("Datos guardados con éxito");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
