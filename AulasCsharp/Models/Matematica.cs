using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulasCsharp.Models
{
    public class Matematica
    {
        public void Potencia(int a, int b)
        {
            double pot = Math.Pow(a, b);
            Console.WriteLine($"{a} ^ {b} = {pot}");
        }
        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"sen({angulo}) = {Math.Round(seno, 4)}");
        }
        public void Cosseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double cosseno = Math.Cos(radiano);
            Console.WriteLine($"cos({angulo}) = {Math.Round(cosseno, 4)}");
        }
        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"tan({angulo}) = {Math.Round(tangente, 4)}");
        }
        public void RaizQuadrada(double numero)
        {
            double raiz = Math.Sqrt(numero);
            Console.WriteLine($"sqrt({numero}) = {Math.Round(raiz, 4)}");
        }
    }
}