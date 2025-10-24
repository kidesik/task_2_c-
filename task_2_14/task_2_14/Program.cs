Console.WriteLine("Введите значения сторон а и б прямоугольного треугольника");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double c = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2));
Console.WriteLine(c);