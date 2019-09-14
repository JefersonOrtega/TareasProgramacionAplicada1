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
    public partial class ClaseEstudiantes : Form
    {
        public ClaseEstudiantes()
        {
            InitializeComponent();
        }

        public class Estudiante
        {
            public int id;
            public string nombre;
            public string apellido;
            public string grado;
            public int edad;

            public Estudiante()
            {
                id = 0;
                nombre = string.Empty;
                apellido = string.Empty;
                grado = string.Empty;
                edad = 0;
            }
        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante();
            estudiante.id = Convert.ToInt32(IdtextBox.Text);
            estudiante.nombre = NombretextBox.Text;
            estudiante.apellido = ApellidotextBox.Text;
            estudiante.grado = GradotextBox.Text;
            estudiante.edad = Convert.ToInt32(EdadtextBox.Text);

            MessageBox.Show("Guardad!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
