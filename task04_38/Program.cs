// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int Input()
{
    int num = Convert.ToInt32(Console.ReadLine());  //Метод запроса на ввод числа пользователем
    return num;
}
double[] NewArray(int size)     //Метод создания вещественных чисел
{
    Console.Write("[");
    double[] array = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.NextDouble()*100;
        Console.Write($"{array[i]:F2}, ");  //:F2 округляет вещественное число до сотых долей
    }
    Console.Write("]");
    return array;
}
void FindDifference(double[] arr)     //Метод перебора элементов массива
{
    int i = 0;
    double numMax = arr[i];      //Присваиваем переменной значение первого элемента (так мы избегаем случаев, когда мин и макс рассходятся с диапазоном элементов)
    double numMin = arr[i];
    foreach (var item in arr)    //Цикл обхода массива от его первого элемента до последнего
    {
        if (item > numMax)   //Находит максимальный элемент массива
        {
            numMax = item;   
        }
        else if (item < numMin)   //Находит минимальный элемент массива
        {
            numMin = item;
        }
    }
    double difference = numMax-numMin;  //Находим разницу между максимальным и минимальными элементами
    Console.WriteLine($" => {(numMax):F2} - {(numMin):F2} = {(difference):F2}");
}
Console.Write("Введите размер массива: ");
int arrSize = Input();
double[] arr1 = NewArray(arrSize);
FindDifference(arr1);