Console.WriteLine("Введите число, обозначающее день недели: ");
int number = int.Parse(Console.ReadLine());

if(number>7)
{
    Console.WriteLine("Такой день недели отсутствует!");
}
if(number<=5)
{
    Console.WriteLine("Рабочий день недели!");
}
if(number>=6 && number<=7)
{
    Console.WriteLine("Выходной!");
}