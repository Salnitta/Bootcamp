/* 
Виды алгоритмов:
1. Константные
2. Логарифмические
3. Линейный
4. Линейно-логарифмический (быстрая сортировка, сортировка слиянием)
5. Квадратичный
6. Кубический
*/

// НОД (Алгоритм Евклида) - наибольший общий делитель
// НОД (14, 21) = 7

int n = 140;
int m = 175;
while (n != m)
{
    if (n > m)
        n = n - m;
    else
        m = m - n;

    // Console.WriteLine(n);
    // Console.WriteLine(m);
    // Console.WriteLine();
}
Console.WriteLine($"НОK (140, 175) = {n}");

// НОК - наименьшее общее кратное
// НОК = a * b / (НОД(a, b))

// int n = 140;
// int m = 175;
// int multiple = n * m;
// while (n != m)
// {
//     if (n > m)
//         n = n - m;
//     else
//         m = m - n;
// }
// Console.WriteLine($"НОД (140, 175) = {multiple / n}");
