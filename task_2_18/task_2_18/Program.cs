Console.WriteLine("Введите значения x и y ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
double z = (x + (2 + y) / Math.Pow(x, 2)) / (y + (1 / (Math.Pow(Math.Pow(x, 2) + 10, 1 / 2))));
Console.WriteLine(z);
double q = 7.25 * Math.Sin(x) - Math.Abs(y);
Console.WriteLine(q);