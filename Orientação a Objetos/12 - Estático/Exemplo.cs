using System;

class Exemplo
{
  // Atributo estático
  public static string nome = "Carlos";

  // Método estático
  public static void soma(int n1, int n2)
  {
    Console.WriteLine(n1 + n2);
  }
}

// O conceito de atributos e métodos estáticos consiste em acessar dados sem necessariamente chamar o objeto, mas somente requisitando o próprio dado.