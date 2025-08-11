using System;

namespace MyApp
{
    internal class Program //O nome do arquivo tem que ser o msm do nome da classe Program, ou seja, Program.cs
    {
        static void Main(string[] args)
        {
            string nome;
            int valor1;
            int valor2;

            Console.WriteLine("Qual o seu nome?"); // .extensão(sobreposição) - A sobreposição é geralmene uma variável
            nome = Console.ReadLine();
            Console.WriteLine($"Seu nome é {nome}");

            Console.WriteLine("Porfavor insira o primeiro valor: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Porfavor insira o segundo valor: ");
            valor2 = int.Parse(Console.ReadLine());

            int soma = valor1 + valor2;
            int sub = valor1 - valor2;
            int mult = valor1 * valor2;
            int div = valor1 / valor2;

            Console.WriteLine($"Ola {nome} aqui vai as respostas pedidas:");
            Console.WriteLine($"A soma é: {soma}");
            Console.WriteLine($"A subtração é: {sub}");
            Console.WriteLine($"A multiplicação é: {mult}");
            Console.WriteLine($"A divisão é: {div}");

        }
    }
}