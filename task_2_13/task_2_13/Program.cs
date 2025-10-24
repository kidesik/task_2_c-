Console.WriteLine("ax + b = 0 a!=0, введите значения a и b");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
if (a != 0)
{
    double x = a / -b;
    Console.WriteLine(x);
}
else if (b != 0 && a !=0) 
{
    Console.WriteLine("x любое число");
}
else
{
    Console.WriteLine("Error");
}