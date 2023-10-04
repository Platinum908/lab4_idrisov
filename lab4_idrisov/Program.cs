//Лабораторная 4,Высокий уровень, задание 11

Console.Write("Введите x");
double x = double.Parse(Console.ReadLine());
Console.Write("Введите y");
double y = double.Parse(Console.ReadLine());
Console.WriteLine(y <= 1 && y >= -1 && y >= -x && y >= x);