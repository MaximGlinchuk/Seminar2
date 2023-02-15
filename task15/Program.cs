Console.WriteLine("Введите день недели: ");
int DayOfWeek = Convert.ToInt32(Console.ReadLine());
if (DayOfWeek >= 1 && DayOfWeek <= 5)
{
    Console.WriteLine("Сегодня будний день! :(");
}
else if (DayOfWeek >= 6 && DayOfWeek <= 7)
{
    Console.WriteLine("Сегодня выходной день! :)");
}
else
Console.WriteLine("Такого дня недели не существует!");