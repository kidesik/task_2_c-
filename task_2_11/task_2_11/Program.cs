Console.WriteLine("Введите объем и массу тела");
double m = Convert.ToInt32(Console.ReadLine()); //масса
double p = Convert.ToInt32(Console.ReadLine()); //плотность
double v = m / p; //объем
Console.WriteLine(v);