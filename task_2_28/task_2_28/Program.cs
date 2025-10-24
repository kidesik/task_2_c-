Console.WriteLine("Введите длину меньшего основания трапеции: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину большего основания трапеции: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите угол при большем основании: ");
int c = Convert.ToInt32(Console.ReadLine());
double h = (b - a) / 2 * Math.Tan(c);
double S = ((a + b) / 2) * h;
Console.WriteLine("Площадь трапеции равна " + S);