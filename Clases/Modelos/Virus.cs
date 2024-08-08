using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirusDetectorJS.Clases.Modelos
{
    //Clase encargada de almacenar la lista de virus
    internal class Virus
    {
        private String nombre;
        private byte[] secuencia;

        //Metodo Constructor
        public Virus(string nombre, byte[] secuencia)
        {
            this.nombre = nombre;
            Secuencia = secuencia;
        }
    
        //Accesor a la secuencia
        public byte[] Secuencia { get => secuencia; set { } }
    }
}
