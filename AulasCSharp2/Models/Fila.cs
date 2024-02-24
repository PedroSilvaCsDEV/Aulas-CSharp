using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulasCSharp2.Models
{
    public class Fila
    {
        public Queue<int> fila = new Queue<int>();
        public void enfileirar()
        {
            fila.Enqueue(1);
            fila.Enqueue(2);
            fila.Enqueue(3);
            fila.Enqueue(4);
            fila.Enqueue(5);
            foreach (int numero in fila)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine($"Removendo um elemento da fila: {fila.Dequeue()}");
            fila.Enqueue(6);
            foreach (int numero in fila)
            {
                Console.WriteLine(numero);
            }
        }
    }
}