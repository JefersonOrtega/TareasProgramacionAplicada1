using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasProgramacionAplicada.Tarea1
{
    class Transformacion
    {
        public Transformacion() { }

        public void gradoRadian()
        {
            string valor;
            float grados, radianes;

            Console.WriteLine("Digite los grados a convertir");
            valor = Console.ReadLine();
            grados = Convert.ToSingle(valor);

            radianes = grados*3.1416f*180f;

            Console.WriteLine("{0} Grados es igual a {1} radianes", grados, radianes);
        }

    }
}
