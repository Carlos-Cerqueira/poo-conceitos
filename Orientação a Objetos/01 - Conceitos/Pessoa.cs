using System; // Necessário pois usaremos Console.WriteLine

class Pessoa
{
  // Atributos
  public string nome;
  public int idade;
  
  // Métodos
  public void Falar()
  {
    Console.WriteLine("Olá, eu sou " + nome + " e tenho " + idade + " anos.");
  }
}

// Na Programação Orientada a Objetos:
// Classes são as entidades da situação que o código busca resolver;

// Atributos são informações (armazenadas em variáveis) tipadas e com diferentes níveis de proteção (Public e Private).
  // Public: Todas as classes podem acessar;
  // Private: Somente a classe onde está definido tem acesso;
// No exemplo anterior, o objeto da classe Pessoa possui o atributo nome, que pode ser acessado por outras classes (public) e só pode receber dados em formato de texto (string).

// Métodos são as ações que as Classes executam. Tecnicamente, são funções executadas pelas Classes. Semanticamente, possuem nomes de ações para facilitar a compreensão do código.
// No exemplo anterior, o método Falar() é "public" (pode ser acessado por outras classes) e "void" (não possui retorno de dados, ou seja, apenas retorna dados da forma como chegaram ao Método).

// Lembre-se de consultar o Program.cs desta pasta para compreender a lógica toda.