using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulasCSharp2.Models
{
    public class ExemploErro
    {
        public void Metodo1()
        {
            try
            {
                Metodo2();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro no método 1: " + e.Message);
            }
        }
        public void Metodo2()
        {
            Metodo3();
        }
        public void Metodo3()
        {
            Metodo4();
        }
        public void Metodo4()
        {
            throw new Exception("Erro no método 4");
        }
    }
}