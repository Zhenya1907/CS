// Task 1. Palindrome

IsPalindrom();

void IsPalindrom()
{ 
    Console.Write("Enter a word for checking for a palindrome: ");
    string str = Console.ReadLine().ToLower();
    char[] arr = str.ToCharArray();
    Array.Reverse(arr);
    string new_str = new string(arr);

    if (str == new_str)
    {
        Console.WriteLine($"{str} - True");
    }
    else
    {
        Console.WriteLine($"{str} - False");
    }
}



// Tasks 2.

// 2.1.
void Decade()
{
    Console.Write("Enter a day: ");
    var day = Convert.ToInt16(Console.ReadLine());


    if (day > 0 && day <= 10)
    {
        Console.WriteLine("Decade 1");
    }
    else if (day > 10 && day <= 20)
    {
        Console.WriteLine("Decade 2");
    }
    else if (day > 20 && day <= 31)
    {
        Console.WriteLine("Decade 3");
    }
    else
    {
        Console.WriteLine("Wrong number");
    }
    
}

Decade();


// 2.2.
void HowManyDaysToData()
{
    DateTime date = new DateTime(2022, 8, 27);
    var days = date - DateTime.Now;
    Console.WriteLine(days);  
}

HowManyDaysToData();


// 2.5.
void Temperature()
{
    int degree = -8;

    int[] array = new int[31];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-50, 50);
    }


    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }


    int count = 0;
    foreach (int value in array)
    {
        if (value < degree)
        {
            count = count + 1;
        }
    }
    
    Console.WriteLine($"Amount of days  with temperatures below {degree} degrees: {count}");
}

Temperature();


/*
 // 2.6.
void SumOfEvenElements()
{
    Console.Write("Enter numbers separated by spaces: ");
    var numbers = Console.ReadLine();
    String[] numbers_arr = numbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

    List<int> NumbersList = new List<int>();
    foreach (var item in numbers_arr)
    {
        NumbersList.Add(Convert.ToInt16(item));
        Console.WriteLine(Convert.ToInt16(item));
    }
}
*/