﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] RandomArray(int len)  //Метод создания рандомного массива заданной длины
{
    Console.Write("[");
    int[] array = new int[len];
    for (int i = 0; i < len; i++)   //Цикл обхода индексов массива до его длины
    {
        array[i] = new Random().Next(100, 1000);    //Функция создания трехзначных чисел в елементах массива
        Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
    return array;
}
void ShowMeNumber(int[] a)  //Метод проверки элементов массива на четность с помощью обхода
{
    int count = 0;  //Счетчик
    foreach (int el in a)   //Цикл обхода всех элементов массива
    {
        if (el %2==0)   //Определяем является ли элемент четным
        {
            count += 1;     //Фиксируем счетчиком все четные элементы
        }
    }
    Console.WriteLine($" -> {count}");  //Выводим значение счетчика на консоль
}
int[] arr1 = RandomArray(4);
ShowMeNumber(arr1);