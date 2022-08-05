    Console.WriteLine("Введите трехзначное число: ");
    int a = Convert.ToInt32(Console.ReadLine());
 if (a >= 100 && a < 1000)
 {
Console.WriteLine($"Последняя цифра числа {a} = {a % 10}");
 }
 else
 Console.WriteLine("Введено не трехзначное число, попробуйте снова");