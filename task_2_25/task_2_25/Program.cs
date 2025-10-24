Console.WriteLine("Введите длины сторон прямоугольного параллелепипеда:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int V = a * b * c;
int s = 2 * c * (a + b);
Console.WriteLine("Объем: " + V + "\n" + "Площадь боковой поверхности: " + s);