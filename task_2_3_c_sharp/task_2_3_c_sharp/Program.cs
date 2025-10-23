{
    //Вариант а
    Console.WriteLine("");
    int a = Convert.ToInt32(Console.ReadLine());
    int mode_a = Math.Abs(a * 3);
    int sin_a = Convert.ToInt32(Math.Sin(mode_a));
    int divedent = 2 * a + sin_a;
    int result_division = Convert.ToInt32(divedent / 3.56);
    double? sqrt_result = Math.Sqrt(result_division);
    Console.WriteLine(sqrt_result);
}
{
    //Вариант б
    Console.WriteLine();
    int x = Convert.ToInt32(Console.ReadLine());
    int x_mode = Math.Abs(x * 5);
    int x_sqrt = Convert.ToInt32(Math.Sqrt(x + 1));
    double x_divedent = 3.2 + x_sqrt;
    double x_division = x_divedent / x_mode;
    int x_sin = Convert.ToInt32(Math.Sin(x_division));
    Console.WriteLine(x_sin);
}