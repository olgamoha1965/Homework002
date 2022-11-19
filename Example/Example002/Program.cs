//Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

/*int Digits(int number) 
{
    int num1 = number / 10; 
    int num2 = num1 % 10; 
  
    return num2;
}

Console.WriteLine("Input 3digit number: ");
int user_num = Convert.ToInt32(Console.ReadLine());

if(user_num >= 100 && user_num < 1000)
{
    int res = Digits(user_num);
    Console.Write($"The second digit is {res}.");
}
else
Console.WriteLine($"Given number {user_num} is not 3digit number.");
*/

//Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

/*Console.WriteLine("Input number: ");
int user_num = Convert.ToInt32(Console.ReadLine());

if(user_num >= 1 && user_num < 100)
{
    Console.WriteLine($"Given number {user_num} is not contain a third digit.");
} 

if(user_num >= 100 && user_num < 1000)
{
    int user_num1 = (user_num % 100) % 10; 
    Console.WriteLine($"3digit number {user_num} is {user_num1}.");
}

if(user_num >= 1000)
{
    int user_num2 = user_num / 10;
    start:
    if(user_num2 >= 100 && user_num2 < 1000)
    {
       int user_num3 = (user_num2 % 100) % 10; 
       Console.WriteLine($"3digit number {user_num} is {user_num3}."); 
    }
    else
    {
        user_num2 = user_num2 / 10;
        goto start;
        
    }
}
*/

//Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

/*int DayOfTheWeek(int day) 
{
    if(day >= 1 && day <= 5)
    {
        Console.Write($"The day of the week {day} is not day off.");
    }
    if(day >= 6 && day <= 7)
    {
        Console.Write($"The day of the week {day} is day off.");  
    }
    return day;
}

Console.WriteLine("Input number indicating the day of the week ");
int user_day = Convert.ToInt32(Console.ReadLine());

if(user_day >= 1 && user_day <= 7)
{
    int res = DayOfTheWeek(user_day);
}
else
Console.WriteLine($"The given number {user_day} does not indicate the day of the week.");
*/