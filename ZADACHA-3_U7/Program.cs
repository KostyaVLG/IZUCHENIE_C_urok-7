// Задача 3. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] resMatrix = new int[rows, columns];

Console.Write("среднее арифметическое элементов в каждом столбце: ");
Console.WriteLine();
FillArrayRandomNumbers(resMatrix);

for (int j = 0; j < resMatrix.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < resMatrix.GetLength(0); i++)
    {
        avarage = (avarage + resMatrix[i, j]);
    }
    avarage = avarage / rows;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArray(resMatrix);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
        }

}

void PrintArray(int[,] array)                                       // Метод, который печатает массив 
{
    for (int i = 0; i < array.GetLength(0); i++)             // строчки
    {
        for (int j = 0; j < array.GetLength(1); j++)        // столбцы
        {
            Console.Write(array[i,j] + "\t");                    // "\t" = Tab = 4 пробела между элементами
        }
        Console.WriteLine();
    }
}