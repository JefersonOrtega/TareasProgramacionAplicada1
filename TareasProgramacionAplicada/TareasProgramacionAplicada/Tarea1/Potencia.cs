using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasProgramacionAplicada.Tarea1
{
    class Potencia
    {
        public Potencia() { }

        public void calcular()
        {
            string valor;
            int num, potencia;
            int res = 1;

            Console.WriteLine("Digite el numero a elevar");
            valor = Console.ReadLine();
            num = Convert.ToInt32(valor);

            Console.WriteLine("Digite la potencia");
            valor = Console.ReadLine();
            potencia = Convert.ToInt32(valor);

            for(int i=0; i<potencia; i++)
            {
                res *= num;
            }

            Console.WriteLine("El resultado es: {0}", res);

        }
    }
}
