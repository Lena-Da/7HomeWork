// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


Console.Write("Введи число m (размер массива): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи число n (размер массива): ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];
ArrayDouble(array);
PrintArray(array);


void ArrayDouble(double[,] array)
{
for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().Next(1, 50) / 10.0;
    }
  }
}


void PrintArray (double[,] array)
{
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        double number = Math.Round(array[i, j], 1);
        Console.Write(number + " ");
      }
      Console.WriteLine();
  }
}

