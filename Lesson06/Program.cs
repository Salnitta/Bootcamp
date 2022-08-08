/*
1. (1, 0, -6, 2, 5, 3, 2)
2. arr[6] = pivot (опорный элемент), слева перенести числа меньше pivot, справа больше pivot
3. Вызвать шаги 1-2 для подмассива слева от pivot и справа от pivot
*/
// int[] arr = {0, -5, 2, 9, 5, 3, -1, 7};
// QuickSort(arr, 0, arr.Length - 1);
// Console.Write("Отсортированный массив: [" + string.Join(", ", arr) + "]");

// int[] QuickSort(int[] inputArray, int minIndex, int maxIndex)
// {
//     if (minIndex >= maxIndex) return inputArray;
//     int pivot = GetPivotIndex(inputArray, minIndex, maxIndex);
//     QuickSort(inputArray, minIndex, pivot - 1);
//     QuickSort(inputArray, pivot + 1, maxIndex);
//     return inputArray;
// }

// int GetPivotIndex(int[] inputArray, int minIndex, int maxIndex)
// {
//     int pivotIndex = minIndex - 1;
//     for(int i = minIndex; i < maxIndex; i++)
//     {
//         if (inputArray[i] < inputArray[maxIndex])
//         {
//             pivotIndex++;
//             Swap(inputArray, i, pivotIndex); // нужен ли свап?
//         }
//     }
//     pivotIndex++;
//     Swap(inputArray, pivotIndex, maxIndex);
//     return pivotIndex;
// }

// void Swap (int[] inputArray, int leftValue, int rightValue)
// {
//     int temp = inputArray[leftValue];
//     inputArray[leftValue] = inputArray[rightValue];
//     inputArray[rightValue] = temp;
// }


// Вариант оформления с классами:

// using System;

// namespace ConsoleApp3
// {
//     internal class Program
//     {
//         //0, 2, -5, 5, 3, 7, 9, -1
//         //0, 2, -5, 5, 3, 7, 9, -1
//         static void Main(string[] args)
//         {
//             int[] arr = { 0, -5, 2, 3, 5, 9, -1, 7 };
//             QuickSort(arr, 0, arr.Length - 1);
//             Console.Write($"Отсортированный массив {string.Join(", ", arr)}");

//             void QuickSort(int[] inputArray, int minIndex, int maxIndex)
//             {
//                 if(minIndex >= maxIndex) return;
//                 int pivot = GetPivotIndex(inputArray, minIndex, maxIndex);
//                 QuickSort(inputArray, minIndex, pivot - 1);
//                 QuickSort(inputArray, pivot + 1, maxIndex);
//                 return;
//             }
//             int GetPivotIndex(int[] inputArray, int minIndex, int maxIndex)
//             {
//                 int pivotIndex = minIndex - 1;
//                 for (int i = minIndex; i <= maxIndex; i++)
//                 {
//                     if (inputArray[i] < inputArray[maxIndex])
//                     {
//                         pivotIndex++;
//                         Swap(inputArray, i, pivotIndex);
//                     }
//                 }
//                 pivotIndex++;
//                 Swap(inputArray, pivotIndex, maxIndex);
//                 return pivotIndex;
//             }
//             void Swap(int[] inputArray, int leftValue, int rightValue)
//             {
//                 int temp = inputArray[leftValue];
//                 inputArray[leftValue] = inputArray[rightValue];
//                 inputArray[rightValue] = temp;
//             }
//         }
//     }
// }

// ДЗ: вариант с опорным элементом в начале массива
// arr[0] = pivot

int[] arr = {0, -5, 2, 9, 5, 3, -1, 7};
QuickSort(arr, 0, arr.Length - 1);
Console.Write("Отсортированный массив: [" + string.Join(", ", arr) + "]");

int[] QuickSort(int[] inputArray, int minIndex, int maxIndex)
{
    if (minIndex >= maxIndex) return inputArray;
    int pivot = GetPivotIndex(inputArray, minIndex, maxIndex);
    QuickSort(inputArray, minIndex, pivot - 1);
    QuickSort(inputArray, pivot + 1, maxIndex);
    return inputArray;
}

int GetPivotIndex(int[] inputArray, int minIndex, int maxIndex)
{
    int pivotIndex = maxIndex + 1;
    for(int i = maxIndex; i > minIndex; i--)
    {
        if (inputArray[i] > inputArray[minIndex])
        {
            pivotIndex--;
            Swap(inputArray, i, pivotIndex); 
        }
    }
    pivotIndex--;
    Swap(inputArray, pivotIndex, minIndex);
    return pivotIndex;
}

void Swap (int[] inputArray, int leftValue, int rightValue)
{
    int temp = inputArray[leftValue];
    inputArray[leftValue] = inputArray[rightValue];
    inputArray[rightValue] = temp;
}