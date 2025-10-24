Console.WriteLine("Введите кординаты точек A и B: ");
int Ax = Convert.ToInt32(Console.ReadLine());
int Ay = Convert.ToInt32(Console.ReadLine());
int Bx = Convert.ToInt32(Console.ReadLine());
int By  = Convert.ToInt32(Console.ReadLine());
double d = Math.Sqrt(Math.Pow((Ax - Bx), 2) + Math.Pow((Ay - By), 2));
Console.WriteLine("Расстояния между двумя точками: " + d);