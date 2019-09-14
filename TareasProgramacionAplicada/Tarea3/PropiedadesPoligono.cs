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
    public partial class PropiedadesPoligono : Form
    {
        public PropiedadesPoligono()
        {
            InitializeComponent();
        }

        public class Poligono
        {

            public float lados
            {
                get
                {
                    return lados;
                }
                set
                {
                    if (value <= 0) lados = 1; else lados = value;
                }

            }
            public float longitud
            {
                get
                {
                    return longitud;
                }
                set
                {
                    if (value <= 0) longitud = 1; else longitud = value;
                }
            }
            public float apotema
            {
                get
                {
                    return apotema;
                }
                set
                {
                    if (value <= 0) apotema= 1; else apotema = value;
                }
            }
            public float perimetro
            {
                get
                {
                    return perimetro;
                }
                set
                {
                    if (value <= 0) perimetro = 1; else perimetro = value;
                }
            }
            public float area
            {
                get
                {
                    return area;
                }
                set
                {
                    if (value <= 0) area = 1; else area = value;
                }
            }

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

            AreatextBox.Text = Convert.ToString(area);

            Poligono perimetro = new Poligono(Convert.ToInt32(LadostextBox.Text), Convert.ToInt32(LongitudtextBox.Text), Convert.ToInt32(ApotematextBox.Text));
            PerimetrotextBox.Text = Convert.ToString(perimetro);

        }
    }
}
