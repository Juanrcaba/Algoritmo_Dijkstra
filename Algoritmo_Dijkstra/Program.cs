using System;
using System.Collections.Generic;

namespace Algoritmo_Dijkstra
{
    class Program
    {
        static void Main(string[] args)
        {
            //creando variable matriz de adyacencia.
            int[,] matriz;         
            List<Nodo> lstNodo = new List<Nodo>();          
            int  col = 0,i,j;        
            

           
            //creando objetos de tipo nodo
            Nodo oNodoA = new Nodo("A");
            Nodo oNodoB = new Nodo("B");
            Nodo oNodoC = new Nodo("C");
            Nodo oNodoD = new Nodo("D");
            Nodo oNodoE = new Nodo("E");
            Nodo oNodoF = new Nodo("F");
            Nodo oNodoG = new Nodo("G");
            Nodo oNodoH = new Nodo("H");
            lstNodo.Add(oNodoA);
            lstNodo.Add(oNodoB);
            lstNodo.Add(oNodoC);
            lstNodo.Add(oNodoD);
            lstNodo.Add(oNodoE);
            lstNodo.Add(oNodoF);
            

            //nodo 1
            oNodoA.nodos.Add(oNodoB);
            oNodoA.Distancia.Add(6);
            oNodoA.nodos.Add(oNodoC);
            oNodoA.Distancia.Add(2);
           
            //nodo2
            oNodoB.nodos.Add(oNodoA);
            oNodoB.Distancia.Add(6);
            oNodoB.nodos.Add(oNodoC);
            oNodoB.Distancia.Add(1);
            oNodoB.nodos.Add(oNodoE);
            oNodoB.Distancia.Add(9);

            //nodo3
            oNodoC.nodos.Add(oNodoA);
            oNodoC.Distancia.Add(2);
            oNodoC.nodos.Add(oNodoB);
            oNodoC.Distancia.Add(1);
            oNodoC.nodos.Add(oNodoD);
            oNodoC.Distancia.Add(15);
            oNodoC.nodos.Add(oNodoE);
            oNodoC.Distancia.Add(11);

            //nodo4
            oNodoD.nodos.Add(oNodoC);
            oNodoD.Distancia.Add(15);
            oNodoD.nodos.Add(oNodoE);
            oNodoD.Distancia.Add(10);
            oNodoD.nodos.Add(oNodoF);
            oNodoD.Distancia.Add(5);

            //nodo5
            oNodoE.nodos.Add(oNodoD);
            oNodoE.Distancia.Add(10);
            oNodoE.nodos.Add(oNodoF);
            oNodoE.Distancia.Add(6);
            oNodoE.nodos.Add(oNodoB);
            oNodoE.Distancia.Add(9);

            //nodo6
            oNodoF.nodos.Add(oNodoD);
            oNodoF.Distancia.Add(5);
            oNodoF.nodos.Add(oNodoE);
            oNodoF.Distancia.Add(6);


            matriz = new int[lstNodo.Count,lstNodo.Count];
            


            //recorrer nodo
           
            for ( i = 0; i < lstNodo.Count; i++)
            {
                Console.WriteLine(lstNodo[i].Valor);
                for ( j = 0; j < lstNodo[i].nodos.Count; j++)
                {
                    int t = lstNodo[i].nodos.FindIndex(x => x.Valor == lstNodo[i].nodos[j].Valor);
                    Console.Write("   "+lstNodo[i].nodos[j].Valor + ": " + lstNodo[i].Distancia[t]);
                    #region switch para columnas matriz
                    switch (lstNodo[i].nodos[j].Valor)
                    {
                        case "A":
                            col = 0;
                            break;
                        case "B":
                            col = 1;
                            break;
                        case "C":
                            col = 2;
                            break;
                        case "D":
                            col = 3;
                            break;
                        case "E":
                            col = 4;
                            break;
                        case "F":
                            col = 5;
                            break;
                        case "G":
                            col = 6;
                            break;
                        case "H":
                            col = 7;
                            break;
                        case "I":
                            col = 8;
                            break;
                        case "J":
                            col = 9;
                            break;
                        case "K":
                            col = 10;
                            break;
                        case "L":
                            col = 11;
                            break;
                        case "M":
                            col = 12;
                            break;
                        case "N":
                            col = 13;
                            break;
                        case "Ñ":
                            col = 14;
                            break;
                        case "O":
                            col = 15;
                            break;
                        case "P":
                            col = 16;
                            break;
                        case "Q":
                            col = 17;
                            break;
                        case "R":
                            col = 18;
                            break;
                        case "S":
                            col = 19;
                            break;
                        case "T":
                            col = 20;
                            break;
                        case "U":
                            col = 21;
                            break;
                        case "V":
                            col = 22;
                            break;
                        case "W":
                            col = 23;
                            break;
                        case "X":
                            col = 24;
                            break;
                        case "Y":
                            col = 25;
                            break;
                        case "Z":
                            col = 26;
                            break;
                        default:
                            break;
                    }
                    #endregion
                    matriz[i, col] = lstNodo[i].Distancia[t];
                }
                Console.WriteLine();
            }


            //dijkstra
            //distancia mas corta
            int nodos = (int)Math.Sqrt(matriz.Length);
            Dijkstra d = new Dijkstra();

            for (i = 1; i <= nodos; i++)
                for (j = 1; j <= nodos; j++)
                {
                    d.costo[i, j] = matriz[i - 1, j - 1];
                    if (d.costo[i, j] == 0)
                        d.costo[i, j] = 999;
                }


            Console.WriteLine("Colocar vertice origen :\n");

            int origen = Convert.ToInt32(Console.ReadLine());

            d.calc(nodos, origen);
            Console.WriteLine("La ruta mas corta desde \t" + origen + "\t para todas las otras rutas es: \n");
            for (i = 1; i <= nodos; i++)
                if (i != origen)
                    Console.WriteLine("Origen:" + origen + "\t Destino :" + i + "\t El costo minimo es:" + d.distancia[i] + "\t");

        }

    }
}
