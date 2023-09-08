// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите диапозон рандомного числа начиная с меньшего и заканивая пределом: ");
int s = int.Parse(Console.ReadLine());
int e = int.Parse(Console.ReadLine());
Random rnd = new Random();
int val = rnd.Next(s,e);
Console.WriteLine(val);
