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
    public partial class Poligonos : Form
    {
        public Poligonos()
        {
            InitializeComponent();
        }

        public class Poligono
        {

            public float lados;
            public float longitud;
            public float apotema;
            public float perimetro;
            public float area;

            public Poligono(float lados, float longitud)
            {
                this.lados = lados;
                this.longitud = longitud;
                perimetro = lados * longitud;
            }

            public Poligono(float lados, float longitud, float apotema) : this(lados, longitud)
            {
                this.apotema = apotema;
                perimetro = lados * longitud;
                area = perimetro * apotema / 2;
            }

        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            Poligono area = new Poligono(Convert.ToInt32(LadostextBox.Text), Convert.ToInt32(LongitudtextBox.Text));

            AreatextBox.Text =Convert.ToString(area);

            Poligono perimetro = new Poligono(Convert.ToInt32(LadostextBox.Text), Convert.ToInt32(LongitudtextBox.Text), Convert.ToInt32(ApotematextBox.Text));
            PerimetrotextBox.Text = Convert.ToString(perimetro);



        }
    }
}
