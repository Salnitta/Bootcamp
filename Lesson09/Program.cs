// Сортировка подсчетом цифр

// int[] array = { 0, 2, 3, 2, 1 };

// CountingSort(array);

// Console.Write(string.Join(", ", array));

// void CountingSort(int[] inputArray)
// {
//     int[] counters = new int[10];

//     for (int i = 0; i < inputArray.Length; i++)
//     {
//         // counetrs[inputArray[i]]++;
//         int ourNumber = inputArray[i];
//         counters[ourNumber]++;
//     }

//     int index = 0;
//     for (int i = 0; i < counters.Length; i++)
//     {
//         for (int j = 0; j < counters[i]; j++)
//         {
//             inputArray[index] = i;
//             index++;
//         }
//     }
// }

// Сортировка подсчетом чисел

// int[] array = { 0, 2, 5, 1, 3, 1, 0, 1 };
// int[] sortArray = CountingSortExtended(array);
// Console.Write(string.Join(", ", sortArray));


// int[] CountingSortExtended(int[] inputArray)
// {
//     int max = inputArray.Max();
//     int[] sortedArray = new int[inputArray.Length];
    
//     int[] counters = new int[max + 1];

//     for (int i = 0; i < inputArray.Length; i++)
//     {
//         counters[inputArray[i]]++;
//     }

//     int index = 0;
//     for (int i = 0; i < counters.Length; i++)
//     {
//         for (int j = 0; j < counters[i]; j++)
//         {
//             sortedArray[index] = i;
//             index++;
//         }
//     }
//     return sortedArray;
// }


// Сортировка подсчетом массива с отрицательными числами

int[] array = { 10, -10, 5, 8, 12};
int[] sortArray = CountingSortExtended(array);
Console.Write(string.Join(", ", sortArray));


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