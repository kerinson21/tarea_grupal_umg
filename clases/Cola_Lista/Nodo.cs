using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace JuegoSnake.clases.ColaLista
{
    class Nodo
    {
        public Point elemento;
        public Nodo siguiente;

        //Constructor
        public Nodo(Point x)
        {
            elemento = x;
            siguiente = null;
        }


    }
}
