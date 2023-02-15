Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number >= 1000)
{
    Console.WriteLine($"Число {number} - не трехзначное");
    return;
}
Console.WriteLine("Второе число = " + ((number - ((number / 100) * 100))/10));

