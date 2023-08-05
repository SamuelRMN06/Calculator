using System;


namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Qual operação deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");

            Console.WriteLine("------------------------");
            Console.WriteLine("Seleciona uma opção:");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                default: Menu(); break;
            }

        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Escreva um valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Escreva outro valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;

            Console.WriteLine("O resultado foi:" + resultado);
            Console.ReadLine();

            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Escreva um valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Escreva outro valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;

            Console.WriteLine("O resultado foi:" + resultado);
            Console.ReadLine();

            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Escreva um valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Escreva outro valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;

            Console.WriteLine("O resultado foi:" + resultado);
            Console.ReadLine();

            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Escreva um valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Escreva outro valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;

            Console.WriteLine("O resultado foi:" + resultado);
            Console.ReadLine();

            Menu();
        }
    }
}
