// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] array = new int[3, 4];
ArrayInt(array);
double summa = 0;

for (int j=0;j<4;j++)
  { 
    for (int i = 0; i < 3; i++) 
    {
    summa += array[i,j];
    }
    summa = summa/3;
    Console.WriteLine("Среднее арифметическое столбца " + (j+1) +" : " + summa);
  }


void ArrayInt(int[,] array)
{
for (int i = 0; i < 3; i++)
  {
    for (int j = 0; j < 4; j++)
    {
      array[i, j] = new Random().Next(1, 10);
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}
