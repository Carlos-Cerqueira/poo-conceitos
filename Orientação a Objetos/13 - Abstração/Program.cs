using System;

namespace _13Abstracao
{
  class Program
  {
    static void Main(string[] args)
    {
      PessoaFisica pf = new PessoaFisica();
      pf.taxaEmprestimo(10000);

      PessoaJuridica pj = new PessoaJuridica();
      pj.taxaEmprestimo(10000);
    }
  }
}
