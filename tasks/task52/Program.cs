// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double[] ArrayOfRowsAvg(int[,] matrix){

    int countRows = matrix.GetLength(0);
    int countColumns = matrix.GetLength(1);

    double[] array = new double[countRows];

        for(int i = 0; i < countRows; i++){
            double sumRow  = 0;
            for (int j = 0; j < countColumns; j++){
                sumRow += matrix[i,j];
            }
            array[i] = sumRow / countColumns;
        }

    return array;
}

Console.WriteLine("Введите данные для формирования матрицы: ");
Console.Write("Количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = GetMatrix(rows, columns, 0, 10);
PrintMatrix(matrix);

double[] arrayOfAvg = ArrayOfRowsAvg(matrix);
Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join(";", arrayOfAvg)}");

