// See https://aka.ms/new-console-template for more information
Console.Write("Введите число -> ");
int i = int.Parse(Console.ReadLine());
//int i = Convert.ToInt32(Console.ReadLine());
i = i * i;
Console.WriteLine("Квадрат числа -> " + i);
Console.Write("Квадрат числа -> ");
Console.WriteLine(i);
Console.ReadKey();