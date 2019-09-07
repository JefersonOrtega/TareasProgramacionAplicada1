using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasProgramacionAplicada.Tarea1
{
    class TransformarCF
    {
        public TransformarCF() { }

        public void centiFahr()
        {
            string valor;
            float centigrados, fahrenheit;

            Console.WriteLine("Digite los grados centigrados a convertir");
            valor = Console.ReadLine();
            centigrados = Convert.ToSingle(valor);

            fahrenheit = (centigrados * 9 / 5) + 32;

            Console.WriteLine("{0} Grados Centigrados es igual a {1} grados Fahrenheit", centigrados, fahrenheit);
        }

    }
}
