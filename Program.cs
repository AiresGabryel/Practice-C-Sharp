// Exemplo de uso de uma classe Pessoa
using ExemploFundamentos.Models;

/*
//instanciando um objeto do tipo Pessoa
Pessoa p = new Pessoa(); // p =  variável

// atribuindo valores às propriedades
p.Nome = "Gabryel";
p.Idade = 26;

// chamando o método Apresentar
p.Apresentar();

*/


///////////////////////////////


//atribuindo valores diretamente às propriedades
string apresentacao = "Olá, seja bem vindo";
int quantidade = 1;
double altura = 1.70;
decimal preco = 1.80M;
bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine($"Quantidade: {quantidade}");
Console.WriteLine($"Altura: {altura.ToString("0.00")}");// double não utiliza duas casas decimais, converte para string com duas casas decimais
Console.WriteLine($"Preço: {preco}");
Console.WriteLine($"Boolean: {condicao}");

// rodar o comando = dotnet run