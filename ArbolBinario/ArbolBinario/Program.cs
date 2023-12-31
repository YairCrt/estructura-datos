﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArbolBB arbol = new ArbolBB();

            Nodo raiz = arbol.Insertar(6, null); //Null para que sea el nodo raiz
            arbol.Insertar(2, raiz);
            arbol.Insertar(8, raiz);
            arbol.Insertar(1, raiz);
            arbol.Insertar(4, raiz);
            arbol.Insertar(3, raiz);
            arbol.Insertar(5, raiz);
            arbol.Insertar(7, raiz);
            arbol.Insertar(11, raiz);
            arbol.Insertar(9, raiz);
            arbol.Insertar(10, raiz);
            arbol.Insertar(0, raiz);
            arbol.Insertar(-1, raiz);
            arbol.Insertar(12, raiz);
            arbol.Insertar(14, raiz);

            arbol.Transversa(raiz);

            //Console.WriteLine("El valor menor es {0}", arbol.EncuentraMinimo(raiz));
            //Console.WriteLine("El valor mayor es {0}", arbol.EncuentraMaximo(raiz));

            //arbol.TransversaOrdenada(raiz);

            //Console.WriteLine();

            //Nodo temp = arbol.EncuentraNodoMin(raiz);
            //Console.WriteLine("Referencia al nodo menor: {0}", temp.Dato);
            //temp = arbol.EncuentraNodoMax(raiz);
            //Console.WriteLine("Referencia al nodo mayor: {0}", temp.Dato);

            Console.WriteLine("-----------");

            Nodo padre = arbol.BuscarPadre(11, raiz);
            Console.WriteLine(padre.Dato);

            arbol.Borrar(raiz, 4);

            arbol.Transversa(raiz);


            Console.ReadLine();
        }
    }
}
