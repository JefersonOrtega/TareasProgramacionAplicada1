using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasProgramacionAplicada.Tarea1
{
    class APPoligono
    {
        public APPoligono() { }

        public void calcular()
        {
            string valor;
            int op;
            float lados, longitud, apotema, perimetro, area;

            Console.WriteLine("Que desea calcular 1-Perimetro  2-Area");
            valor = Console.ReadLine();
            op = Convert.ToInt32(valor);

            if (op == 1)
            {
                Console.Write("Digite el numero de lados del poligono: ");
                valor = Console.ReadLine();
                lados = Convert.ToSingle(valor);

                Console.Write("\nDigite la longitud de un lado: ");
                valor = Console.ReadLine();
                longitud = Convert.ToSingle(valor);

                perimetro = lados * longitud;

                Console.WriteLine("\nEl perimetro del poligono es: {0}", perimetro);
            }
            else
            {
                if (op == 2)
                {
                    Console.Write("Digite el numero de lados del poligono: ");
                    valor = Console.ReadLine();
                    lados = Convert.ToSingle(valor);

                    Console.Write("\nDigite la longitud de un lado: ");
                    valor = Console.ReadLine();
                    longitud = Convert.ToSingle(valor);

                    perimetro = lados * longitud;

                    Console.Write("\nDigite la apotema: ");
                    valor = Console.ReadLine();
                    apotema = Convert.ToSingle(valor);

                    area = perimetro * apotema / 2;

                    Console.WriteLine("\nEl Area del poligono es: {0}", area);
                }
            }
        }
    }
}
