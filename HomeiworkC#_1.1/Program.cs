Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");

int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA > numberB)
{
    Console.WriteLine("Наибольшее число: " + numberA);
    Console.WriteLine("Наименьшее число: " + numberB);
}
else
{
    Console.WriteLine("Наибольшее число: " + numberB);
    Console.WriteLine("Наименьшее число: " + numberA);

}