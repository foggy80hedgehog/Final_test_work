/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3.
Первоночальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
*/

//Метод вычисления длинны строки


Console.Clear();
Console.WriteLine("Введите длинну массива ");
int N = Convert.ToInt32(Console.ReadLine());
string[] MassivFirst = new string[N];
string[] MassivTwo = new string[0]
for (int i = 0; i < N; i++)
{
    Console.WriteLine($"Введите Значение в ячейку {i} массива :");
    MassivFirst[i] = Console.ReadLine();
}
int j = 0;
for (int i = 0; i < N; i++)
    
{
    if (MassivFirst[i].Length >= 3)
        MassivTwo[j] = MassivFirst[i];
    j++;
}





