Console.WriteLine("Введите 2 числа");
int a1 = Convert.ToInt32(Console.ReadLine());
int a2 = Convert.ToInt32(Console.ReadLine());
int n = 2;
int arithmetic = (a1 + a2) / n;
double geometric = Math.Pow((a1 * a2),1/n);
Console.WriteLine("Среднее арифметическое:" +  arithmetic + "\n" + "Среднее геометрическое:" + geometric);