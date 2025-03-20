using System; // Biblioteca padrão .NET para arquivos de sistema. Está sendo chamada aqui para compilação do arquivo principal do projeto

namespace _02Metodos // namespaces são utilizados como "apelidos" para arquivos com nomes iguais mas em pastas diferentes, usado aqui pois não é estranho que hajam diferentes arquivos "Program.cs"
{
  class Program // Essa é a classe principal do projeto, a primeira a ser executada e carrega o nome do arquivo "Program.cs"
  {
    static void Main(string[] args) // Método principal Main(), só pode ser declarado uma vez pois trata-se do primeiro método a ser compilado na execução do programa
    {
      // Instanciando um objeto
      Pessoa obj = new Pessoa(); // Nesta linha declaramos a variável "obj" e seu tipo é "Pessoa", o valor da variável é "new Pessoa()".
      // Portanto, ao compilarmos o código, um novo objeto do tipo Pessoa é criado e os dados à seguir são adicionados ao objeto.

      obj.Apresentar();
      obj.Apresentar("Carlos");
      obj.Apresentar("Carlos", 21);

      // O retorno dos métodos Apresentar() serão respectivamente:
      // Olá!
      // Olá Carlos
      // Olá Carlos. Você tem 21 anos.

      // Como os parâmetros são diferentes, o compilador interpreta estes métodos como diferentes, mesmo tendo o mesmo nome.
    }
  }
}
