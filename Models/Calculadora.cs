using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculadora_de_terminal.Models
{
    public class Calculadora
    {
        public void Somar(double x, double y)
        {
            Console.WriteLine($"{x} + {y} = {Math.Round(x + y, 10)}");
        }
        public void Subtrair(double x, double y)
        {
            Console.WriteLine($"{x} - {y} = {Math.Round(x - y, 10)}");
        }
        public void Dividir(double x, double y)
        {
            Console.WriteLine($"{x} / {y} = {Math.Round(x / y, 10)}");
        }
        public void Multiplicar(double x, double y)
        {
            Console.WriteLine($"{x} * {y} = {Math.Round(x * y, 10)}");
        }
        public void Potencia(double x, double y)
        {
            double potencia = Math.Pow(x, y);
            Console.WriteLine($"{x} ˆ {y} = {Math.Round(potencia, 3)}");
        }
        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            seno = Math.Round(seno, 10);


            Console.WriteLine($"Seno de {angulo} = {seno}");
        }
        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            coseno = Math.Round(coseno, 10);


            Console.WriteLine($"Coseno de {angulo} = {coseno}");
        }
        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            tangente = Math.Round(tangente, 10);

            Console.WriteLine($"Tangente de {angulo} = {tangente}");
        }
        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz Quadrada de {x} = {Math.Round(raiz, 10)}");
        }
    }
}