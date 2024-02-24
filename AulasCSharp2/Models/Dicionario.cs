using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulasCSharp2.Models
{
    public class Dicionario
    {
        Dictionary<string, string> estados = new Dictionary<string, string>();
        public void Chaves()
        {
            estados.Add("SP", "São Paulo");
            estados.Add("RJ", "Rio de Janeiro");
            estados.Add("MG", "Minas Gerais");
            foreach (KeyValuePair<string, string> estado in estados)
            {
                Console.WriteLine("Chave: " + estado.Key + " , " + "Valor: " + estado.Value);
            }
            estados.Remove("MG");
            estados["SP"] = "São Paulo - SP";
            Console.WriteLine("Removendo o estado de Minas Gerais...");
            foreach (KeyValuePair<string, string> estado in estados)
            {
                Console.WriteLine("Chave: " + estado.Key + " , " + "Valor: " + estado.Value);
            }
            string chave = "BA";
            Console.WriteLine($"Verificando o elemento: {chave}");
            if (estados.ContainsKey(chave))
            {
                Console.WriteLine($"A chave {chave} existe no dicionário.");
            }
            else
            {
                Console.WriteLine($"A chave {chave} não existe no dicionário.");
            }
            Console.WriteLine(estados["SP"]);
        }
    }
}