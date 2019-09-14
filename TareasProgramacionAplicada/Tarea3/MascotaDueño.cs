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
    public partial class MascotaDueño : Form
    {
        public MascotaDueño()
        {
            InitializeComponent();
        }


        public struct Mascota
        {
            public string nombreMascota;
            public string tipoMascota;

            public Mascota(string nombreMascota, string tipoMascota)
            {
                this.nombreMascota = nombreMascota;
                this.tipoMascota = tipoMascota;
            }
        }

        public struct Dueno
        {
            public string NombrePersona;
            public string DireccionPersona;
            public Mascota mascota;

            public Dueno(string nombrePersona, string direccionPersona, string NombreMascota, string TipoMascota)
            {
                NombrePersona = nombrePersona;
                DireccionPersona = direccionPersona;
                mascota = new Mascota(NombreMascota, TipoMascota);
            }
        }
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            List<Dueno> lista = new List<Dueno>();
            lista.Add(new Dueno(NombreDuenoTexbox.Text, DireccionDuenoTextBox.Text, NombreMascotaTextbox.Text, TipoMascotaTextBox.Text));
            MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
