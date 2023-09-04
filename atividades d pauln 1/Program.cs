using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividades_do_paulin_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu;

            

            Console.WriteLine("escolha numeros para a contagem = 1 ");

            Console.WriteLine("tabuada = 2 ");

            Console.WriteLine("soma de numeros = 3 ");
           
            Console.WriteLine("adivinhe os numeros = 4 ");

            Console.WriteLine("");

            Console.Write("escolha uma das opçoes acima ");
            menu = int.Parse(Console.ReadLine());
            


            if (menu == 1)
            {
                Console.WriteLine("voce selecionou a opçao 1 ");

                Console.WriteLine("");

                int contador = 1;
                int numerodigitado;

                Console.WriteLine("digite um numero a ser loopado");
                numerodigitado = int.Parse(Console.ReadLine());

                Console.WriteLine("");

                while (contador <= numerodigitado)
                {
                    Console.WriteLine(contador);
                    contador++;
                }


            }
            else if (menu == 2)
            {
                Console.WriteLine("Voce Selecionou a Opção 2");

                Console.WriteLine("");

                int total;
                int tabu = 1;


                Console.Write("Escolha o numero para realizar a tabuada ");
                int escolha = int.Parse(Console.ReadLine());

                Console.WriteLine("");

                Console.WriteLine("O numero selecionado foi " + escolha);
                Console.WriteLine("");


                while (tabu <= 10)
                {
                    total = escolha * tabu;
                    escolha = escolha * 1;
                    Console.WriteLine(escolha + " x " + tabu + " = " + total);


                    tabu++;

                }


            }
            else if (menu == 3)
            {
                int contador = 1;
                int soma = 0;
                int quantidade;


                Console.WriteLine("voce selecionou a opçao 3");

                Console.WriteLine("");

                Console.WriteLine("Digite a quantidade de numeros a serem somados");
                quantidade = int.Parse(Console.ReadLine());



                while (contador <= quantidade)
                {
                    contador++;
                    Console.WriteLine("insira os numeros");
                    soma += int.Parse(Console.ReadLine());
                }



                Console.WriteLine("a soma dos numeros digitados eh = " + soma);

            }
            else
            {
                Console.WriteLine("voce selecionou a ultima opçao");

                Console.WriteLine("");

                Random random = new Random();

                int numeroAleatorio = random.Next(1, 101);

                int tentativas = 0;

                int palpite;


                Console.WriteLine("Bem-vindo ao jogo de adivinhação!");

                Console.WriteLine("");

                Console.WriteLine("Tente adivinhar o número entre 1 e 100.");

                Console.WriteLine("");

                do

                {

                    Console.Write("Digite seu palpite: ");

                    if (int.TryParse(Console.ReadLine(), out palpite))

                    {
                        tentativas++;

                        if (palpite < numeroAleatorio)

                        {
                            Console.WriteLine("Palpite muito baixo. Tente novamente.");
                        }

                        else if (palpite > numeroAleatorio)

                        {
                            Console.WriteLine("Palpite muito alto. Tente novamente.");
                        }

                        else

                        {
                            Console.WriteLine($"Parabéns! Você acertou o número {numeroAleatorio} em {tentativas} tentativas.");
                        }

                    }

                    else

                    {
                        Console.WriteLine("Por favor, digite um número válido.");
                    }

                } while (palpite != numeroAleatorio);

                Console.WriteLine("Fim do jogo. Obrigado por jogar!");
            }



            Console.ReadKey();  
        }
    }
}
