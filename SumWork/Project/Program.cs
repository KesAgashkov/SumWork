﻿string [] CreateFirstArray ()
{
    System.Console.WriteLine("Введите количество элементов в массиве");
    int size = int.Parse (Console.ReadLine());
    string [] firstArray =  new string [size];
    for (int i = 0; i < size; i++)
    {
        System.Console.WriteLine($"Введите {i+1} элемент массива и нажмите Enter");
        firstArray[i] =(Console.ReadLine());
    }
    return firstArray;
}
string [] firstArr = CreateFirstArray();

void ShowFirstArr ()
{
    System.Console.WriteLine("Введенный массив");
    System.Console.WriteLine();
  for (int i = 0; i < firstArr.Length; i++)
    {
        System.Console.Write($"[ {firstArr[i]} ]");
    }
    System.Console.WriteLine();
    System.Console.WriteLine();
}

