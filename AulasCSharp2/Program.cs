using AulasCSharp2.Models;
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

Pessoa p1 = new Pessoa();
p1.Nome = "João";
p1.Sobrenome = "Silva";
p1.Idade = 20;
p1.Apresentar();

Pessoa p1 = new Pessoa(nome: "João", sobrenome: "Silva", idade: 20);
Pessoa p2 = new Pessoa(nome: "Maria", sobrenome: "Silva", idade: 30);

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

Valores v = new Valores();
v.Localizacao();

LeitorArquivo leitor = new LeitorArquivo();
leitor.LerArquivo();

ExemploErro erro = new ExemploErro();
erro.Metodo1();

Fila f = new Fila();
f.enfileirar();

Pilha p = new Pilha();
p.empilhar();

Dicionario d = new Dicionario();
d.Chaves();