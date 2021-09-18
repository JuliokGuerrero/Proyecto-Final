using System;

namespace Grafo2
{
    public class CGrafo
    {
        private int[,] mAdyacencia;
        private int nodos;

        public CGrafo(int pNodos)
        {
            nodos = pNodos;

            // Instanciamos matriz de adyacencia
            mAdyacencia = new int[nodos, nodos];
        }

        public void AdicionaArista(int pNodoInicio, int pNodoFinal, int pPeso)
        {
            mAdyacencia[pNodoInicio, pNodoFinal] = pPeso;
        }

        public void MuestraAdyacencia()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            for (int n = 0; n < nodos; n++)
                Console.Write("\t{0}", n);

            Console.WriteLine();

            for (int n = 0; n < nodos; n++)
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();

                for (int m = 0; m < nodos; m++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\t{0}", mAdyacencia[n, m]);
                }

                Console.WriteLine();
            }
        }

        public int ObtenAdyacencia(int pFila, int pColumna)
        {
            return mAdyacencia[pFila, pColumna];
        }
    }
}
      


