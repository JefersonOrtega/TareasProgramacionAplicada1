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
    public partial class EjerciciosTarea3 : Form
    {
        public EjerciciosTarea3()
        {
            InitializeComponent();
        }

        private void Capitulo9ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EstructuraParaGuardarProductosDeUnaTiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductosTienda productosTienda = new ProductosTienda();
            productosTienda.MdiParent = this;
            productosTienda.Show();
        }

        private void InformaciónDeUnaMascotaYSuDueñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MascotaDueño mascotaDueño = new MascotaDueño();
            mascotaDueño.MdiParent = this;
            mascotaDueño.Show();
        }

        private void EnumeracionDeNeumaticosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TiposNeumaticos tiposNeumaticos = new TiposNeumaticos();
            tiposNeumaticos.MdiParent = this;
            tiposNeumaticos.Show();
        }

        private void InventarioDeTiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventarioTienda inventarioTienda = new InventarioTienda();
            inventarioTienda.MdiParent = this;
            inventarioTienda.Show();
        }

        private void EstudiantesEscuelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClaseEstudiantes claseEstudiantes = new ClaseEstudiantes();
            claseEstudiantes.MdiParent = this;
            claseEstudiantes.Show();
        }

        private void ClasePoligonoConSobrecargaDeConstructoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Poligonos poligonos = new Poligonos();
            poligonos.MdiParent = this;
            poligonos.Show();
        }

        private void PoligonoConPropiedadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PropiedadesPoligono propiedadesPoligono = new PropiedadesPoligono();
            propiedadesPoligono.MdiParent = this;
            propiedadesPoligono.Show();
        }

        private void ToStringPOligonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToStringPoligono toStringPoligono = new ToStringPoligono();
            toStringPoligono.MdiParent = this;
            toStringPoligono.Show();
        }
    }
}
