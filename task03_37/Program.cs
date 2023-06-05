// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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
        array[i] = new Random().Next(0, 10);
        Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
    return array;
}
void FindArray(int[] arr)
{
    Console.Write(" -> [");
    int length = arr.Length;    //Переменная length для основного массива
    int len = length / 2 + 1;   //Задаём длину для будущего массива, мы уже знаем, что он будет в 2 раза меньше, но важно сделать +1, для нечетного массива
    int[] newArr = new int[len];    //Создаём имя для будущего массива
    int j = length - 1;         //Индекс последнего элемента
    int i = 0;                  //Индекс первого элемента
    int el = 0;                 //А это индекс первого элемента будущего массива newArr
    while (i <= length/2)       //Задаём цикл для обхода элементов до его середины
    {
        if (i < length/2)       //Условие которое будет выполняться до середины длины массива
        {
            newArr[el] = arr[i] * arr[j];   //В данном случае умножаем первый элемент на последний и записываем произведение в новый массив
            Console.Write($"{newArr[el]} ");
        }
        else if (i == j)        //При равных значениях начального и последнего индексов будет выполняться следующее условие
        {
            newArr[el] = arr[i];    //Присваиваем срединный элемент новому массиву без изменений
            Console.Write($"{newArr[el]} ");
            break;              //Выходим из цикла
        }
        i++;
        j--;
        el++;
    }
    Console.Write("]");
}
int numSize = Input();
int[] newArray = NewArray(numSize);
FindArray(newArray);