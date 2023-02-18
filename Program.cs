//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

/* Простой способ решения
int [] CreateNewArray(int size, int minVal, int maxVal)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array [i] = new Random().Next(minVal, maxVal + 1);
    }
    return array;
}
*/
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int PositiveNumbers(int[] array)
{
    int positive_num = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            positive_num++;
    }
    return positive_num;
}
/*
Console.Write("Eter the number of numbers you need: ");
int user_size = Convert.ToInt32(Console.ReadLine());

if(user_size > 0)
{
    Console.Write("Input minimal number: ");
    int user_min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input maximal number: ");
    int user_max = Convert.ToInt32(Console.ReadLine());
    int [] massive = CreateNewArray(user_size, user_min, user_max);
    ShowArray(massive);
    int positive_numbers = PositiveNumbers(massive);
    Console.Write($"The number of numbers greater than zero is {positive_numbers}");
}
else
    Console.Write("The number of numders must be greater than 0!");

*/

int[] CreateNewArray(int size)
{
    int[] array = new int[size];
    do
    {
        for (int i = 0; i < array.Length
            && int.TryParse(Console.ReadLine(), out array[i]); i++) ;
    } while (Console.ReadLine() != "q");
    return array;
}

Console.WriteLine("Input numbers. If you want to stop input numbers press q");
int[] massiv = CreateNewArray(1000);// расчет на то, что пользователь не будет сам вводить 1000 элементов

ShowArray(massiv);

int positive_numbers = PositiveNumbers(massiv);
Console.Write($"The number of numbers greater than zero is {positive_numbers}");


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*
void IntersectionPoint(int K1, int B1, int K2, int B2)
{
    int x = 0;
    int y = 0;
    if(K1 == K2 && B1 == B2)
        Console.Write("The lines coincide and have an infinite number of intersection points");
    if(K1 == K2 && B1 != B2)
        Console.Write("The lines are parallel and have no intersection points");
    if(K1 != K2 && B1 != B2)
    {
        x = (B2 - B1) / (K1 - K2);
        y = K1 * x + B1;
        Console.Write($"The point of intersection of the lines has coordinates: x = {x}, y = {y}");
    }
}

Console.WriteLine("Eter the values of k1, b1, k2, b2: ");
int k1 = Convert.ToInt32(Console.ReadLine());
int b1 = Convert.ToInt32(Console.ReadLine());
int k2 = Convert.ToInt32(Console.ReadLine());
int b2 = Convert.ToInt32(Console.ReadLine());
IntersectionPoint(k1, b1, k2, b2);
*/