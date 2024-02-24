using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace AulasCSharp2.Models
{
    public class Valores
    {
        public void Localizacao()
        {
            decimal valorMonetario = 10.5m;
            Console.WriteLine($"\n{valorMonetario:C}");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(valorMonetario.ToString("C", new CultureInfo("de-DE")));

            double porcentagem = 0.5;
            Console.WriteLine(porcentagem.ToString("P"));

            string dataString = "2022-12-01 18:12";
            bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);
            DateTime data = DateTime.Parse(dataString);
            if (sucesso)
            {
                Console.WriteLine($"Convertido com sucesso: {data}");
            }
            else
            {
                Console.WriteLine($"{dataString} não é uma data válida!");
            }
        }
    }
}