// Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatrocasas decimais conforme exemplos.
// Fórmula da área: area = π . raio2 Considere o valor de π = 3.14159


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Calc_area
    {
        double pi = 3.14159;
        public double calc(double raio, double pi)
        {
            double area = pi * (raio * raio);
            return Math.Round(area, 4);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            double raio, pi = 3.14159;
            Calc_area area = new Calc_area();
            Console.WriteLine("Digite o raio do círculo: ");
            raio = float.Parse(Console.ReadLine());

            Console.WriteLine(area.calc(raio, pi));
        }
    }
}