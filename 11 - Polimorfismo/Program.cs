using System;

namespace _11Polimorfismo
{
  class Program
  {
    static void Main(string[] args)
    {
      // Instanciar Gerente

      Imposto objGerente = new Gerente();

      objGerente.valeAlimentacao(5000);
      objGerente.valeTransporte(5000);
      Console.WriteLine("--------------");

      // Instanciar Atendente

      Imposto objAtendente = new Atendente();

      objAtendente.valeAlimentacao(2000);
      objAtendente.valeTransporte(2000);
      Console.WriteLine("--------------");

      // Instanciar Estágiario

      Imposto objEstagiario = new Estagiario();

      objEstagiario.valeAlimentacao(1000);
      objEstagiario.valeTransporte(1000);

    }
  }
}
