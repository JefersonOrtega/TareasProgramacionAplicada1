using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasProgramacionAplicada.Tarea2
{
    /// <summary>
    /// Hacer un programa que funcione como
    ///una agenda telefónica y que guarde el
    ///nombre de la persona y su número
    ///telefónico.
    /// </summary>
    class AgendaTelefonica
    {
        public AgendaTelefonica() { }

        public void guardar()
        {
            Hashtable agenda = new Hashtable();
            string nombre, numero;

            do
            {
                Console.Clear();
                Console.WriteLine("Digite . para terminar");

                Console.WriteLine("Digite el nombre");
                nombre = Console.ReadLine();
                if (nombre == ".")
                    break;
                Console.WriteLine("Digite el numero");
                numero = Console.ReadLine();
                if (numero == ".")
                    break;

                agenda.Add(nombre, numero);
            } while(nombre != "." && numero != ".");

            Console.Clear();
            Console.WriteLine("Agenda: \n");

            foreach (DictionaryEntry datos in agenda)
                Console.WriteLine(datos.Key + "  -  " + datos.Value);


        }

    }
}
