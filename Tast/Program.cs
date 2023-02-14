/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3.
Первоночальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
*/

//Метод вычисления длинны строки
void PrintArray(string[] matr)

{
    for (int i = 0; i < matr.Length; i++)
    {
        Console.Write($"{matr[i]} ");
    }
}

Console.Clear();
Console.WriteLine("Введите длинну массива ");
int N = Convert.ToInt32(Console.ReadLine());
string[] MassivFirst = new string[N];
string[] MassivTwo = new string[N];
for (int i = 0; i < N; i++)
{
    Console.WriteLine($"Введите Значение в ячейку {i} массива :");
    MassivFirst[i] = Console.ReadLine();
}

for (int i = 0; i < N; i++)

{
    if (MassivFirst[i].Length <= 3)
    {
        MassivTwo[i] = MassivFirst[i];
    }

}



Console.Clear();
Console.WriteLine("Начальный массив");
PrintArray(MassivFirst);
Console.WriteLine();
Console.WriteLine("Отсортированный массив из строк, длина которых меньше либо равна 3");
PrintArray(MassivTwo);
