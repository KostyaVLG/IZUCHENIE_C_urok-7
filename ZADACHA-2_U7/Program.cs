// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите номер строки: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер cтолбца: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] resMatrix = new int [15,15];

FillArrayRandomNumbers(resMatrix);

PrintMatrix(resMatrix);

if (rows > resMatrix.GetLength(0) || columns > resMatrix.GetLength(1))
{
 Console.WriteLine("такого элемента нет");
}
else
{
 Console.WriteLine($"значение элемента {rows} строки и {columns} столбца равно {resMatrix[rows-1,columns-1]}");
}
void FillArrayRandomNumbers(int[,] array)
{
 for (int i = 0; i < array.GetLength(0); i++)
        {        
 for (int j = 0; j < array.GetLength(1); j++)
            {
 array [i,j] = new Random().Next(-100, 100);
         }   
}
}    
void PrintMatrix(int[,] array)                                       // Метод, который печатает массив 
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