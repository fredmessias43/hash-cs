using System;

namespace JogoDaVelha
{
    class Program
    {
        static JogoDaVelha jogoDaVelha = new JogoDaVelha();

        static void Main(string[] args)
        {
            char outraPeca = 'x';
            char peca = 'o';
            int ganhou = 1;
            int cont = 0;

            Console.WriteLine("Esse é o tabuleiro");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{jogoDaVelha.matriz[i, j]}  ");
                }
            }
            Console.WriteLine("\nEscolha se irá jogar com O ou X:");
            peca = Convert.ToChar(Console.ReadLine());

            if (peca == 'x' || peca == 'X')
            {
                outraPeca = 'o';
            }
            else
            {
                outraPeca = 'x';
            }

            do
            {
                try
                {
                    do
                    {
                        int linha;
                        int coluna;
                        do
                        {
                            Console.Write("\nEntre com a linha que fará sua jogada(começa no 1): ");
                            linha = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Entre com a coluna que fará sua jogada(começa no 1): ");
                            coluna = Convert.ToInt32(Console.ReadLine());
                            linha--;
                            coluna--;
                        } while (jogoDaVelha._linha == linha && jogoDaVelha._coluna == coluna);

                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine();
                            for (int j = 0; j < 3; j++)
                            {
                                Console.Write($"{jogoDaVelha.Dado(linha, coluna, peca)[i, j]}  ");
                            }
                        }            
                        

                        //User - HORIZONTAL
                        if ((jogoDaVelha.matriz[0, 0] == peca) && (jogoDaVelha.matriz[0, 1] == peca) && (jogoDaVelha.matriz[0, 2] == peca))
                        {
                            Console.WriteLine("Você ganhou!!!!"); 
                            break;
                        }
                        else if ((jogoDaVelha.matriz[1, 0] == peca) && (jogoDaVelha.matriz[1, 1] == peca) && (jogoDaVelha.matriz[1, 2] == peca))
                        {
                            Console.WriteLine("Você ganhou!!!!");
                            break;
                        }
                        else if ((jogoDaVelha.matriz[2, 0] == peca) && (jogoDaVelha.matriz[2, 1] == peca) && (jogoDaVelha.matriz[2, 2] == peca))
                        {
                            Console.WriteLine("Você ganhou!!!!");
                            break;
                        }

                        //User - VERTICAL
                        if ((jogoDaVelha.matriz[0, 0] == peca) && (jogoDaVelha.matriz[1, 0] == peca) && (jogoDaVelha.matriz[2, 0] == peca))
                        {
                            ganhou++;
                            Console.WriteLine("Você ganhou!!!!");
                            break;
                        }
                        else if ((jogoDaVelha.matriz[0, 1] == peca) && (jogoDaVelha.matriz[1, 1] == peca) && (jogoDaVelha.matriz[2, 1] == peca))
                        {
                            ganhou++;
                            Console.WriteLine("Você ganhou!!!!");
                            break;
                        }
                        else if ((jogoDaVelha.matriz[0, 2] == peca) && (jogoDaVelha.matriz[1, 2] == peca) && (jogoDaVelha.matriz[2, 2] == peca))
                        {
                            ganhou++;
                            Console.WriteLine("Você ganhou!!!!");
                            break;
                        }

                        //USer - DIAGONAL
                        if ((jogoDaVelha.matriz[0, 0] == peca) && (jogoDaVelha.matriz[1, 1] == peca) && (jogoDaVelha.matriz[2, 2] == peca))
                        {
                            ganhou++;
                            Console.WriteLine("Você ganhou!!!!");
                            break;
                        }
                        else if ((jogoDaVelha.matriz[0, 2] == peca) && (jogoDaVelha.matriz[1, 1] == peca) && (jogoDaVelha.matriz[2, 0] == peca))
                        {
                            ganhou++;
                            Console.WriteLine("Você ganhou!!!!");
                            break;
                        }


                        Console.WriteLine();
                        jogoDaVelha.InsereDadoRandom(outraPeca);
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine();
                            for (int j = 0; j < 3; j++)
                            {
                                Console.Write($"{jogoDaVelha.matriz[i, j]}  ");
                            }
                        }


                        //PC - HORIZONTAL
                        if ((jogoDaVelha.matriz[0, 0] == outraPeca) && (jogoDaVelha.matriz[0, 1] == outraPeca) && (jogoDaVelha.matriz[0, 2] == outraPeca))
                        {
                            ganhou++;
                            Console.WriteLine("O PC ganhou!!!!");
                            break;
                        }
                        else if ((jogoDaVelha.matriz[1, 0] == outraPeca) && (jogoDaVelha.matriz[1, 1] == outraPeca) && (jogoDaVelha.matriz[1, 2] == outraPeca))
                        {
                            ganhou++;
                            Console.WriteLine("O PC ganhou!!!!");
                            break;
                        }
                        else if ((jogoDaVelha.matriz[2, 0] == outraPeca) && (jogoDaVelha.matriz[2, 1] == outraPeca) && (jogoDaVelha.matriz[2, 2] == outraPeca))
                        {
                            ganhou++;
                            Console.WriteLine("O PC ganhou!!!!");
                            break;
                        }

                        //PC - VERTICAL
                        if ((jogoDaVelha.matriz[0, 0] == outraPeca) && (jogoDaVelha.matriz[1, 0] == outraPeca) && (jogoDaVelha.matriz[2, 0] == outraPeca))
                        {
                            ganhou++;
                            Console.WriteLine("O PC ganhou!!!!");
                            break;
                        }
                        else if ((jogoDaVelha.matriz[0, 1] == outraPeca) && (jogoDaVelha.matriz[1, 1] == outraPeca) && (jogoDaVelha.matriz[2, 1] == outraPeca))
                        {
                            ganhou++;
                            Console.WriteLine("O PC ganhou!!!!");
                            break;
                        }
                        else if ((jogoDaVelha.matriz[0, 2] == outraPeca) && (jogoDaVelha.matriz[1, 2] == outraPeca) && (jogoDaVelha.matriz[2, 2] == outraPeca))
                        {
                            ganhou++;
                            Console.WriteLine("O PC ganhou!!!!");
                            break;
                        }

                        //PC - DIAGONAL
                        if ((jogoDaVelha.matriz[0, 0] == outraPeca) && (jogoDaVelha.matriz[1, 1] == outraPeca) && (jogoDaVelha.matriz[2, 2] == outraPeca))
                        {
                            ganhou++;
                            Console.WriteLine("O PC ganhou!!!!");
                            break;
                        }
                        else if ((jogoDaVelha.matriz[0, 2] == outraPeca) && (jogoDaVelha.matriz[1, 1] == outraPeca) && (jogoDaVelha.matriz[2, 0] == outraPeca))
                        {
                            ganhou++;
                            Console.WriteLine("O PC ganhou!!!!");
                            break;
                        }
                        cont++;
                        if (cont == 5)
                        {
                            Console.WriteLine("Empate");
                            ganhou++;
                        }
                    } while (ganhou == 1);
                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.GetType().FullName);
                    Console.WriteLine("Informe apenas numeros.");
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.GetType().FullName);
                    Console.WriteLine("O numero informado foi muito grande.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.GetType().FullName);
                    Console.WriteLine("Erro desconhecido contate o programdor!");
                }

            } while (true);
        }
    }
}
