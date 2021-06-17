using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmo_Dijkstra
{
    public class Nodo
    {
        public string Valor { get; set; }
        public List<Nodo> nodos { get; set; }
        public List<int> Distancia { get; set; }
        public bool usado = false;

        public Nodo(string valor)
        {
            this.Valor = valor;
            nodos = new List<Nodo>();
            Distancia = new List<int>();            
        }

    }
}
