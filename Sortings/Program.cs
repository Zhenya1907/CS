// Вывод отсортированных массивов
int [] arr_1 = RandomArrayGeneration();
Console.WriteLine($"Unsorted array 1: {String.Join(' ', arr_1)}");

BubbleSort(arr_1);
Console.WriteLine($"BubbleSort......: {String.Join(' ', arr_1)}\n");


int[] arr_2 = RandomArrayGeneration();
Console.WriteLine($"Unsorted array 2: {String.Join(' ', arr_2)}");

SelectionSort(arr_2);
Console.WriteLine($"SelectionSort...: {String.Join(' ', arr_2)}\n");


int[] arr_3 = RandomArrayGeneration();
Console.WriteLine($"Unsorted array 3: {String.Join(' ', arr_3)}");

InsertionSort(arr_3);
Console.WriteLine($"InsertionSort...: {String.Join(' ', arr_3)}\n"); 



// Метод, генерирующий неупорядоченный массив целых чисел 
int[] RandomArrayGeneration()
{
    int[] array = new int[20];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(1, 100);
        }
    return array;
}



// Сортировка пузырьком 
int[] BubbleSort(int[] array)
{
    int count = 1;
    int spam;
    while (count < array.Length)
    { 
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                spam = array[i + 1];
                array[i + 1] = array[i];
                array[i] = spam;
            }
        }
        count++;
    }
    return array;
}


// Сортировка выбором
int[] SelectionSort(int[] array)
{
    int finger;
    int spam;
    for (int i = 0; i < array.Length; i++)
    {
        finger = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[finger])
            {
                finger = j;
            }
        }
        spam = array[i];
        array[i] = array[finger];
        array[finger] = spam;
    }
    return array;
}


// Сортировка вставками 
int[] InsertionSort(int[] array)
{
    int arm;
    int j;
    for (int i = 1; i < array.Length; i++)
    {
        arm = array[i];
        j = i;
        while ((j > 0) && (array[j - 1] > arm))
        {   
            array[j] = array[j - 1];
            j--;
        }
        array[j] = arm;
    }
    return array;
}




