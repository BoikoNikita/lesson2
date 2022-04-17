Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

if(number>=100 && number<1000)
{
    Console.WriteLine("Третья цифра числа: " + number % 10);
}

if(number>=1000 && number<10000)
{
    int number1 = number % 100;    
    Console.WriteLine("Третья цифра числа: " + number1 / 10);
}

if(number>=10000 && number<100000)
{
    int number2 = number % 1000;    
    Console.WriteLine("Третья цифра числа: " + number2 / 100);
}

if(number<100)
{
    Console.WriteLine("Третья цифра отсутствует!");
}