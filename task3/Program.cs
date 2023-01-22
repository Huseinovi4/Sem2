Console.WriteLine("Введите x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
  Console.WriteLine("I четверть");
else if (x > 0 && y < 0)
  Console.WriteLine("IV четверть");
else if (x < 0 && y > 0)
  Console.WriteLine("II четверть");
else if (x < 0 && y < 0)
  Console.WriteLine("III четверть");
else if (x == 0 || y == 0)
  Console.WriteLine("Точка является началом координат или лежит на одной из осей x или y");
