Console.WriteLine("Введите длину ребра куба");
int a = Convert.ToInt32(Console.ReadLine()); //ребро
int v = Convert.ToInt32(a *a * a); //объем
int P = Convert.ToInt32(4*a); //площадь стороны
Console.WriteLine(v);
Console.WriteLine(P);