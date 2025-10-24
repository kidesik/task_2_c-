Console.WriteLine("Введите значени h");
int h = Convert.ToInt32(Console.ReadLine()); //Высота точки наблюдения над поверхностью в метрах
int R = 6350; // радиус
int S = Convert.ToInt32(Math.Sqrt(2*R + h * h));
Console.WriteLine(S);