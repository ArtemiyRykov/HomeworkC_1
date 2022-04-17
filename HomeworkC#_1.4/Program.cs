Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int a = 2;
while(a <= N)
{
    Console.Write(a);
    a = a + 2;
    if(a <= N)
    {
        Console.Write(", ");
    }
}
