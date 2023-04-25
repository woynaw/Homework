bool Even(int arg)
{
    if (arg % 2 == 0) return true;
    else return false;
}

Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{num1} -> {Even(num1)}");