string [] CreateFirstArray ()
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

ShowFirstArr ();

string [] SortFirstArr (int sort = 3)
{
    int count = 0;
    int i = 0;
    string [] newArray =  new string [firstArr.Length];

    while (i < firstArr.Length)
    {
        if (firstArr[i].Length <= sort)
        {
        newArray[i] = firstArr[i];
        }
        else
        {
            count++;
        }
        i++;
    } 
    return newArray;
}
string [] newArr = SortFirstArr ();

void ShowNewArr ()
{
    string []test = newArr.Where(x => !string.IsNullOrEmpty(x)).ToArray();
    System.Console.WriteLine("Отсортированный массив");
    System.Console.WriteLine();
    for (int i = 0; i < test.Length; i++)
    {
        System.Console.Write($"[ {test[i]} ]");
    }
}
ShowNewArr ();