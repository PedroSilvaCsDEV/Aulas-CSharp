using AulasCSharpPOO.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "João";
p1.Idade = 20;

p1.Apresentar();

ContaCorrente c1 = new ContaCorrente(123, 1000);

c1.ExibirSaldo();
c1.Sacar(100);
c1.ExibirSaldo();

Aluno a1 = new Aluno();
a1.Nome = "Maria";
a1.Idade = 20;
a1.Nota = 9.5;
a1.Apresentar();

Professor prof1 = new Professor();
prof1.Nome = "José";
prof1.Idade = 30;
prof1.Salario = 10000;
prof1.Apresentar();

Corrente c1 = new Corrente();
c1.Creditar(500);
c1.ExibirSaldo();
