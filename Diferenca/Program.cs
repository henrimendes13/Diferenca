int a, b, c, d, diferenca;

Console.WriteLine("DIGITE 4 VALORES PARA ENCONTRAR: (A * B - C * D).");

a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
c = int.Parse(Console.ReadLine());
d = int.Parse(Console.ReadLine());

diferenca = (a * b - c * d);

Console.WriteLine("DIFERENCA = "+diferenca);
