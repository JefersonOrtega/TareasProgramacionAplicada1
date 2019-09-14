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
    public partial class InventarioTienda : Form
    {
        public InventarioTienda()
        {
            InitializeComponent();
        }

        public class Inventario
        {
            public string Articulo;
            public string Cantidad;
            public string Tipo;
            public string Costo;
            public string Precio;

            public Inventario()
            {
                Articulo = string.Empty;
                Cantidad = string.Empty;
                Tipo = string.Empty;
                Costo = string.Empty;
                Precio = string.Empty;
            }
        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Inventario inventario = new Inventario();
            inventario.Articulo = ArticulotextBox.Text;
            inventario.Cantidad = CantidadtextBox.Text;
            inventario.Tipo = TipotextBox.Text;
            inventario.Costo = CostotextBox.Text;
            inventario.Precio = PreciotextBox.Text;

            MessageBox.Show("Guardad!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
