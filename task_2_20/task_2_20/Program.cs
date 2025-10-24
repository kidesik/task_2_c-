Console.WriteLine("Введение значения e,f,g,h");
double e = Convert.ToDouble(Console.ReadLine());
double f = Convert.ToDouble(Console.ReadLine());
double g = Convert.ToDouble(Console.ReadLine());
double h = Convert.ToDouble(Console.ReadLine());
double a =Math.Pow(Math.Pow(Math.Abs(e-(3/f)),3) + g,1/2);
double b = Math.Sin(e)+ Math.Pow(Math.Cos(h),2);
double c = (33*g)/(e*f-3);
Console.WriteLine("a = "+a+"  b= "+b+"  c ="+c);