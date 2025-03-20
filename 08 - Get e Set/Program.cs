using System;

namespace _07GetSet
{
  class Program
  {
    static void Main(string[] args)
    {
      Pessoa p = new Pessoa();
      p.Nome = "Carlos"; // Set de informação, está adicionando um dado

      Console.WriteLine(p.Nome); // Get de informação, para exibir o dado "Carlos" inserido através de set no Método Nome, está usando get para buscar o dado no Método.
    }
  }
}
