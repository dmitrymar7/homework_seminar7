// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] GetMatrix(int m, int n, int minRandom, int maxRandon){

    double[,] matrix = new double[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++){

        for (int j = 0; j < n; j++){
            matrix[i, j] = Math.Round(minRandom + new Random().NextDouble()* (maxRandon - minRandom), 1);   
        }        
    }
    return matrix;
}

// Напечатать массив
void PrintMatrix(double[,] inputMatrix){
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

double[,] matrix = GetMatrix(rows, columns, -10, 10); 
PrintMatrix(matrix);