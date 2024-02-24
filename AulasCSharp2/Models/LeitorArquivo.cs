using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulasCSharp2.Models
{
    public class LeitorArquivo
    {
        public void LerArquivo()
        {
            try
            {
                string[] linhas = File.ReadAllLines("C:\\Repositórios\\AulasCSharp2\\Arquivos\\arquivo.txt");
                foreach (string linha in linhas)
                {
                    Console.WriteLine(linha);
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Arquivo não encontrado: " + e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Diretório não encontrado: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao ler o arquivo: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Fim da execução");
            }
        }
    }
}