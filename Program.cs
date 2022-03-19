double tamanhoBase, altura, area;

Console.Write("Insira o tamanho da base do triângulo: ");
tamanhoBase = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Insira a altura do triângulo: ");
altura = Convert.ToDouble(Console.ReadLine()!);

area = (altura * tamanhoBase) / 2;

Console.WriteLine($"A área desse triângulo é de {area}");