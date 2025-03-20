using System;

namespace _05Acesso
{
  class Program
  {
    static void Main(string[] args)
    {
      Produto obj = new Produto();

      obj.nome = "Produto" // Funciona pois o atributo é public
      obj.valor = 30.50 // Não funciona pois o atributo é private
    }
  }
}
