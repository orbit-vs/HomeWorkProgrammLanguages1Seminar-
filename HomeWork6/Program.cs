
int numb;
System.Console.Write("Введите целое число: ");
while(!Int32.TryParse(Console.ReadLine(), out numb))
{
    System.Console.Write("Некорректный ввод! Введите целое число: ");
}
if(numb % 2 == 0)
{
    System.Console.WriteLine("Чётное");
}
else
{
    System.Console.WriteLine("Нечётное");
}