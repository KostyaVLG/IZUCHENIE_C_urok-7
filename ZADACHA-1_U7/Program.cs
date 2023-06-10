// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество cтолбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] resMatrix = GetMatrix(rows, columns, -100, 1000);

// rows=3, columns=4 => таблица из 3 строк и 4 столбцов, элемент: число от 0 до 10 включительно

PrintMatrix(resMatrix);                                            // PrintMatrix(матрица)

double[,] GetMatrix(int m, int n, int min, int max)
{
   double[,] matrix = new double[m, n];                               // Таблица из m строк и n столбцов 
    for (int i = 0; i < matrix.GetLength(0); i++)         // Цикл по строчкам , i < m
    {
        // i,j,m,k 
        for (int j = 0; j < matrix.GetLength(1); j++)      // Цикл по стобцам , j < n
        {
            matrix[i, j] = Convert.ToDouble (new Random().Next(min, max + 1))/10;
        }
    }
    return matrix;
}

// Метод, который печатает массив 
void PrintMatrix(double[,] array)
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