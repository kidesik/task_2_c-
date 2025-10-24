Console.WriteLine("Введите длину стороны прямоугольника a и b");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());    
int p = 2 * (a + b);
double d = Math.Pow(Math.Pow(a + b, 2),1/2);
Console.WriteLine("Периметр: " + p + "\n" + "диагональ: " + d);