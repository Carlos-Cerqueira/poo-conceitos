using System; // Necessário pois usaremos Console.WriteLine

class Aluno
{
  // Atributos
  private double nota1, nota2;

  // Média
  private double Media()
  {
    return (nota1 + nota2) / 2;
  }

  public void Mensagem()
  {
    Console.WriteLine("Informe a primeira nota"); // Exibe texto para o usuário
    nota1 = Convert.ToInt32(Console.ReadLine()); // Lê o que o usuário escreveu, converte o dado para um número inteiro de base 32 e atribui para a variável "nota1"

    Console.WriteLine("Informe a segunda nota"); // Exibe texto para o usuário
    nota2 = Convert.ToInt32(Console.ReadLine()); // Lê o que o usuário escreveu, converte o dado para um número inteiro de base 32 e atribui para a variável "nota2"

    Console.WriteLine("A média é " + Media());
  }
}

// O Encapsulamento consiste em restringir o acesso à determinados atributos e métodos aos locais onde elas são necessárias e mais nenhum outro.

// Neste exemplo, definimos o método Media() e os atributos (variáveis) nota1 e nota2 como private, assim restringindo seu acesso (encapsulando-os) somente à Classe Aluno.

// O único item não encapsulado foi o método Mensagem(), para que possa ser chamado pela classe Program e assim executar o programa.

// Lembre-se de consultar o Program.cs desta pasta para compreender a lógica toda.