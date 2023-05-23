// Индивидуальные задания 1. Вариант 4

// 1 задание

//int n = 15;
//double[] arrX = new double[n];
//double[] arrFx = new double[n];

//void InputArr(ref double[] a)
//{
//    Console.WriteLine($"Введите {a.Length} чисел:");
//    for (int i = 0; i < a.Length; i++)
//        a[i] = Convert.ToDouble(Console.ReadLine());
//}

//void FindOutputFx(ref double[] x, ref double[] fx)
//{
//    Console.WriteLine("\nСоответствующие значения f(x):");
//    for (int i = 0; i < x.Length; i++)
//    {
//        if (x[i] <= -1)
//            fx[i] = Math.Pow(Math.Cos(x[i]), 2) * (x[i] * x[i] + 2);
//        else if (x[i] >= 3 * Math.PI)
//            fx[i] = 68.0 / 9;
//        else fx[i] = (Math.Pow(x[i], 3) + 3) * x[i] / ((2 * x[i] - 1 / (x[i] + 2)) * (1 + x[i]));
//        fx[i] = Math.Round(fx[i] * 1000) / 1000;
//        if (fx[i] == -0) fx[i] = 0;
//        Console.WriteLine(fx[i]);
//    }
//}

//bool CheckArea(double x, double fx)
//{
//    if (fx >= 0 & fx <= 10 & x >= -5 & fx <= -x + 10 |
//            fx < 0 & (fx * fx + x * x <= 10 * 10) & fx >= -5)
//        return true;
//    return false;
//}

//int CountInArea(double[] x, double[] fx)
//{
//    int count = 0;
//    for (int i = 0; i < x.Length; i++)
//    {
//        if (CheckArea(x[i], fx[i]))
//            count++;
//    }
//    return count;
//}

//void PrintDistanseNotInArea(double[] x, double[] fx)
//{
//    Console.WriteLine("Координаты точек, не принадлежащих заданной области, и их расстояние до (0, 0):");
//    bool flag = true;
//    for (int i = 0; i < x.Length; i++)
//    {
//        if (!CheckArea(x[i], fx[i])) {
//            flag = false;
//            Console.Write("{0, -12}", $"x = {x[i]}");
//            Console.Write("{0, -17}", $"f(x) = {fx[i]}");
//            Console.WriteLine($"r = {DistanceFrom00(x[i], fx[i])}");
//        }
//    }
//    if (flag) Console.WriteLine("отсутствуют");
//}

//void TheFarthest3Quarter(double[] x, double[] fx)
//{
//    Console.WriteLine("\nТочка, лежащая в III четверти и дальше всех от начала координат:");
//    bool flag = true;
//    double max_dist = 0;
//    for (int i = 0; i < x.Length; i++)
//    {
//        if (fx[i] <= 0 & x[i] <= 0) {
//            flag = false;
//            if (DistanceFrom00(x[i], fx[i]) > max_dist)
//                max_dist = DistanceFrom00(x[i], fx[i]);
//        }
//    }
//    for (int i = 0; i < x.Length; i++)
//    {
//        if (fx[i] <= 0 & x[i] <= 0 & DistanceFrom00(x[i], fx[i]) == max_dist) {
//            Console.Write("{0, -12}", $"x = {x[i]}");
//            Console.Write("{0, -17}", $"f(x) = {fx[i]}");
//            Console.WriteLine($"r = {max_dist}");
//        }
//    }
//    if (flag)
//        Console.WriteLine("отсутствует");
//}

//double DistanceFrom00(double x, double fx) { return Math.Round(Math.Sqrt(fx * fx + x * x) * 100) / 100; }

//InputArr(ref arrX);
//FindOutputFx(ref arrX, ref arrFx);
//Console.WriteLine($"\nЧисло точек с координатами (x, f(x)), принадлежащих " +
//    $"заштрихованной области = {CountInArea(arrX, arrFx)}\n");
//PrintDistanseNotInArea(arrX, arrFx);
//TheFarthest3Quarter(arrX, arrFx);


// 2 задание

//double h1, h2, h3, r1, r2, r3;
//double v1, v2, v3, s1, s2, s3;
//int count = 0;

//void InputCilinder(out double h, out double r)
//{
//    while (true)
//    {
//        Console.Write("Введите высоту цилиндра: ");
//        h = Convert.ToDouble(Console.ReadLine());
//        if (h > 0) break;
//        else Console.WriteLine("Высота должна быть положительной. Повторите ввод.");
//    }
//    while (true)
//    {
//        Console.Write("Введите радиус круга в его основании: ");
//        r = Convert.ToDouble(Console.ReadLine());
//        if (r > 0) break;
//        else Console.WriteLine("Радиус должен быть положительным. Повторите ввод.");
//    }
//    Console.WriteLine();
//}

//void VolumeAndSideSurfaceArea(double h, double r, out double v, out double s)
//{
//    v = Math.Round(Math.PI * r * r * h * 1000) / 1000;
//    s = Math.Round(2 * Math.PI * r * h * 1000) / 1000;
//    Console.WriteLine($"Объем = {v}\nПлощадь = {s}\n");
//}

//InputCilinder(out h1, out r1);
//VolumeAndSideSurfaceArea(h1, r1, out v1, out s1);

//InputCilinder(out h2, out r2);
//VolumeAndSideSurfaceArea(h2, r2, out v2, out s2);

//InputCilinder(out h3, out r3);
//VolumeAndSideSurfaceArea(h3, r3, out v3, out s3);

//Console.WriteLine($"Наименьший из объемов = {Math.Min(Math.Min(v1, v2), v3)}");
//Console.WriteLine($"Сумма всех площадей = {Math.Round(s1 + s2 + s3, 3)}");

//if (v1 < 10) count++;
//if (v2 < 10) count++;
//if (v3 < 10) count++;
//Console.WriteLine($"Количество цилиндров с объемом менее 10 = {count}");


// 3 задание

using System.ComponentModel;

int n;
while (true) {
    Console.Write("Введите размерность квадратной матрицы: ");
    n = Convert.ToInt32(Console.ReadLine());
    if (n > 0) break;
    else Console.WriteLine("Размерность должна быть положительной. Повторите ввод.");
}
int[,] a = new int[n, n];

void ArrayFillingRandom(ref int[,] a)
{
    Random rnd = new Random();
    int n = a.GetUpperBound(0) + 1;
    Console.WriteLine("Полученный массив:");
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            a[i, j] = rnd.Next(-100, 100);
            Console.Write("{0, -7}", $"{a[i, j]}");
        }
        Console.WriteLine();
    }
}

void GeometricalMeanRow(int[,] a)
{
    int n = a.GetLength(0);
    Console.WriteLine("\nСреднее геометрическое в тех строках, которые не содержат отрицательных элементов");
    bool check = true;
    for (int i = 0; i < n; i++) {
        bool flag = true;
        for (int j = 0; j < n; j++) {
            if (a[i, j] < 0)
                flag = false;
        }
        if (flag) {
            double mean = 1;
            check = false;
            for (int j = 0; j < n; j++) {
                mean *= a[i, j];
            }
            Console.WriteLine($"{i+1} строка: {Math.Round(Math.Pow(mean, 1.0 / n), 2)}");
        }
    }
    if (check) Console.WriteLine("такие строки отсутствуют");
}

void MaxSumDiag(int[,] a)
{
    int n = a.GetLength(0);
    int max_sum = 0;
    int y = 0;
    for (int x = 0; x < n; x++) {
        if (y >= n) break;
        max_sum += a[x, y];
        y++;
    }
    for (int i = 1; i < n; i++) {
        y = 0; int sum = 0;
        for (int x = i; x < n; x++) {
            if (y >= n) break;
            sum += a[x, y];
            y++;
        }
        if (sum > max_sum) max_sum = sum;
    }
    for (int j = 1; j < n; j++) {
        int x = 0, sum = 0;
        for (y = j; y < n; y++) {
            if (x >= n) break;
            sum += a[x, y];
            x++;
        }
        if (sum > max_sum) max_sum = sum;
    }
    Console.WriteLine($"Максимум среди сумм элементов диагоналей, параллельных главной = {max_sum}");
}

ArrayFillingRandom(ref a);
GeometricalMeanRow(a);
MaxSumDiag(a);
