using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_app
{
    public partial class Articulos : Form
    {
        public Articulos()
        {
            InitializeComponent();
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void txtAgregar_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio(); // Clase de BD.
            dgvArticulos.DataSource = negocio.listar(); //recibe un origen de datos y lo modela en la tabla. 
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
