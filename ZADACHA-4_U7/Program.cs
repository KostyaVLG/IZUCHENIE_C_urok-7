// Дополнительное:
// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.Write("Ведите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = GetMatrix(rows, columns);
PrintArray(matrix);

Console.Write("Сумма чисел главной диагонали: ");

int sumOfDiagonal = DiagSum(matrix);

Console.WriteLine(sumOfDiagonal);

int[,] GetMatrix(int rows, int columns)   // метод созданмия массива
{
    int[,] arr = new int[columns, rows];
    for (int i = 0; i < columns; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            arr[i, j] = j+i;
        }
    }
    return arr;
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

int DiagSum(int[,] arr)  //метод  для главной диагонали
{
    int res =0;
    int min=arr.GetLength(0)>arr.GetLength(1)?arr.GetLength(1):arr.GetLength(0);

   for (int i = 0; i < min; i=i+1)
    {
        res = res+ arr[i, i];
    } 
    return res;
}
