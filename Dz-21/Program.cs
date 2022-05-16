/*Задача 23: Напишите программу,
 которая принимает на вход число (N)
 и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27 
5 -> 1, 8, 27, 64, 125

*/

void GetCube(int N)
{
    foreach (int ind in Enumerable.Range( 1, N ))
    System.Console.Write($"{ind * ind * ind}, ");
    
}

int GetNumber(string msg)
{
    while (true)
    {
        Console.WriteLine(msg);
        string valueFromConsole = Console.ReadLine();

        if (int.TryParse(valueFromConsole, out int number))
        {
            if (number > 0)
                return number;
            else
            {
                Console.WriteLine("Число должно быть больше 0. Введите другое число");
            }
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Нужно ввести число, отличное от нуля.");
        }
    }
}

string messageI = "Введите N от 1,  N=";
int cube = GetNumber(messageI);
GetCube(cube); 
