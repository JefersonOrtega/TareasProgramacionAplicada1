using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasProgramacionAplicada.Tarea1
{
    class Tabla
    {
        public Tabla() { }

        public void calcular()
        {
            string valor;
            int num, res;

            Console.WriteLine("Digite un numero");
            valor = Console.ReadLine();
            num = Convert.ToInt32(valor);

            for(int i=1; i<=10; i++)
            {
                res = i * num;
                Console.WriteLine("{0} X {1} = {2}", i, num, res);
            }
        }
    }
}
