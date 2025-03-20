using System; // Necessário pois usaremos Console.WriteLine

class Pessoa
{
  // Atributo
  private string nome = "Teste"; // O valor "Teste" foi declarado para esclarecer que o "nome" que será exibido no console não é este.

  // Construtor
  public Pessoa(string nome)
  {
    Console.WriteLine("Olá, " + nome); // O atributo nome que será exibido será o definido nos parâmetros do construtor.
    Console.WriteLine(this.nome); // Ao utilizar o modificador "this", o atributo buscado passa a ser o da classe, portanto o retorno será "Teste"
  }
}

// Lembre-se de consultar o Program.cs desta pasta para compreender a lógica toda.