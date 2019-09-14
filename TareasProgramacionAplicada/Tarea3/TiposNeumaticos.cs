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
    public partial class TiposNeumaticos : Form
    {
        public TiposNeumaticos()
        {
            InitializeComponent();
        }
        
        //todo: 
        enum neumaticos {Radiales,Diagonales,AutoPortante, DeVerano, Tubetype,tubeless};
        private void Generarbutton_Click(object sender, EventArgs e)
        {
            NeumaticosdataGridView.Rows.Add(neumaticos.Radiales,neumaticos.Diagonales, neumaticos.AutoPortante,neumaticos.DeVerano,neumaticos.Tubetype, neumaticos.tubeless);
        }
    }
}
