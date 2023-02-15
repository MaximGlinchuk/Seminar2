Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string StrNumber = number.ToString();
if (number < 100)
{
    Console.WriteLine("В данном числе нет третьей цифры");
}
else;
Console.WriteLine("Третье число: " + StrNumber[2]);
Console.WriteLine("Третье число с конца: " + StrNumber[^3]);