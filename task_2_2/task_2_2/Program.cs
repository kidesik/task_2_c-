Console.WriteLine("Введите значения a");
int a = Convert.ToInt32(Console.ReadLine());
double result = (Math.Pow(a, 2) + 10) / Math.Sqrt(Math.Pow(a, 2) + 1);
Console.WriteLine("Результат:" + result);