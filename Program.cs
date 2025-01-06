using calculadora_de_terminal.Models;

Calculadora calc = new Calculadora();

Console.Clear();
Console.WriteLine("Bem vindos(as), a calculadora simple de Terminal (precione ENTER para começar!)");
Console.ReadLine();

Console.Clear();
Console.WriteLine("Digite ==> Soma = (S), Subitrair = (Sb), Dividir = (D), Multiplicar = (M), \n  Potencia = (P), Seno = (Sen), Coseno = (Cos), Tangente = (Tan), Raiz quadrada = (Raiz): ");

string opcao = Console.ReadLine().ToUpper();
Console.Clear();

if (opcao == "SEN" || opcao == "COS" || opcao == "TAN")
{

  Console.WriteLine("Digite o angulo: ");
  double angulo = Convert.ToDouble(Console.ReadLine());

  switch (opcao)
  {
    case "SEN":
      calc.Seno(angulo);
      break;
    case "COS":
      calc.Coseno(angulo);
      break;
    case "TAN":
      calc.Tangente(angulo);
      break;
  }

}
else if (opcao == "RAIZ")
{

  Console.WriteLine("Digite o valor para saber a Raiz: ");
  double raiz = Convert.ToDouble(Console.ReadLine());

  calc.RaizQuadrada(raiz);

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
    case "S":
      calc.Somar(a, b);
      break;
    case "SB":
      calc.Subtrair(a, b);
      break;
    case "D":
      calc.Dividir(a, b);
      break;
    case "M":
      calc.Multiplicar(a, b);
      break;
    case "P":
      calc.Potencia(a, b);
      break;
    default:
      Console.WriteLine("Opção Inválida");
      break;
  }
}