/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3.
Первоночальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
*/

Console.Clear();
Console.WriteLine("Введите длинну массива ");
int N = Convert.ToInt32(Console.ReadLine());
string[] MassivFirst = new string[N];

for (int i = 0; i < N; i++)
{
    Console.WriteLine($"Введите Значение {N - 1} в массив :");
    MassivFirst[i] = Console.ReadLine();
}



