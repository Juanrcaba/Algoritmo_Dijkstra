using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmo_Dijkstra
{
    public class Dijkstra
    {
        public int[] distancia = new int[10];
        public int[,] costo = new int[10, 10];

        public void calc(int nNodos, int origen)
        {
            int[] flag = new int[nNodos + 1];
            int i, minpos = 1, k, c, minimum;

            for (i = 1; i <= nNodos; i++)
            {
                flag[i] = 0;
                this.distancia[i] = this.costo[origen, i];
            }
            c = 2;
            while (c <= nNodos)
            {
                minimum = 99;
                for (k = 1; k <= nNodos; k++)
                {
                    if (this.distancia[k] < minimum && flag[k] != 1)
                    {
                        minimum = this.distancia[k];
                        minpos = k;
                    }
                }
                flag[minpos] = 1;
                c++;
                for (k = 1; k <= nNodos; k++)
                {
                    if (this.distancia[minpos] + this.costo[minpos, k] < this.distancia[k] && flag[k] != 1)
                        this.distancia[k] = this.distancia[minpos] + this.costo[minpos, k];
                }
            }
        }
    }
}
