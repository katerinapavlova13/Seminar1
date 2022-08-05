Console.WriteLine("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a<0)
{
    a = -a;
}
for (int i = -a; i <= a; i++)
{
    Console.Write($"{i}, ");
}