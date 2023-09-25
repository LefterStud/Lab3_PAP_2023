namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task925();
            Task932();
            Task951();
            Task988();
        }

        /// <summary>
        /// Удалить столбец Двумерного массива вещественных чисел, в котором находится максимальный элемент этого массива.
        /// </summary>
        /// <remarks>
        /// Числа в масиві генеруються випадковим чином за допомогою функції ArrayGenerator.
        /// </remarks>
        static void Task925()
        {
            Console.WriteLine(
                "Task 925: Удалить столбец Двумерного массива вещественных чисел, в котором находится максимальный элемент этого массива.\n");
            const int LENGTH_OF_ROW = 6;
            const int LENGTH_OF_COL = 6;
            const int MIN_NUMBER = -20;
            const int MAX_NUMBER = 100;
            double[,] realNumbers = ArrayGenerator(LENGTH_OF_ROW, LENGTH_OF_COL, MIN_NUMBER, MAX_NUMBER);
            double[,] resultArray = new double[LENGTH_OF_ROW, LENGTH_OF_COL - 1];
            PrintArray(realNumbers, LENGTH_OF_ROW, LENGTH_OF_COL, "Array of numbers:");
            int maxIndexColumn = 0;
            double maxElement = 0;
            for (int i = 0; i < realNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < realNumbers.GetLength(1); j++)
                {
                    if (realNumbers[i, j] > maxElement)
                    {
                        maxElement = realNumbers[i, j];
                        maxIndexColumn = j;

                    }

                }
            }
            Console.WriteLine($"Max element is {maxElement}");
            Console.WriteLine($"Index of max element is {maxIndexColumn + 1}");
            for (int i = 0; i < LENGTH_OF_ROW; i++)
            {
                int tempCol = 0;
                for (int j = 0; j < LENGTH_OF_COL; j++)
                {
                    if (j != maxIndexColumn)
                    {
                        resultArray[i, tempCol] = realNumbers[i, j];
                        tempCol++;
                    }
                }
            }
            PrintArray(resultArray, resultArray.GetLength(0), resultArray.GetLength(1), "Updated array of numbers:");
        }

        /// <summary>
        /// Отсортировать четные строки массива по возрастанию, а нечетные по убыванию.
        /// </summary>
        /// <remarks>
        /// Числа в масиві генеруються випадковим чином за допомогою функції ArrayGenerator.
        /// </remarks>
        static void Task932()
        {
            Console.WriteLine(
                "Task 932: Отсортировать четные строки массива по возрастанию, а нечетные по убыванию.\n");
            const int LENGTH_OF_ROW = 6;
            const int LENGTH_OF_COL = 6;
            const int MIN_NUMBER = -20;
            const int MAX_NUMBER = 100;
            double[,] realNumbers = ArrayGenerator(LENGTH_OF_ROW, LENGTH_OF_COL, MIN_NUMBER, MAX_NUMBER);
            PrintArray(realNumbers, LENGTH_OF_ROW, LENGTH_OF_COL, "Array of numbers:");
            for (int i = 0; i < LENGTH_OF_ROW; i++)
            {
                double[] tempArray = new double[LENGTH_OF_COL];
                for (int j = 0; j < LENGTH_OF_COL; j++)
                {
                    tempArray[j] = realNumbers[i, j];
                }
                Array.Sort(tempArray);
                if ((i + 1) % 2 != 0)
                {
                    Array.Reverse(tempArray);
                }
                for (int k = 0; k < LENGTH_OF_COL; k++)
                {
                    realNumbers[i, k] = tempArray[k];
                }
            }
            PrintArray(realNumbers, LENGTH_OF_ROW, LENGTH_OF_COL, "Updated array of numbers:");
        }

        /// <summary>
        /// Дан Двумерный массив.
        /// а) Заменить значения всех элементов второй строки массива числом 5.
        /// б) Заменить значения всех элементов пятого столбца массива числом 10.
        /// </summary>
        /// <remarks>
        /// Числа в масиві генеруються випадковим чином за допомогою функції ArrayGenerator.
        /// </remarks>
        static void Task951()
        {
            Console.WriteLine(
                "Task 951: Дан Двумерный массив." +
                "\nа) Заменить значения всех элементов второй строки массива числом 5." +
                "\nб) Заменить значения всех элементов пятого столбца массива числом 10.\n\n");
            const int LENGTH_OF_ROW = 6;
            const int LENGTH_OF_COL = 6;
            const int MIN_NUMBER = -20;
            const int MAX_NUMBER = 100;
            double[,] realNumbers = ArrayGenerator(LENGTH_OF_ROW, LENGTH_OF_COL, MIN_NUMBER, MAX_NUMBER);
            PrintArray(realNumbers, LENGTH_OF_ROW, LENGTH_OF_COL, "Array of numbers:");
            //2 рядок масива в даному випадку розуміється при нумерації що починається з 1
            for (int i = 0; i < LENGTH_OF_ROW; i++)
            {
                realNumbers[1, i] = 5;
            }
            //5 стовпчик масива в даному випадку розуміється при нумерації що починається з 1
            for (int i = 0; i < LENGTH_OF_COL; i++)
            {
                realNumbers[i, 4] = 10;
            }
            PrintArray(realNumbers, LENGTH_OF_ROW, LENGTH_OF_COL, "Updated array of numbers:");
        }

        /// <summary>
        /// Дан Двумерный массив.
        /// а) Заменить значения всех элементов второй строки массива числом 5.
        /// б) Заменить значения всех элементов пятого столбца массива числом 10.
        /// </summary>
        /// <remarks>
        /// Числа в масиві генеруються випадковим чином за допомогою функції ArrayGenerator.
        /// </remarks>
        static void Task988()
        {
            Console.WriteLine(
                "Task 988: Найти координаты (индекс) элемента, наиболее близкого к среднему значению всех элементов массива.\n");
            const int LENGTH_OF_ROW = 6;
            const int LENGTH_OF_COL = 6;
            const int MIN_NUMBER = -20;
            const int MAX_NUMBER = 100;
            double[,] realNumbers = ArrayGenerator(LENGTH_OF_ROW, LENGTH_OF_COL, MIN_NUMBER, MAX_NUMBER);
            double average = 0;
            double sum = 0;
            PrintArray(realNumbers, LENGTH_OF_ROW, LENGTH_OF_COL, "Array of numbers:");
            for (int i = 0; i < LENGTH_OF_ROW; i++)
            {
                for (int j = 0; j < LENGTH_OF_COL; j++)
                {
                    sum += realNumbers[i, j];
                }
            }
            average = sum / (LENGTH_OF_ROW * LENGTH_OF_COL);
            Console.WriteLine($"Average of all elements is {average}");

            //Визначаєтсяь різниця кожного елемента та середнім значенням
            //Далі зберігаєтсья різниця, що є найменшою
            double difference = 0;
            double minDifference = double.MaxValue;
            int[] index = new int[2];
            for (int i = 0; i < LENGTH_OF_ROW; i++)
            {
                for (int j = 0; j < LENGTH_OF_COL; j++)
                {
                    difference = Math.Abs(realNumbers[i, j] - average);
                    if (difference < minDifference)
                    {
                        minDifference = difference;
                        index[0] = i;
                        index[1] = j;
                    }
                }
            }
            Console.WriteLine($"Nearest elements is {realNumbers[index[0], index[1]]}, its coords is ↓{index[0]+1}, →{index[1]+1}");
        }

        static double[,] ArrayGenerator(int row, int col, int min, int max)
        {
            Random r = new Random();
            double[,] resultArray = new double[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    resultArray[i, j] = r.NextDouble() * (max - min) + min;
                }
            }

            return resultArray;
        }

        /// <summary>
        /// Функція для виведення на друк вмісту масиву.
        /// </summary>
        /// <param name="array">Масив, який буде виведено на друк</param>
        static void PrintArray(double[,] array, int row, int col, string title)
        {
            Console.WriteLine($"{title}");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    //Console.Write($"{array[i, j]}. ");

                    Console.Write(string.Format("{0:F3}", array[i, j]) + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("");
        }
    }
}