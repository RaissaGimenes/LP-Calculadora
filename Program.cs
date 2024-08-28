Calculadora calc = new Calculadora();
Console.WriteLine("Informe valor de x:");
double x = Convert.ToDouble (Console.ReadLine());
Console.WriteLine("Informe o valor de y:");
double y = Convert.ToDouble(Console.ReadLine());

 double resultadoSoma = calc.Soma(x,y);
 Console.WriteLine ($"O resultado da somar de {x} e {y} é igual a : {resultadoSoma}");

 Console.WriteLine($"O resultado da subtrair é: {calc.Subtracao(x,y)}");

 Console.WriteLine($"O resultado da Multiplicação é: {calc.Multiplicar(x,y)}");

 Console.WriteLine($"O resultado da Divisão é: {calc.Divisão(x,y)}");