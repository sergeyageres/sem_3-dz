//Программа проверяет пятизначное число на палиндромом
void Metod2(string number) 
{
if ( number[0] == number[4] && number[1] == number[3] )
    {
        Console.WriteLine("Палиндром");
    }
    else 
    {
        Console.WriteLine("Не палиндром");
    }
}
 Console.WriteLine("Введите 5-ти значный Палиндром");
string number = Console.ReadLine();

Metod2(number);