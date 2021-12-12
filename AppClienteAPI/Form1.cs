using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppClienteAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //mostrar 
            cleardgv();
            getAllMarcas();

        }

        public void getAllMarcas()
        {
            ClienteAPI cliente = new ClienteAPI();
            HttpResponseMessage httpResponseMessage = cliente.Find("Marca").Result;
            List<Marca> marcas = httpResponseMessage.Content.ReadAsAsync<List<Marca>>().Result;

            Marca mar = new Marca();
            dgvMarcas.Columns.Add("marcaID", "MarcaID");
            dgvMarcas.Columns.Add("name", "Nombre");
            dgvMarcas.Columns.Add("descripcion", "Descripcion");
            dgvMarcas.Columns.Add("pais", "Pais");

            foreach (Marca ma in marcas)
            {
                dgvMarcas.Rows.Add(ma.marcaID, ma.name, ma.descripcion, ma.pais);
            }
            

        }
        public void cleardgv()
        {
            dgvMarcas.Columns.Clear();
            dgvMarcas.Rows.Clear();
        }


    }
}
