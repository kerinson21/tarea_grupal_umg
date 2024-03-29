﻿using JuegoSnake.clases.ColaLista;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace JuegoSnake.clases.BicolaEnlazada
{
    class BiCola : ColaConLista
    {
        //Insertar por el final de la bicola
        public void ponerFinal(Point elemento)
        {
            insertar(elemento);
        }

        //Insertar al frente
        public void ponerFrente(Point elemento)
        {
            Nodo a; //Variable auxiliar
            a = new Nodo(elemento);
            if (colaVacia())
            {
                fin = a;
            }
            else
            {
                a.siguiente = frente;
                frente = a;
            }
        }

        //Quitar elemento
        public Point quitarFrente()
        {
            return quitar();
        }

        //Retirar elemento al final
        //Metodo propio de bicola
        //Es necesario hacer una iteracion de la bicola completa para llegar del nodo anterior al final, para despues enlazar y ajustar la cola
        public Point quitarFinal()
        {
            Point aux;
            if (colaVacia())
            {
                if (frente == fin)//La bicola solo tiene un nodo
                {
                    aux = quitar();
                }
                else
                {
                    //Como no tiene elementos vamos a iterar
                    Nodo a = frente;
                    while (a.siguiente != fin)
                    {
                        a = a.siguiente;
                    }
                    //Siguiente del nodo anterior lo vamos a poner en null
                    a.siguiente = null;
                    aux = fin.elemento;
                    fin = a;
                }
            }
            else
            {
                throw new Exception("La cola esta vacia");
            }
            return aux;
        }

        //Retorna el valor que se encuentra en el primer elemento o frente de la cola
        //Devuelve el valor que esta en frente de la bicola
        public Point frenteCola()
        {
            return frenteCola();
        }

        //Devolver el final de la cola el ultimo valor de la cola
        public Point finalBicola()
        {
            if (colaVacia())
            {
                throw new Exception("Cola Vacia");
            }
            return (fin.elemento);

        }

        //Retorna si esta vacia la cola
        public bool biColaVacia()
        {
            return colaVacia();
        }

        //Borrar la bicola
        public void borrarBIcola()
        {
            borrarCola();
        }

        //Conteo de elementos
        public int numElementosBicola()
        {
            return Tamaño();
        }

        public bool Any(Point elemento, bool posicion)
        {
            return busquda(elemento,posicion);
        }

    }//end class
}

