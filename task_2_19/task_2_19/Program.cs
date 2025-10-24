Console.WriteLine("Введите значения a и b");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double x = ((2/(Math.Pow(a,2)+25))+b) / (Math.Pow(b,1/2)+((a+b)/2));
double y = (Math.Abs(a)+2*Math.Sin(b))/5.5*a;
Console.WriteLine(x);
Console.WriteLine(y);