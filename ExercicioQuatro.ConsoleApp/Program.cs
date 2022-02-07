using System;

namespace ExercicioQuatro.ConsoleApp
{
    internal class Program
    {
        //Alguns países medem temperaturas em graus Celsius, e outros em graus Fahrenheit.
        //Faça um algoritmo para ler uma temperatura Celsius e imprimi-Ia em Fahrenheit(pesquise como fazer este tipo de conversão).
        static void Main(string[] args)
        {
            double celsius, fahrenheit;

            Console.Write("Digite a temperatura em celsius: ");
            celsius = Convert.ToDouble(Console.ReadLine());

            fahrenheit = celsius * 1.8 + 32;

            Console.WriteLine("A conversão para fahrenheit resulta em {0}", Math.Round(fahrenheit, 1));

            Console.ReadKey();
        }
    }
}
