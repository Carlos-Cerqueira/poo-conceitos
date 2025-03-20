using System;

class Imposto
{
  // Métodos

  public virtual void valeAlimentacao(double salario)
  {
    Console.WriteLine("Desconto padrão do vale alimentação: R$" + (salario * 0.1));
  }

  public void valeTransporte(double salario)
  {
    Console.WriteLine("Desconto padrão do vale transporte: R$" + (salario * 0.06));
  }
}

// O Polimorfismo trata-se de um conceito que permite que diferentes classes filhas respondam de maneiras diferentes aos métodos herdados da classe pai.

// O método "virtual" indica que esse método pode ser sobrescrito (override), diferente do método "abstract", que impõe que este método deve ser sobrescrito.
