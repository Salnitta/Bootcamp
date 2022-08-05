/* СОРТИРОВКА ВЫБОРОМ
[6, 15, 2, 9, -3]
MIN = 6
6 < 15
6 > 2
MIN = 2
2 < 9
2 > -3
MIN = -3
[-3, 6, 15, 2, 9]
[6, 15, 2, 9]
MIN = 6
6 < 15
6 > 2
MIN = 2
2 < 9
[-3, 2, 6, 15, 9]
MIN = 6
6 < 15
6 < 9
[-3, 2, 6, 15, 9]
MIN = 15
15 > 9
[-3, 2, 6, 9, 15]
*/

// Сортировка выбором чисел
// Console.WriteLine("Введите кол-во элементов массива:");
// int n = Convert.ToInt32(Console.ReadLine());
// // Заполнение массива
// int[] array = new int[n];
// for (int i = 0; i < n; i++)
// {
//     Console.Write("Введите число: ");
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine();
// Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
// // Cортировка
// for (int i = 0; i < n - 1; i++)
// {
//     int MinIndex = i;
//     for (int j = i + 1; j < n; j++)
//     {
//         if (array[j] < array[MinIndex])
//             MinIndex = j; 
//     }
//     int temp;
//     temp = array[MinIndex];
//     array[MinIndex] = array[i];
//     array[i] = temp;
// }
// Console.WriteLine("Конечный массив: [" + string.Join(", ", array) + "]");


// Сортировка выбором строк
// string[] array = new string[5];
// for (int i = 0; i < 5; i++)
// {
//     array[i] = Console.ReadLine();
// }
// Console.Write("Начальный массив: [" + string.Join(", ", array) + "]");
// Console.WriteLine();
// for (int i = 0; i < 4; i++)
// {
//     int MinIndex = i;
//     for (int j = i + 1; j < 5; j++)
//     {
//         if (array[j].Length < array[MinIndex].Length)
//             MinIndex = j; 
//     }
//     string temp;
//     temp = array[MinIndex];
//     array[MinIndex] = array[i];
//     array[i] = temp;
// }
// Console.WriteLine("Конечный массив: [" + string.Join(", ", array) + "]");

// ДЗ "Сдвиг вправо"
// Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность 
// (сдвиг - циклический) на |K| элементов вправо, если K – положительное и влево, если отрицательное.
// Пример 1:
// INPUT: 5 3 7 4 6, 3
// OUTPUT: 7 4 6 5 3
// Пример 2:
// INPUT: 5 3 7 4 6, -3
// OUTPUT: 4 6 5 3 7

int[] input = { 5, 3, 7, 4, 6 };
int n = 5;
Console.WriteLine("Введите k: ");
int k = int.Parse(Console.ReadLine());
while (Math.Abs(k) > n)
{
    k = k % n;
}
Console.WriteLine(k);
Console.WriteLine("INPUT: [" + string.Join(", ", input) + "]");
int[] output = new int[n];
for (int i = 0; i < n; i++)
{
    if (k >= 0)
    {
        if (i + k < n) 
            output[i + k] = input[i];
        else output[i + k - n] = input[i];
    }
    else
    {
        if (i + k >= 0) 
            output[i + k] = input[i];
        else output[i + k + n] = input[i];
    }
}

Console.WriteLine("OUTPUT: [" + string.Join(", ", output) + "]");