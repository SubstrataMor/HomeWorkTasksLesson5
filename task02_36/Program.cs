// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int Input()
{
    int num = Convert.ToInt32(Console.ReadLine());  //Метод запроса на ввод числа пользователем
    return num;
}
int[] NewArray(int size)
{
    Console.Write("[");
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-100, 100);    //Метод создания массива из рандомных чисел, где длина массива это число введенное пользователем
        Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
    return array;
}
void FindCount(int[] a)     //Метод перебора элементов массива
{
    int i = 0;
    int countSum = 0;
    foreach (var item in a)     //Цикл обхода массива от его первого элемента до последнего
    {
        if (i %2 !=0)   //Находит нечетный индекс массива
        {
            countSum = countSum + item;     //складывает элементы, которые находятся в нечетных элементах массива
        }
        i++;
    }
    Console.WriteLine($" -> {countSum}");
}
Console.WriteLine("Введите размер массива:");
int numSize = Input();
int[] arr1 = NewArray(numSize);
FindCount(arr1);