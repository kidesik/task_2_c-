Console.WriteLine("Введите растояние");
int S = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите скорость первого автомобиля");
int V_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите скорость второго автомобиля");
int V_2 = Convert.ToInt32(Console.ReadLine());
double t = 0.5;
double D = S +(V_1 - V_2) * t;
Console.WriteLine("Растояние между автомобилями через 30 минут" + D);
