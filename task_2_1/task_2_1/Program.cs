{
    //a
    Console.WriteLine("y=17x^2 - 6x +13 , введите значение x");
    int x = Convert.ToInt32(Console.ReadLine());
    double y = 17 * Math.Pow(x, 2) - 6 * x + 13;
    Console.WriteLine("y=" + y);
}
{
    //b
    Console.WriteLine("y= 3a^2 + 5a -21, введите значения a");
    int a = Convert.ToInt32(Console.ReadLine());
    double y = 3 * Math.Pow(a, 2) + 5 * a - 21;
    Console.WriteLine("y=" + y);
}