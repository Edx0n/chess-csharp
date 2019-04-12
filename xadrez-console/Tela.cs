using System;
using tabuleiro;

namespace xadrez_console
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab) //método estático //void n retorna nada
        {
            for (int i=0; i<tab.linhas; i++)
            {
                for (int j=0; j<tab.colunas; j++)
                {
                    if (tab.peca(i, j) == null)
                    {
                        Console.WriteLine("- ");
                    }
                    else
                    {
                        Console.Write(tab.peca(i, j) + " "); //método peca no objeto tab
                    } 
                }
                Console.WriteLine();
            }


        }
    }
}
