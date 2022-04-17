Console.WriteLine("Введите трёх значное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number3 = number % 10;
Console.Write("Последняя цифра: " + number3);