// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] GetMatrix(int m, int n, int minRandom, int maxRandon){

    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++){

        for (int j = 0; j < n; j++){
            matrix[i, j] = new Random().Next(minRandom, maxRandon);        
        }        
    }
    return matrix;
}

// Напечатать массив
void PrintMatrix(int[,] inputMatrix){
    for (int i = 0; i < inputMatrix.GetLength(0); i++){
        for (int j = 0; j < inputMatrix.GetLength(1); j++){
            Console.Write(inputMatrix[i, j] + "\t"); // Tab между элементами    
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите данные для формирования матрицы: ");
Console.Write("Количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = GetMatrix(rows, columns, 0, 10);
Console.WriteLine("Введите данные для поиска элемента: ");
Console.Write("Номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Номер столбца: ");
int column = Convert.ToInt32(Console.ReadLine());

if (row >= matrix.GetLength(0) || row < 0 || column >= matrix.GetLength(1) || column < 0){
    Console.WriteLine("Такого элемента нет");
    return;
}
PrintMatrix(matrix);
int number = matrix[row, column];
Console.WriteLine($"Значение элемента на позиции [{row}, {column}]: {number}");
