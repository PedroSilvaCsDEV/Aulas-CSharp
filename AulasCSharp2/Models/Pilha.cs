using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulasCSharp2.Models
{
    public class Pilha
    {
        Stack<int> pilha = new Stack<int>();
        public void empilhar()
        {
            pilha.Push(1);
            pilha.Push(2);
            pilha.Push(3);
            pilha.Push(4);
            pilha.Push(5);
            foreach (int numero in pilha)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine($"Removendo um elemento da pilha: {pilha.Pop()}");
            pilha.Push(6);
            foreach (int numero in pilha)
            {
                Console.WriteLine(numero);
            }
        }
    }
}