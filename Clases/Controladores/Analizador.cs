using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirusDetectorJS.Clases.Modelos;

namespace VirusDetectorJS.Clases.Controladores
{
    internal class Analizador
    {
        private Virus[] listaVirus = null;

        private byte[] bytesArchivoAnalizer = null;

        //Constructor del analizador
        public Analizador() { 

            crearListaVirus();
        
        }

        //Metodo que instancia la lista de Virus
        private void crearListaVirus()
        {
            Virus usama = new Virus("USAMA", new byte[] { 15, 30, 15, 49 });
            Virus amtrax = new Virus("Amtrax", new byte[] { 72, 72, 15, 29 });
            Virus eBola = new Virus("éBOLA", new byte[] { 29, 32, 53, 29 });
            Virus ah1N1 = new Virus("AH1N1", new byte[] { 72, 32, 32, 20 });
            Virus covid = new Virus("Covid-19", new byte[] { 30, 25, 20, 19 });

            listaVirus= new Virus[5];
            
            listaVirus[0]=usama;
            listaVirus[1] = amtrax;
            listaVirus[2] = eBola;
            listaVirus[3] = ah1N1;
            listaVirus[4] = covid;
        }

        //Metodo donde el automata detecta los byte de los virus
        internal void Detectar(byte[] bytesArchivo)
        {
            try
            {
                //Recorrer bytes del archivo 
                for (int i = 0; i < bytesArchivo.Length; i++)
                {
                    //Buscar USAMA
                    //q0
                    if (bytesArchivo[i] == listaVirus[0].Secuencia()[0])
                    {
                        //q1
                        if (bytesArchivo[i + 1] == listaVirus[0].Secuencia()[1])
                        {
                            //q2
                            if (bytesArchivo[i + 2] == listaVirus[0].Secuencia()[2])
                            {
                                //q3
                                if (bytesArchivo[i + 3] == listaVirus[0].Secuencia()[3])
                                {
                                    Console.WriteLine("USAMA encontrado");
                                }
                            }
                        }
                    }

                    //Buscar Amtrax
                    //q0
                    if (bytesArchivo[i] == listaVirus[1].Secuencia()[0])
                    {
                        //q1
                        if (bytesArchivo[i + 1] == listaVirus[1].Secuencia()[1])
                        {
                            //q2
                            if (bytesArchivo[i + 2] == listaVirus[1].Secuencia()[2])
                            {
                                //q3
                                if (bytesArchivo[i + 3] == listaVirus[1].Secuencia()[3])
                                {
                                    Console.WriteLine("Amtrax encontrado");
                                }
                            }
                        }
                    }

                    //Buscar eBola
                    //q0
                    if (bytesArchivo[i] == listaVirus[2].Secuencia()[0])
                    {
                        //q1
                        if (bytesArchivo[i + 1] == listaVirus[2].Secuencia()[1])
                        {
                            //q2
                            if (bytesArchivo[i + 2] == listaVirus[2].Secuencia()[2])
                            {
                                //q3
                                if (bytesArchivo[i + 3] == listaVirus[2].Secuencia()[3])
                                {
                                    Console.WriteLine("eBola encontrado");
                                }
                            }
                        }
                    }

                    //Buscar Ah1n1
                    //q0
                    if (bytesArchivo[i] == listaVirus[3].Secuencia()[0])
                    {
                        //q1
                        if (bytesArchivo[i + 1] == listaVirus[3].Secuencia()[1])
                        {
                            //q2
                            if (bytesArchivo[i + 2] == listaVirus[3].Secuencia()[2])
                            {
                                //q3
                                if (bytesArchivo[i + 3] == listaVirus[3].Secuencia()[3])
                                {
                                    Console.WriteLine("Amtrax encontrado");
                                }
                            }
                        }
                    }

                    //Buscar Covid
                    //q0
                    if (bytesArchivo[i] == listaVirus[4].Secuencia()[0])
                    {
                        //q1
                        if (bytesArchivo[i + 1] == listaVirus[4].Secuencia()[1])
                        {
                            //q2
                            if (bytesArchivo[i + 2] == listaVirus[4].Secuencia()[2])
                            {
                                //q3
                                if (bytesArchivo[i + 3] == listaVirus[4].Secuencia()[3])
                                {
                                    Console.WriteLine("Amtrax encontrado");
                                }
                            }
                        }
                    }

                }
            }
            catch(Exception e) {
                throw new Exception("Error"+e);
            }
        }
    }
}
