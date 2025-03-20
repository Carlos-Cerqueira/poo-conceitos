using System; // Necessário pois usaremos Console.WriteLine

public class Pessoa
{
  // Método 01
  public void Apresentar()
  {
    Console.WriteLine("Olá!");
  }

  // Método 02
  public void Apresentar(string nome)
  {
    Console.WriteLine("Olá " + nome);
  }

  // Método 03
  public void Apresentar(string nome, int idade)
  {
    Console.WriteLine("Olá " + nome + ". Você tem " + idade + " anos.");
  }
}

// O objetivo desse exemplo é mostrar que é possível declarar métodos com o mesmo nome, desde que possuam diferentes parâmetros

// Lembre-se de consultar o Program.cs desta pasta para compreender a lógica toda.