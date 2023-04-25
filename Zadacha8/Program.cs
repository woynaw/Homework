void Even(int arg)
{
    if (arg % 2 == 0) Console.Write($"{arg} ");  
}
Console.WriteLine("Введите N");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
Console.Write($"{n} -> ");
while (count <= n) 
{
    Even(count);
    count++;
}