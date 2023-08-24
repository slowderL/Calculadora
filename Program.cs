using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        enum Menu { Soma = 1, Subtracao, Divisao, Multipilicacao, Potencia, Raiz, Sair}
        static void Main(string[] args)
        {

            bool escolheuSair = false;
            while(!escolheuSair)//enquanto usario não escolheu sair continua exibindo o menu
            {
                Console.WriteLine("Seja bem vindo ao CALC, seleciona alguma das opções: ");
                Console.WriteLine("1-soma\n2-Subtracao\n3-Divisao\n4-multipicação\n5-Potencia\n6-Raiz\n7-Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch(opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Sub();
                        break;
                    case Menu.Divisao:
                        Div();
                        break;
                    case Menu.Multipilicacao:
                        Mult();
                        break;
                    case Menu.Potencia:
                        Pot();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                    
                }

                Console.Clear();
            }

        
        }
        static void Soma()
        {
            Console.WriteLine("-----Soma de dois numeros-----\n");
            Console.WriteLine("digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultado é: {resultado} " );
            Console.WriteLine("Aperte ENTER para voltar para o menu: ");
            Console.ReadLine();
        }
        static void Sub()
        {
            Console.WriteLine("-----Subtração de dois numeros-----\n");
            Console.WriteLine("digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O resultado é: {resultado} ");
            Console.WriteLine("Aperte ENTER para voltar para o menu: ");
            Console.ReadLine();
        }
        static void Div()
        {
            Console.WriteLine("-----Divisão de dois numeros-----\n");
            Console.WriteLine("digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a/(float)b;
            Console.WriteLine($"O resultado é: {resultado} ");
            Console.WriteLine("Aperte ENTER para voltar para o menu: ");
            Console.ReadLine();
        }
        static void Mult()
        {
            Console.WriteLine("-----Multiplicação de dois numeros-----\n");
            Console.WriteLine("digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"O resultado é: {resultado} ");
            Console.WriteLine("Aperte ENTER para voltar para o menu: ");
            Console.ReadLine();
        }
        static void Pot()
        {
            Console.WriteLine("-----Potência de um numero-----\n");
            Console.WriteLine("digite a base: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o expoente: ");
            int expo = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(baseNum, expo);
            Console.WriteLine($"O resultado é: {resultado} ");
            Console.WriteLine("Aperte ENTER para voltar para o menu: ");
            Console.ReadLine();
        }
        static void Raiz()
        {
            Console.WriteLine("-----Raiz de um numero-----\n");
            Console.WriteLine("digite o numero: ");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"O resultado é: {resultado} ");
            Console.WriteLine("Aperte ENTER para voltar para o menu: ");
            Console.ReadLine();
        }

    }
}
