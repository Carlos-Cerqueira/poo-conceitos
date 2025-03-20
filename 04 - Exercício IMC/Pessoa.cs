using System; // Necessário pois usaremos Console.WriteLine

class Pessoa
{
  public double peso, altura;

  public double retornarIMC()
  {
    return peso / (altura * altura);
  }

  public string categoriaIMC(double imc)
  {
    string retorno = "Indefinido";

    if (imc < 18.5) {
      retorno = "Abaixo do peso";
    } else if (imc < 25) {
      retorno = "Peso normal";
    } else if (imc < 30) {
      retorno = "Acima do peso";
    } else if (imc < 35) {
      retorno = "Obesidade I";
    } else if (imc < 40) {
      retorno = "Obesidade II";
    } else if (imc >= 40) {
      retorno = "Obesidade III";
    } 

    return retorno;
  }

  public void Mensagem()
  {
    double obterIMC = retornarIMC();
    string obterCategoria = categoriaIMC(obterIMC);

    Console.WriteLine("Seu IMC é de " + Math.Round(obterIMC, 2) + " e sua categoria é: " + obterCategoria + ".");
  }
}

// Lembre-se de consultar o Program.cs desta pasta para compreender a lógica toda.