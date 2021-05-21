using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JuegoSnake.clases
{
    class Archivo
    {
        String direccion;

        public Archivo()
        {
            direccion = @"D:\Universidad\Programacion III\JUEGOSNAKE\JuegoSnake\resources\punteo.txt";
        }
        public int obtenerPunteo()
        {
            TextReader leer = new StreamReader(direccion);
            int dato = Convert.ToInt32(leer.ReadLine());
            leer.Close();
            return dato;
            
        }
        public int punteoMaximo(int punteoActual)
        {
            if(punteoActual > obtenerPunteo())
            {
                TextWriter escribir = new StreamWriter(direccion);
                escribir.WriteLine(punteoActual);
                escribir.Close();
                return obtenerPunteo();
            }
            else
            {
                return obtenerPunteo();
            }
        }
    }
}
