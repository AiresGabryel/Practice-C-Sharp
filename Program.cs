// Exemplo de uso da classe Pessoa
using ExemploFundamentos.Models;


// //instanciando um objeto do tipo Pessoa
// Pessoa p = new Pessoa(); // p =  variável

// // atribuindo valores às propriedades
// p.Nome = "Gabryel";
// p.Idade = 26;

// // chamando o método Apresentar
// p.Apresentar();


// ///////////////////////////////


// //atribuindo valores diretamente às propriedades
// string apresentacao = "Olá, seja bem vindo";
// int quantidade = 1;
// double altura = 1.70;
// decimal preco = 1.80M;
// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine($"Quantidade: {quantidade}");
// Console.WriteLine($"Altura: {altura.ToString("0.00")}");// double não utiliza duas casas decimais, converte para string com duas casas decimais
// Console.WriteLine($"Preço: {preco}");
// Console.WriteLine($"Boolean: {condicao}");

// ///////////////////////////////



// // DateTime = estrutura que representa data e hora
// // .Now = propriedade que retorna a data e hora atual
// DateTime dataAtual = DateTime.Now;
// Console.WriteLine(dataAtual);

// // adiciona 5 dias à data atual
// DateTime dataAdd = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAdd);

// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy")); // formata a data para o formato dia/mês/ano sem horário

// ///////////////

// int a = 10;
// int b = 20;
// int c = a + b;
// //Console.WriteLine(c);

// //c = c + 5; 
// //c += 5;
// c -= 5;
// Console.WriteLine(c);

// //////////////

// int a = Convert.ToInt32 ("5");

// int a = int.Parse("5");
// Console.WriteLine(a); // converte a string "5" para o inteiro 5

// int inteiro = 5;
// string a = inteiro.ToString(); 
// Console.WriteLine(a);

// int a = 5;
// double b = a;
// Console.WriteLine(b);


// double a = 4 / 2 + 2;
// Console.WriteLine(a);


// string a = "15-";
// int b = 0;
// int.TryParse(a, out b);
// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso!");


//___________________________Operadores Condicionais____________________

// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;
// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if (quantidadeCompra == 0)
// { Console.WriteLine("venda inválida"); }
// else if (possivelVenda)
// { Console.WriteLine("Venda realiada"); }
// else
// { Console.WriteLine("Não temos a quantidade desejada em estoque"); }




// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();
// //permite que o terminal espere por um comando, ele lerá a linha digitada.
// if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
// { Console.WriteLine("Vogal"); }
// else
// { Console.WriteLine("Não é uma vogal"); }

//_________________________Switch Case____________________________________
Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;
    default:
        Console.WriteLine("Nao é uma vogal");
        break;

}   



// rodar o comando = dotnet run