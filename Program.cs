// Типы алгоритмов

/*
1. Константные O(1) одно или несколько действий - известно заранее
2. Логарифмические O(log2(n)) бинарный поиск
8. корень
3. Линейные O(n) кол-во действий зависит от n
4. Линейно-логарифмические O(log2(n) * n) быстрая сортировка
5. Квадратичные O(n ^ 2) цикл в цикле
6. Кубические O(n ^ 3)
7. Задача о комивояжере(N!)

Лекции по C#(Последовательность Фиббоначи) O(2 ^ n)


*/
// Напишите программу, которая принимает на вход одно число и возвращает сумму чисел от 1 до N
// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!), result = 0;
// for (int i = 1; i <= n; i++)
//     result += i;
// Console.WriteLine($"Сумма чисел от 1 до {n} = {result}");
//Console.WriteLine(((1 + n) / 2.0) * n);
// Sn = ((a0 + an) / 2) * n = = ((1+n)/2)*n
//(1 + 10) / 2.0 = 5.5



// 67
// Это число больше чем (1 + 100) / 2 = 50? да
// Это число больше чем (50 + 100) / 2 = 75? нет
// Это число больше чем (50 + 75) / 2 = 62? да
// Это число больше чем (62 + 75) / 2 = 68? нет
// Это число больше чем (62 + 68) / 2 = 65? да
// Это число больше чем (65 + 68) / 2 = 66? да
// Это число больше чем (66 + 68) / 2 = 67? нет
// (66, 67)
// 100 вариантов (n) - log2(100) = 7 (2 в 7 степени = 128)


// Console.Clear();
// Console.Write("Введите количество элементов: ");
// int n = int.Parse(Console.ReadLine()!);
// int[] array = new int[n];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(-20, 21); // [-20; 20]
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// for (int i = 0; i < array.Length; i++)
// {
//     for (int j = 0; j < array.Length - 1 - i; j++)
//     {
//         if (array[j] > array[j + 1])
//             (array[j], array[j + 1]) = (array[j + 1], array[j]);
//     }
// }
// Console.WriteLine($"Конечный массив: [{string.Join(", ", array)}]");
// [ ]


// Последовательность Фиббоначи



// int Fib(int n)
// {
//     if (n == 0)
//         return 0;
//     if (n == 1)
//         return 1;
//     return Fib(n - 1) + Fib(n - 2);
// }


// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!), a0 = 0, a1 = 1, x;

// for (int i = 0; i < n; i++)
// {
//     x = a0 + a1;
//     a0 = a1;
//     a1 = x;
// }
// Console.WriteLine($"I - {a0}"); // O(39)
// Console.WriteLine($"II(рекурсия) - {Fib(n)}"); // O(2 ^ 39)
// 0 1 1 2 3 5 8
// 0 1 2 3 4 5 6 7

// [5, 4, 0, 2, 1]
// Опорный элемент - 5
// Первый массив < 5 [4, 0, 2, 1]
// Второй массив = 5 [5]
// Третий массив > 5 []

// [4, 0, 2, 1]
// Опорный элемент - 4
// Первый массив < 4 [0, 2, 1]
// Второй массив = 4 [4]
// Третий массив > 4 []

// [0, 2, 1]
// Опорный элемент - 0
// Первый массив < 0 []
// Второй массив = 0 [0]
// Третий массив > 0 [2, 1]

// Big O Notation

// int n = 5;
// int[] array = new int[n];
// for (int i = 0; i < n; i++)
//     array[i] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("[" + String.Join(", ", array) + "]");
// int summ = 0;
// for (int i = 0; i < n; i++)
//     summ += array[i];
// Console.WriteLine(summ);
// O(n^2)

// int n = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[n, n];
// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//             matrix[i, j] = (i+1) * (j+1);
//             matrix[j, i] = (i+1) * (j+1);
//     }
// }

// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//             Console.Write(matrix[i,j]);
//             Console.Write(" ");
//     }
//     Console.WriteLine();
// }

//int n = Random.Shared.Next(1000000000);

// double s = 0;



// for (int n = 0; n < 90; n++)
// {
//     int i = n;
//     int count = 0;
//     while (i > 0)
//     {
//         count++;
//         s += i;
//         i = i / 2;
//     }
//     Console.WriteLine($"n:{n}, count:{count}");
// }

// 14 / 5 = 2.8 Деление
// 14 div 5 = 2 Не полное частное
// 14 mod 5 = 4 Остаток от деления

/*
Cортировка пузырьком
Начальный массив: [3, 1, 5, 0, 7, 9, 8]
*/
// Console.WriteLine("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// for (int i = 0; i < n; i++)
// {
//  Console.Write("Введите значения массива: ");
//  array[i] = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
// Console.WriteLine();
// for (int i = 0; i < n; i++)
// {
//  for (int j = 0; j < n - 1; j++)
//  {
//  if (array[j] > array[j + 1])
//  {
//  int temp = array[j];
//  array[j] = array[j + 1];
//  array[j + 1] = temp;
//  }
//  }
//  Console.WriteLine(i + "[" + string.Join(", ", array) + "]");
// }

// Быстрая сортировка

// namespace ListOfSorting 
// { 
//     public class ListOfSorting 
//     { 
//         static void Swap(ref int leftValue, ref int rightValue) 
//         { 
//             int temp = leftValue; 
//             leftValue=rightValue; 
//             rightValue = temp; 
//         } 
 
//         public static void QuickSort(int[] inputArray, int minIndex, int maxIndex) 
//         { 
//             static int GetPivotIndex(int[] inputArray, int minIndex, int maxIndex) 
//             { 
//                 int pivotIndex = minIndex-1; 
//                 for (int i = minIndex; i <= maxIndex ; i++) 
//                 { 
//                     if (inputArray[i]<inputArray[maxIndex]) 
//                     { 
//                         pivotIndex++; 
//                         Swap(ref inputArray[i], ref inputArray[pivotIndex]); 
//                     } 
//                 } 
//                 pivotIndex++; 
//                 Swap(ref inputArray[pivotIndex], ref inputArray[maxIndex]); 
//                 return pivotIndex; 
//             } 
//             if (minIndex>=maxIndex) return; 
//             int pivot= GetPivotIndex(inputArray, minIndex, maxIndex); 
//             QuickSort(inputArray,  minIndex, pivot-1); 
//             QuickSort(inputArray,  pivot+1, maxIndex); 
//             return; 
//         } 
//     } 
// }


// // Параллельное умножение матриц

// const int N = 1000; //размер матрицы
// const int THREADS_NUMBER = 10;

// int[,] serialMulRes = new int[N, N]; //результат выполнения умножения матриц в однопотоке
// int[,] threadMulRes = new int[N, N]; //результат параллельного умножения матриц

// int[,] firstMatrix = MatrixGenerator(N, N);
// int[,] secondMatrix = MatrixGenerator(N, N);

// SerialMatrixMul(firstMatrix, secondMatrix);
// PrepareParallelMatrixMul(firstMatrix, secondMatrix);
// Console.WriteLine(EqualityMatrix(serialMulRes, threadMulRes));



// int[,] MatrixGenerator(int rows, int columns)
// {
//     Random _rand = new Random();
//     int[,] res = new int[rows, columns];
//     for (int i = 0; i < res.GetLength(0); i++)
//     {
//         for (int j = 0; j < res.GetLength(1); j++)
//         {
//             res[i, j] = _rand.Next(-100, 100);
//         }
//     }
//     return res;
// }

// void SerialMatrixMul(int[,] a, int[,] b)
// {
//     if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Нельзя умножить такие матрицы");

//     for (int i = 0; i < a.GetLength(0); i++)
//     {
//         for (int j = 0; j < b.GetLength(1); j++)
//         {
//             for (int k = 0; k < b.GetLength(0); k++)
//             {
//                 serialMulRes[i, j] += a[i, k] * b[k, j];
//             }
//         }
//     }
// }

// void PrepareParallelMatrixMul(int[,] a, int[,] b)
// {
//     if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Нельзя умножить такие матрицы");
//     int eachThreadCalc = N / THREADS_NUMBER;
//     Thread[] arr = new Thread[2];
//     var threadsList = new List<Thread>();
//     for (int i = 0; i < THREADS_NUMBER; i++)
//     {
//         int startPos = i * eachThreadCalc;
//         int endPos = (i + 1) * eachThreadCalc;
//         //если последний поток
//         if (i == THREADS_NUMBER - 1) endPos = N;
//         threadsList.Add(new Thread(() => ParallelMatrixMul(a, b, startPos, endPos)));
//         threadsList[i].Start();
//     }
//     for (int i = 0; i < THREADS_NUMBER; i++)
//     {
//         threadsList[i].Join();
//     }
// }

// void ParallelMatrixMul(int[,] a, int[,] b, int startPos, int endPos)
// {
//     for (int i = startPos; i < endPos; i++)
//     {
//         for (int j = 0; j < b.GetLength(1); j++)
//         {
//             for (int k = 0; k < b.GetLength(0); k++)
//             {
//                 threadMulRes[i, j] += a[i, k] * b[k, j];
//             }
//         }
//     }
// }

// bool EqualityMatrix(int[,] fmatrix, int[,] smatrix)
// {
//     bool res = true;

//     for (int i = 0; i < fmatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < fmatrix.GetLength(1); j++)
//         {
//             res = res && (fmatrix[i, j] == smatrix[i, j]);
//         }
//     }

//     return res;
// }


//сортировка подсчетом

int[] array = {-10, -5, -9, 0, 2, 5, 1, 3, 1, 0, 1};
int[] sortedArray = CountingSortExtended(array);

//CountingSort(array);

Console.WriteLine(string.Join(", ", sortedArray));

void CountingSort(int[] inputArray)
{
    int[] counters = new int[10]; //массив повторений

    for (int i = 0; i < inputArray.Length; i++)
    {
        counters[inputArray[i]]++;
        // ourNumber = inputArray[i];
        // counters[ourNumber]++;
    }

    int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            inputArray[index] = i;
            index++;
        }
    }
}


int[] CountingSortExtended(int[] inputArray)
{
    int max = inputArray.Max();
    int min = inputArray.Min();

    int offset = -min;
    int[] sortedArray = new int[inputArray.Length];
    int[] counters = new int[max + offset + 1];



    for (int i = 0; i < inputArray.Length; i++)
    {
        counters[inputArray[i] + offset]++;
    }

    int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            sortedArray[index] = i - offset;
            index++;
        }
    }

    return sortedArray;
}
