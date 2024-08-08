using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VirusDetectorJS.Clases.Controladores
{
    //Clase responsable de leere los bytes de un archivo seleccionado
    internal class AdminArchivos
    {

        private String rutaArchivo;
        private byte[] bytesArchivo = null;

        //Metodo constructor
        public AdminArchivos(String rutaArchivoSeleccionada)
        {
            rutaArchivo = rutaArchivoSeleccionada;
        }

        //Metodo encargado de de leer los bytes del archivo a partir de la ruta
        private byte[] LeerBytesArchivo() {

            try {
                bytesArchivo = File.ReadAllBytes(rutaArchivo);
                return bytesArchivo;
            }
            catch(Exception e) {
                throw new Exception("Error al obtener bytes del archivo");
            }

        }

    }
}
