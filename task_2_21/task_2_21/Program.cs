Console.WriteLine("Введите значнеия e,f,g,h");
double e = Convert.ToDouble(Console.ReadLine());    
double f  = Convert.ToDouble(Console.ReadLine());
double g = Convert.ToDouble(Console.ReadLine());
double h = Convert.ToDouble(Console.ReadLine());
double a = (e + (f / 2)) / 3;
double b = Math.Abs(Math.Pow(h, 2) - g);
double c = Math.Sqrt(Math.Pow((g-h),2) - 3 * Math.Sin(e));
Console.WriteLine("a =" + a + " b =" + b + " c =" + c);