using System;

public class Pessoa
{
  // Atributos
  protected string nome;
  protected int idade;

  // Método
  protected void mensagemPessoa()
  {
    Console.WriteLine("Nome: " + nome);
    Console.WriteLine("Idade: " + idade);
  }
}

// O conceito de Herança consiste na criação de classes filhas derivadas de uma classe pai, herdando assim atributos e/ou métodos dessa classe pai.

// Neste exemplo, estamos usando um novo modificador de acesso, o "protected":
/*
  protected -> pode ser acessado somente pela classe em que foi declarado e as classes que herdaram dados dessa classe.
*/