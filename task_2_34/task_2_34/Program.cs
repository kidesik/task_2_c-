Console.WriteLine("Введите растояние");
int S = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите скорость первого автомобиля");
int V_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите скорость второго автомобиля");
int V_2 = Convert.ToInt32(Console.ReadLine());
int t = S / (V_1 + V_2);
Console.WriteLine("Через сколько часов они встретятся: " + t);