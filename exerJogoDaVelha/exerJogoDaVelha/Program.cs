using System;
using System.Linq.Expressions;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vitjo = 0, vitpc=0, derrj=0, derrpc=0, empate=0;
            int nrjogadas = 0;
            string jogada, jogador, a1, a2, a3, b1, b2, b3, c1, c2, c3, sair, sair2;
            bool counter=false;
            Console.WriteLine("Digite seu nome:");
            jogador = Console.ReadLine();
            Console.WriteLine("você quer jogar com o 'X' ou com o 'O'(digite 'X' para x e 'O' para O");
            
            Console.WriteLine("Para jogar o jogo faça uma linha reta de X e não deixe seu adversário fazer " +
                "uma linha de O. Para colocar um X no campo \n" +
                "veja o número e a letra da coluna e digite onde você"
                + " quer digitar (exemplo: a1)");
            do
            {
                counter = false;
                nrjogadas = 0;
                a1 = " ";
                a2 = " ";
                a3 = " ";
                b1 = " ";
                b2 = " ";
                b3 = " ";
                c1 = " ";
                c2 = " ";
                c3 = " ";
                Console.WriteLine($"   a | b | c ");
                Console.WriteLine($"1  {a1} | {b1} | {c1} ");
                Console.WriteLine($"-----|---|---");
                Console.WriteLine($"2  {a2} | {b2} | {c2}");
                Console.WriteLine($"-----|---|---");
                Console.WriteLine($"3  {a3} | {b3} | {c3}");
                do
                {
                    do
                    {
                        counter = false;
                        sair2 = "s";
                        jogada = Console.ReadLine();
                        if ((jogada == "a1") && (a1 == " ")) a1 = "x";
                        else if ((jogada == "a2") && (a2 == " ")) a2 = "x";
                        else if ((jogada == "a3") && (a3 == " ")) a3 = "x";
                        else if ((jogada == "b1") && (b1 == " ")) b1 = "x";
                        else if ((jogada == "b2") && (b2 == " ")) b2 = "x";
                        else if ((jogada == "b3") && (b3 == " ")) b3 = "x";
                        else if ((jogada == "c1") && (c1 == " ")) c1 = "x";
                        else if ((jogada == "c2") && (c2 == " ")) c2 = "x";
                        else if ((jogada == "c3") && (c3 == " ")) c3 = "x";
                        else
                        {
                            Console.WriteLine("inválido, digite novamente");
                            sair2 = "n";
                        }
                    }
                    while (sair2 == "n");
                    Console.WriteLine($"   a | b | c ");
                    Console.WriteLine($"1  {a1} | {b1} | {c1} ");
                    Console.WriteLine($"-----|---|---");
                    Console.WriteLine($"2  {a2} | {b2} | {c2}");
                    Console.WriteLine($"-----|---|---");
                    Console.WriteLine($"3  {a3} | {b3} | {c3}");
                    if ((a1 == "x") && (a2 == "x") && (a3 == "x"))
                    {
                        vitjo++;
                        derrpc++;
                        counter = true;
                        nrjogadas = 5;
                    }
                    if ((b1 == "x") && (b2 == "x") && (b3 == "x"))
                    {
                        vitjo++;
                        derrpc++;
                        counter = true;
                        nrjogadas = 5;
                    }
                    if ((c1 == "x") && (c2 == "x") && (c3 == "x"))
                    {
                        vitjo++;
                        derrpc++;
                        counter = true;
                        nrjogadas = 5;
                    }
                    if ((a1 == "x") && (b1 == "x") && (c1 == "x"))
                    {
                        vitjo++;
                        derrpc++;
                        counter = true;
                        nrjogadas = 5;
                    }
                    if ((a2 == "x") && (b2 == "x") && (c2 == "x"))
                    {
                        vitjo++;
                        derrpc++;
                        counter = true;
                        nrjogadas = 5;
                    }
                    if ((a3 == "x") && (b3 == "x") && (c3 == "x"))
                    {
                        vitjo++;
                        derrpc++;
                        counter = true;
                        nrjogadas = 5;
                    }
                    if ((a3 == "x") && (b2 == "x") && (c1 == "x"))
                    {
                        vitjo++;
                        derrpc++;
                        counter = true;
                        nrjogadas = 5;
                    }
                    if ((a1 == "x") && (b2 == "x") && (c3 == "x"))
                    {
                        vitjo++;
                        derrpc++;
                        counter = true;
                        nrjogadas = 5;
                    }
                    nrjogadas++;
                    if ((nrjogadas >= 5)&&(counter==false)) {
                        empate++;
                        counter = true;
                }
                    if (nrjogadas < 5)
                    {
                        {


                            Console.WriteLine("vez do oponente:");

                            Random random = new Random();
                            int mogada;
                            do
                            {
                                mogada = random.Next(1, 10);
                            }
                            while (
                              (mogada == 1 && a1 != " ") ||
                              (mogada == 2 && a2 != " ") ||
                              (mogada == 3 && a3 != " ") ||
                              (mogada == 4 && b1 != " ") ||
                              (mogada == 5 && b2 != " ") ||
                              (mogada == 6 && b3 != " ") ||
                              (mogada == 7 && c1 != " ") ||
                              (mogada == 8 && c2 != " ") ||
                              (mogada == 9 && c3 != " ")
                                 );
                            if (mogada == 1) a1 = "O";
                            if (mogada == 2) a2 = "O";
                            if (mogada == 3) a3 = "O";
                            if (mogada == 4) b1 = "O";
                            if (mogada == 5) b2 = "O";
                            if (mogada == 6) b3 = "O";
                            if (mogada == 7) c1 = "O";
                            if (mogada == 8) c2 = "O";
                            if (mogada == 9) c3 = "O";

                            Console.WriteLine($"   a | b | c ");
                            Console.WriteLine($"1  {a1} | {b1} | {c1} ");
                            Console.WriteLine($"-----|---|---");
                            Console.WriteLine($"2  {a2} | {b2} | {c2}");
                            Console.WriteLine($"-----|---|---");
                            Console.WriteLine($"3  {a3} | {b3} | {c3}");
                            Console.WriteLine("sua vez:");
                            if ((a1 == "O") && (a2 == "O") && (a3 == "O"))
                            {
                                vitpc++;
                                derrj++;
                                counter = true;
                            }
                            if ((b1 == "O") && (b2 == "O") && (b3 == "O"))
                            {
                                vitjo++;
                                derrpc++;
                                counter = true;
                            }
                            if ((c1 == "O") && (c2 == "O") && (c3 == "O"))
                            {
                                vitpc++;
                                derrj++;
                                counter = true;
                            }
                            if ((a1 == "O") && (b1 == "O") && (c1 == "O"))
                            {
                                vitpc++;
                                derrj++;
                                counter = true;
                            }
                            if ((a2 == "O") && (b2 == "O") && (c2 == "O"))
                            {
                                vitpc++;
                                derrj++;
                                counter = true;
                            }
                            if ((a3 == "O") && (b3 == "O") && (c3 == "O"))
                            {
                                vitpc++;
                                derrj++;
                                counter = true;
                            }
                            if ((a3 == "O") && (b2 == "O") && (c1 == "O"))
                            {
                                vitpc++;
                                derrj++;
                                counter = true;
                            }
                            if ((a1 == "O") && (b2 == "O") && (c3 == "O"))
                            {
                                vitpc++;
                                derrj++;
                                counter = true;
                            }
                        }
                    }
                }
                while (counter == false);
                Console.WriteLine("ranking:");
                Console.WriteLine(jogador + " ganhou: "+vitjo+" partidas e perdeu: "+derrj+" partidas");
                Console.WriteLine("o computador ganhou: " + vitpc + " partidas e perdeu: " + derrpc + " partidas");
                Console.WriteLine("ocorreram "+empate+" empate(s)");
                Console.WriteLine("Você quer encerrar o programa? "+
                    "se você quiser sair, digite 'S'. Se você quiser continuar digite 'N' ");
                sair = Console.ReadLine();
            } while (sair == "N");
         }
    }
}