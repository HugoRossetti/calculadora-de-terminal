using calculadora_de_terminal.Models;

Calculadora calc = new Calculadora();
Boolean exibirMenu = true;

Console.Clear();
Console.WriteLine("Bem vindos(as), a Calculadora de Terminal Simples (precione ENTER para começar!)");
Console.ReadLine();

while (exibirMenu)
{

  Console.Clear();
  Console.WriteLine("Escolha a operação desejada: ");
  Console.WriteLine("1 - Soma");
  Console.WriteLine("2 - Subtração");
  Console.WriteLine("3 - Multiplicação");
  Console.WriteLine("4 - Potenciação");
  Console.WriteLine("5 - Seno");
  Console.WriteLine("6 - Coseno");
  Console.WriteLine("7 - Tangente");
  Console.WriteLine("8 - Raiz Quadrada");
  Console.WriteLine("9 - Sair");


  string opcao = Console.ReadLine().ToUpper();
  Console.Clear();

  if (opcao == "5" || opcao == "6" || opcao == "7")
  {

    Console.WriteLine("Digite o angulo: ");
    double angulo = Convert.ToDouble(Console.ReadLine());

    switch (opcao)
    {
      case "5":
        calc.Seno(angulo);
        Console.ReadLine();
        break;
      case "6":
        calc.Coseno(angulo);
        Console.ReadLine();
        break;
      case "7":
        calc.Tangente(angulo);
        Console.ReadLine();
        break;
    }

  }
  else if (opcao == "8")
  {

    Console.WriteLine("Digite o valor para saber a Raiz: ");
    double raiz = Convert.ToDouble(Console.ReadLine());

    calc.RaizQuadrada(raiz);
    Console.ReadLine();

  }
  else if (opcao == "9")
  {
    exibirMenu = false;
  }
  else
  {

    Console.WriteLine("Digite o primeiro Numero: ");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.Clear();
    Console.WriteLine("Digite o segundo Numero: ");
    double b = Convert.ToDouble(Console.ReadLine());

    switch (opcao)
    {
      case "1":
        calc.Somar(a, b);
        Console.ReadLine();
        break;
      case "2":
        calc.Subtrair(a, b);
        Console.ReadLine();
        break;
      case "3":
        calc.Dividir(a, b);
        Console.ReadLine();
        break;
      case "4":
        calc.Multiplicar(a, b);
        Console.ReadLine();
        break;
      case "5":
        calc.Potencia(a, b);
        Console.ReadLine();
        break;
      default:
        Console.WriteLine("Opção Inválida");
        break;
    }
  }
}

Console.WriteLine("Encerrando...");