{
    //a
    Console.WriteLine("Введите 2 целых числа");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    int n = 2; // количество чисел
    int result = (a + b) / n;
    Console.WriteLine(result);
}
{
    //b
    Console.WriteLine("Введите 2 целых числа");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    int n = 2;
    double result = Math.Pow((a*b),1/n);
    Console.WriteLine(result);
}