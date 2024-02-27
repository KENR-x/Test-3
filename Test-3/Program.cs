using System;
class Test
{
    static void Main()
    {
        Console.WriteLine("Введите значение x: ");
        int x = Convert.ToInt32(Console.ReadLine());
        double y = (double)(x - 10) / (x * 10);
        Console.WriteLine("Число:  " + y);

    }
}
