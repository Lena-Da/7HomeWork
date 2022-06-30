// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] array = new int[4, 5];
ArrayInt(array);

Console.WriteLine("Введите индекс строчки: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца: ");
int b = Convert.ToInt32(Console.ReadLine());
a = a - 1;
b = b - 1;

for (int i = 0; i < 4; i++)
  {
    for (int j = 0; j < 5; j++)
    {
        if (a == i && b == j)
        Console.WriteLine($"Элемент: {array[i,j]} ");
    }
    
  }

for (int i = 0; i < 4; i++)
  {
    for (int j = 0; j < 5; j++)
    {
    if (a > i && b > j)
    Console.WriteLine("Такого элемента нет");
    break;
    }
  }


void ArrayInt(int[,] array)
{
for (int i = 0; i < 4; i++)
  {
    for (int j = 0; j < 5; j++)
    {
      array[i, j] = new Random().Next(1, 50);
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}
