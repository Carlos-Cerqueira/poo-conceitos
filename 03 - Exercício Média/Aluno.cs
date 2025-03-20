using System; // Necessário pois usaremos Console.WriteLine

public class Aluno
{
  // Atributos
  public string nome;
  public double nota1, nota2;

  // Média
  public double CalcularMedia()
  {
    return (nota1 + nota2) / 2;
  }

  // Situação
  public string InformarSituacao(double media)
  {
    return media >= 6 ? "aprovado" : "reprovado";
  }

  // Mensagem
  public void Mensagem()
  {
    double obterMedia = CalcularMedia();
    string obterSituacao = InformarSituacao(obterMedia);

    Console.WriteLine(nome + ", sua média foi de: " + obterMedia + " e você foi " + obterSituacao + ".");
  }
}

// Lembre-se de consultar o Program.cs desta pasta para compreender a lógica toda.