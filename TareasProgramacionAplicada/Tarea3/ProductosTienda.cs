using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareasProgramacionAplicada.Tarea3
{
    public partial class ProductosTienda : Form
    {
        public ProductosTienda()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        public struct Tienda
        {
            int Id;
            string nombre;
            string tipo;
            string marca;
            string precio;

            public Tienda(int id, string nombre, string tipo, string marca, string precio)
            {
                Id = id;
                this.nombre = nombre;
                this.tipo = tipo;
                this.marca = marca;
                this.precio = precio;
            }
        }
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            List<Tienda> tienda = new List<Tienda>();
            tienda.Add(new Tienda(Convert.ToInt32(IdProductoTextbox.Text), NombreTextbox.Text, TipoTextbox.Text, MarcaTextbox.Text, PrecioTextbox.Text));
            MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
