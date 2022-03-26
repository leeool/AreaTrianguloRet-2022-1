double Base, altura;

Console.Write("Entre com a base: ");
Base = Convert.ToDouble(Console.ReadLine());

Console.Write("Entre com a altura: ");
altura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Area...: {(altura * Base) / 2:N2}");