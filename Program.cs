// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“4Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Write("Введите количество строк в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());

string[] AS;
AS = new string[N];
for (int i = 0; i < N; i++)
{
    Console.Write("Введите элемент с индексом " + i + ": ");
    AS[i] = Console.ReadLine();
}
int count = 0;
for (int i = 0; i < N; i++)
{
    if (AS[i].Length <= 3)
    {
        count++;
    }
}

Console.Write("[");

int M = count;
string[] BS;
BS = new string[M];
int j = 0;
for (int i = 0; i < N; i++)
{
    if (AS[i].Length <= 3)
    {
        BS[j] = AS[i];
        Console.Write(BS[j] + "; ");
        j++;
    }
}

Console.Write("]");