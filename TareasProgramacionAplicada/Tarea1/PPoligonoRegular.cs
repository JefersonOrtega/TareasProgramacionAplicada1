using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasProgramacionAplicada.Tarea1
{
    class PPoligonoRegular
    {
        public PPoligonoRegular() { }

        public void perimetro()
        {
            string valor;
            float lados, longitud, perimetro;

            Console.Write("Digite el numero de lados del poligono: ");
            valor = Console.ReadLine();
            lados = Convert.ToSingle(valor);

            Console.Write("\nDigite la longitud de un lado: ");
            valor = Console.ReadLine();
            longitud = Convert.ToSingle(valor);

            perimetro = lados * longitud;

            Console.WriteLine("\nEl perimetro del poligono es: {0}", perimetro);
        }
    }
}
