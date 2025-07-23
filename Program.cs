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

/*
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
*/

// DateTime = estrutura que representa data e hora
// .Now = propriedade que retorna a data e hora atual
DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

// adiciona 5 dias à data atual
DateTime dataAdd = DateTime.Now.AddDays(5);
Console.WriteLine(dataAdd);

Console.WriteLine(dataAtual.ToString("dd/MM/yyyy")); // formata a data para o formato dia/mês/ano sem horário


// rodar o comando = dotnet run