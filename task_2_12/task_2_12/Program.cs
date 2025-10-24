Console.WriteLine("Введите количество населения и площадь територии");
int people = Convert.ToInt32(Console.ReadLine()); //количество населения
int country  = Convert.ToInt32(Console.ReadLine());// площпдь территории страны
int v = people/country; //плотность населения
Console.WriteLine(v);