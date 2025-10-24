Console.WriteLine("Введите внешнний и внутренний радиус");
double R = Convert.ToDouble(Console.ReadLine());
double r = Convert.ToDouble(Console.ReadLine());
double pi = 3.14;
double S = pi * (Math.Pow(R,2) -  Math.Pow(r,2));
Console.WriteLine(S);