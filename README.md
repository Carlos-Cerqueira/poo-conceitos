# Programação Orientada a Objetos (C# e .NET)

Ao construir um programa em C# e .NET, executamos o comando:

```
  dotnet new console
```

Esse comando gerará arquivos de compilação com configurações primárias para o funcionamento do algoritmo. O arquivo index é o `Program.cs`.

Consideraremos o modelo antigo de geração de arquivos do .NET. Portanto, o seguinte código será gerado:

```c#
using System;

namespace Exemplo
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }
}
```

O método ``Main()`` é o método primário à ser executado. É declarado somente uma vez pois é o "index" do projeto.

Em POO, as **Classes** são as entidades de um diagrama, dão nomes aos **Objetos** e possuem **Atributos** e **Métodos**. Exemplo:

```c#
using System;

class Pessoa
{
  // Atributo
  public string nome;

  // Método
  public void Falar()
  {
    Console.WriteLine("Olá, eu sou "+ nome);
  }
}
```

Os **Atributos** são informações relacionadas ao elemento em questão, seus dados são armazenados em variáveis e possuem modificadores de acesso, os principais são:

+ **Public:** Pode ser acessado por todas as classes.
+ **Private:** Somente a classe onde está definido tem acesso. 
+ **Protected:** Somente a classe onde está definido e as classes herdeiras dessa classe tem acesso. 

A variação entre os modificadores de acesso consiste em utilizar o dado em outra classe (utilizar *public*), utilizar o dado somente para realizar operações na classe em que foi declarado (utilizar *private*) ou utilizar esse dado somente para operações em comum com as classes filhas. (utilizar *protected*).

Os **Métodos** são funções que expressam as ações executadas pelas classes, possuindo também modificadores de acesso. Falaremos mais sobre métodos adiante.

Atribuindo informações à ``class Pessoa``:

```c#
using System;

namespace Exemplo
{
  class Program
  {
    static void Main(string[] args)
    {
      // Instanciando um objeto

      Pessoa obj = new Pessoa();

      obj.nome = "Carlos";
      obj.Falar();
    }
  }
}
```

O resultado exibido no console pelo método ``Falar()`` será portanto _"Olá, eu sou Carlos"_.

**Curiosidade:** Embora não seja uma boa prática, é possível declarar métodos com nomes iguais desde que possuam parâmetros diferentes.

## Encapsulamento

O **Encapsulamento** consiste em restringir o acesso à atributos e métodos (através de modificadores de acesso) aos locais onde são necessário e mais nenhum outro. Exemplo:

```c#
using System;

class Aluno
{
  // Atributo
  private double nota1, nota 2;

  // Método
  private double Media()
  {
    return (nota1 + nota2) / 2;
  }

  public void Mensagem()
  {
    Console.WriteLine("Nota 1: ");
    nota1 = Convert.toInt32(Console.ReadLine());

    Console.WriteLine("Nota 2: ");
    nota2 = Convert.toInt32(Console.ReadLine());
  }
}
```

No exemplo anterior, o método ``Media()`` e os atributos *nota1* *nota2* foram definidos como **private**, assim restringindo seu acesso (encapsulando-os) somente à ``class Aluno``.

Apenas o método ``Mensagem()`` não foi encapsulado (foi definido como **public**), para que possa ser chamado pela ``class Program`` e assim executar o algoritmo.

## Método Construtor

O **Método Construtor** é executado instanciando um método que carrega o nome da **Classe**. Exemplo:

```c#
using System;

class Pessoa
{
  public Pessoa()
  {
    Console.WriteLine("Construtor criado!");
  }

  public Pessoa(string nome)
  {
    Console.WriteLine("Olá " + nome);
  }
}
```

Note que é possível instanciar diferentes construtores para uma mesma **Classe**, sendo necessário somente diferenciar os parâmetros.

## Métodos Get e Set

+ **Get:** Recebe dados.
+ **Set:** Envia dados.

Exemplo:

```c#
using System;

class Pessoa
{
  private string nome;

  public string Nome
  {
    get { return nome; }
    set { nome = value; }
  }
}
```

No exemplo anterior, requisitamos o valor do atributo privado "nome" para o atributo "Nome".

O atributo "Nome" possui os métodos ``get`` para receber o valor do atributo **nome** (e retornando como resposta do método) e ``set`` para definir o novo valor do atributo **nome**. É possível também escrever de uma forma simplificada:

```c#
using System;

class Pessoa
{
  public string Nome { get; private set; }
}
```

Observe o Program.cs:

```c#
using System;

namespace Exemplo
{
  class Program
  {
    static void Main(string[] args)
    {
      Pessoa p = new Pessoa();

      p.Nome = "Carlos"; // set: está adicionando o dado.

      Console.WriteLine(p.Nome) // get: para exibir o value "Carlos" inserido através do método set, está usando get para buscar o dado.
    }
  }
}
```

## Modificador this

Modificador **this**: Utilizado para especificar ao compilador que o atributo desejado pertence à classe e não ao método. Exemplo:

```c#
using System;

class Pessoa
{
  private string nome = "Teste";

  public Pessoa (string nome)
  {
    Console.WriteLine("Olá, " + nome); // 1
    Console.WriteLine(this.nome); // 2
  }
}
```

No 1º Console, o dado exibido será o valor passado no parâmetro.
No 2º Console, o dado exibido será o atributo "nome" pertencente à Classe, portanto "Teste".

## Herança 

**Herança** consiste no conceito de classes filhas herdando atributos e/ou métodos de uma classe pai. Exemplo:

```c#
using System;

class Pessoa
{
  protected string nome;

  protected void MensagemPessoa()
  {
    Console.WriteLine(nome);
  }
}

public class Colaborador : Pessoa
{
  private double salario;

  public Colaborador (string nome, double salario)
  {
    this.nome = nome;
    this.salario = salario;

    mensagemPessoa();
    mensagemColaborador();
  }

  private void mensagemColaborador()
  {
    Console.WriteLine(salario);
  }
}
```

Note que a classe filha ``class Colaborador`` herdou o atributo **nome** da classe pai. Sendo esse em resumo o conceito de Herança.

## Polimorfismo

O **Polimorfismo** é um conceito existente para definir que métodos herdados podem tem comportamentos diferentes nas classes filhas. Exemplo:

```c#
using System;

class Desconto
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

class Gerente : Imposto
{
  public override void valeAlimentacao(double salario)
  {
    Console.WriteLine("Desconto gerente do vale alimentação: R$" + (salario * 0.15));
  }
}

class Atendente : Imposto
{
  public override void valeAlimentacao(double salario)
  {
    Console.WriteLine("Desconto atendente do vale alimentação: R$" + (salario * 0.12));
  }
}
```

O método ***virtual*** indica que esse método pode ser sobrescrito (***override***). Diferente do método ***abstract***, que deve ser sobrescrito.

## Elementos Estáticos (static)

O conceito de métodos e atributos estáticos (***static***) consiste em acessar dados sem requisitar o objeto, apenas requisitando o próprio dado. Exemplo:

```c#
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
```

Observe agora como é feita a requisição:

```c#
using System;

namespace Exemplo
{
  class Program
  {
    static void Main(string[] args)
    {
      Exemplo.soma(3, 7);

      Console.WriteLine("Olá " + Exemplo.nome);
    }
  }
}
```

Note que um novo objeto não é construído para a compilação (*Exemplo e = new Exemplo()*). Nós apenas requisitamos atributos e métodos estáticos desejados (*Exemplo.nome* e *Exemplo.soma()*).

## Abstração

A **Abstração** é um conceito onde uma classe com o método ***abstract*** contém métodos obrigatórios para todas as suas classes filhas.

**Não** é possível instanciar uma classe abstrata(*Exemplo: Pessoa p = new Pessoa()*), pois trata-se de um padrão que as classes filhas devem seguir e não a lógica em si.

É possível criar métodos não obrigatórios (simplesmente não utilizando o termo ***abstract***), para que as classes filhas possam utilizar esses métodos mas não sejam obrigadas.

Exemplo:

```c#
using System;

public abstract class Padrao
{
  // Método Obrigatório
  public abstract void taxaEmprestimo(double valor);

  // Método Opcional
  public void calculoPoupanca(double valor, double taxa)
  {
    Console.WriteLine("Ganhos obtidos pela poupança R$ " + (valor * taxa));
  }
}

class PessoaFisica : Padrao
{
  // Método Obrigatório
  public override void taxaEmprestimo(double valor)
  {
    Console.WriteLine("Taxa de empréstimo para Pessoa Física: R$ " + (valor * 0.1));
  }
}
```

Note que ``taxaEmprestimo()`` em ``class Padrao`` não possui objeto, pois trata-se apenas de um modelo, mas em ``class PessoaFisica`` existe um objeto e um cálculo. Para que isso fosse possível, o método ***override*** foi utilizado (para sobrescrever o método anterior).

## Interface

Uma ***interface*** é parecida com um ***abstract***, com a diferença de que é utilizada exclusivamente para métodos obrigatórios com parâmetros imutáveis, sem existir a possibilidade de criar métodos opcionais.

Uma classe pode criar várias interfaces e por padrão todas são públicas e abstratas (já que não possuem outra utilidade senão serem herdadas e adaptadas por classes filhas).

Os métodos de uma ***interface*** não possuem qualquer tipo de cálculo ou algoritmo. São apenas modelos.

Nas boas práticas, toda ***interface*** possui o prefixo "I" no nome do método.

Exemplo:

```c#
using System;

interface IPadrao
{
  void somar(int n1, int n2);

  void subtrair(int n1, int n2);
}

class Calculo : IPadrao
{
  public void somar(int n1, int n2)
  {
    Console.WriteLine("A soma é: " + (n1 + n2));
  }

  public void subtrair(int n1, int n2)
  {
    Console.WriteLine("A subtração é: " + (n1 - n2));
  }
}
```