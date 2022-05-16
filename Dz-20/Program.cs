/* Задача 21: Напишите программу,
 которая принимает на вход координаты двух точек
 и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

 */


double GetLength(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double leng = Math.Sqrt(((x1-x2)*(x1-x2))+((y1-y2)*(y1-y2))+((z1-z2)*(z1-z2)));
    leng = Math.Round(leng, 2);
    return leng;
}


//функция, которая получает число, введенное с клавиатуры
// + проверка на то, что ввели именно число
int GetNumber(string msg)
{
    while (true)
    {
        Console.WriteLine(msg);
        string valueFromConsole = Console.ReadLine();

        if (int.TryParse(valueFromConsole, out int number))
        {
            return number;
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Нужно ввести число, отличное от нуля.");
        }
    }
}

System.Console.WriteLine("Для расчета растояния введите координаты точек А и В");
string messageI = "Введите Координату точки А!  Х=";
int x1 = GetNumber(messageI);
messageI = "Введите Координату точки А!  Y=";
int y1 = GetNumber(messageI);
messageI = "Введите Координату точки А!  Z=";
int z1 = GetNumber(messageI);
messageI = "Введите Координату точки B!  Х=";
int x2 = GetNumber(messageI);
messageI = "Введите Координату точки B!  Y=";
int y2 = GetNumber(messageI);
messageI = "Введите Координату точки B!  Z=";
int z2 = GetNumber(messageI);

double leng = GetLength(x1, y1, z1, x2, y2, z2);


Console.WriteLine($"Расстояние между А и B  = {leng}");