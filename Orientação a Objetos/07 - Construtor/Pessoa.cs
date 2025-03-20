using System; // Necessário pois usaremos Console.WriteLine

class Pessoa
{
  public Pessoa()
  {
    Console.WriteLine("Construtor executado");
  }

  public Pessoa(string nome)
  {
    Console.WriteLine("Olá, " + nome);
  }
}

// O método construtor é executado instanciando um método que carrega o nome da classe.
// Note que é possível criar diferentes construtores para uma mesma classe, utilizando nesses construtores o nome da classe.

// Dito isso, é fundamental entender que a diferença de um método construtor para um método comum é:
/*
  Método Construtor: Permite a criação de um novo objeto para a classe com base nos parâmetros desejados.
  Método Comum: Trata-se das ações executadas por uma classe.
*/

// Lembre-se de consultar o Program.cs desta pasta para compreender a lógica toda.