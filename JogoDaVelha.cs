using System;
using System.Collections.Generic;
using System.Text;

namespace JogoDaVelha
{
    class JogoDaVelha
    {   
        public char[,] matriz = new char[3, 3] {{'-','-','-'},{'-','-','-'},{'-','-','-'}};
        public int _linha = 777;
        public int _coluna = 999;
        public char _dado;


        public char[,] Dado(int linha, int coluna, char dado)
        {
            this._linha = linha;
            this._coluna = coluna;
            this._dado = dado;
            this.matriz[linha, coluna] = dado;
            return matriz;
        }

        public void InsereDadoRandom(char xis)
        {
            Random num = new Random();
            int x;
            int y;
            do
            {
                x = num.Next(0, 3);
                y = num.Next(0, 3);
            } while ((this._linha == x && this._coluna == y) || (this.matriz[x,y]==this._dado));

            this.matriz = Dado(x, y, xis);
        }
        /*
        public bool TesteUserGanhou()
        {
        }

        public bool TestePCGanhou()
        {
        }
        */
    }
}
