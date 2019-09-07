using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasProgramacionAplicada.Tarea2
{
    /// <summary>
    /// Hacer un programa que muestre la hora
    ///del día en formato AM/FM seguida del
    ///año, el día y el mes actual.
    /// </summary>
    class FechaHora
    {
        public FechaHora() { }

        public void mostrar()
        {
            String formato;

            formato = String.Format("La hora y fecha es: {0:hh tt yyyy dd M}", DateTime.Now);
            Console.WriteLine(formato);
        }

    }
}
