using AulasCsharp.Models;

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "João";
pessoa1.Idade = 20;
pessoa1.Apresentar();

DateTime dataAtual = DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));

int a = 10;
int b = 20;
int c = a + b;
c += 10;
Console.WriteLine(c);

string parsing = "10";
int parsed1 = 0;
int.TryParse(parsing, out parsed1);
Console.WriteLine(parsed1);

string parsing2 = "10.5";
decimal parsed2 = Convert.ToDecimal(parsing2);
Console.WriteLine(parsed2);

string parsing3 = "20";
int parsed3 = int.Parse(parsing3);
Console.WriteLine(parsed3);


int quantidadeEstoque = 10;
int quantidadeVendida = 5;
bool podeVender = quantidadeEstoque >= quantidadeVendida;

Console.WriteLine($"Quantidade em estoque: {quantidadeEstoque}");
Console.WriteLine($"Quantidade vendida: {quantidadeVendida}");
Console.WriteLine($"Pode vender: {podeVender}");

if (podeVender)
{
    quantidadeEstoque -= quantidadeVendida;
    Console.WriteLine("Venda realizada com sucesso!");
    Console.WriteLine($"Quantidade em estoque: {quantidadeEstoque}");
}
else
{
    Console.WriteLine("Não foi possível realizar a venda, estoque insuficiente!");
}


Console.WriteLine("Digite uma letra: ");
char letra = Console.ReadKey().KeyChar;

switch (letra)
{
    case 'a':
    case 'e':
    case 'i':
    case 'o':
    case 'u':
        Console.WriteLine("\nA letra digitada é uma vogal");
        break;

    default:
        Console.WriteLine("\nA letra digitada é uma consoante");
        break;
}

Matematica calc = new Matematica();
calc.Potencia(2, 3);
calc.Seno(30);
calc.Seno(45);
calc.Seno(60);
calc.Cosseno(30);
calc.Cosseno(45);
calc.Cosseno(60);
calc.Tangente(30);
calc.Tangente(45);
calc.Tangente(60);
calc.RaizQuadrada(2);

int numero = 5;
int contador = 0;

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
}

while (contador <= 10)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
    contador++;

    if (contador == 5)
    {
        break;
    }
}

int soma = 0, numero = 0;

do
{

    Console.WriteLine("Digite um número: ");
    numero = Convert.ToInt32(Console.ReadLine());
    soma += numero;
    Console.WriteLine($"Soma: {soma}");

} while (numero != 0);

Console.WriteLine($"Soma total: {soma}");

string? opcao;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Escolha uma opção: ");
    Console.WriteLine("1 - Cadastrar");
    Console.WriteLine("2 - Listar");
    Console.WriteLine("3 - Sair");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastrar");
            break;

        case "2":
            Console.WriteLine("Listar");
            break;

        case "3":
            Console.WriteLine("Sair");
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

Console.WriteLine("Fim do programa");


int[] arrayInteiros = new int[3];

arrayInteiros[0] = 10;
arrayInteiros[1] = 20;
arrayInteiros[2] = 30;

for (int i = 0; i < arrayInteiros.Length; i++)
{
    Console.WriteLine($"Posição: {i} - {arrayInteiros[i]}");
}

int posicao = 0;
foreach (int i in arrayInteiros)
{
    Console.WriteLine($"Posição: {posicao} - {i}");
    posicao++;
}

Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);
int[] arrayInteirosx2 = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosx2, arrayInteiros.Length);

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("RJ");
listaString.Add("MG");
listaString.Add("BA");

for (int i = 0; i < listaString.Count; i++)
{
    Console.WriteLine($"Posição: {i} - {listaString[i]}");
}

int contador2 = 0;
foreach (string item in listaString)
{
    Console.WriteLine($"Posição: {contador2} - {item}");
    contador2++;
}