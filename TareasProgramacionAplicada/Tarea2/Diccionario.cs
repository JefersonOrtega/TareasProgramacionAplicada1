using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasProgramacionAplicada.Tarea2
{
    /// <summary>
    /// Hacer un programa que funcione como un
    ///diccionario, con palabra y definición,
    ///usando el Hashtable.
    /// </summary>
    class Diccionario
    {
        public Diccionario() { }

        public void diccionario()
        {
            Hashtable palabras = new Hashtable();
            palabras.Add("abandonar", "Dejar solo, sin atención, sin cuidados a una persona, un animal o una cosa.");
            palabras.Add("abanico", "Objeto que sirve para dar aire.");
            palabras.Add("abeto", "Árbol de tronco alto y recto. La copa tiene forma de cono y su fruto son las piñas. ");
            palabras.Add("caño", "Tubo por donde sale al exterior un chorro de un líquido.");

            foreach (DictionaryEntry datos in palabras)
                Console.WriteLine(datos.Key + ":\t" + datos.Value);
        }
        


    }
}
