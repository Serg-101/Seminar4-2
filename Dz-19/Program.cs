/* Задача 19: Напишите программу,
 которая принимает на вход пятизначное число
  и проверяет, является ли оно палиндромом.

14212 -> нет
23432 -> да
12821 -> да
 */


bool GetPolindrom(int num)
{
    string numReverse = new string(num.ToString().Reverse().ToArray());
    string numFirst = num.ToString().Substring(0,2); 
    string numLast = numReverse.Substring(0,2);
    if (numFirst == numLast)
        return true;
    else
        return false;
}




//функция, которая получает число, введенное с клавиатуры
// + проверка на то, что ввели именно число
// + проверка, что число из 5 знаков
int GetNumber(string msg)
{
    while (true)
    {
        Console.Write(msg);
        string valueFromConsole = Console.ReadLine();

        if (int.TryParse(valueFromConsole, out int number))
        {
            if (number.ToString().Length == 5)
                return number;
            else
                Console.WriteLine("Вы ввели не пятизначное число. Попробуйте ввести пятизначное число.");
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Нужно ввести число, отличное от нуля.");
        }
    }
}

string messageI = "Введите пятизначное число А = ";
int a = GetNumber(messageI);

bool isPolindrom = GetPolindrom(a);

if (isPolindrom)
    Console.WriteLine("Число является полиндромом");
else
    Console.WriteLine("Число не является полиндромом");