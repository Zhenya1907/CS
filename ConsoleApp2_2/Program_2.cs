int left = 1;
int right = 100;

while (true)
{
    int carrent = (left + right) / 2;
    Console.WriteLine($"Is your number {carrent}? (yes, bigger, smaller)");
    var is_correct = Console.ReadLine();


    if (is_correct == "yes")
    {
        Console.WriteLine("Olala!!!");
        break;
    }
    else if (is_correct == "bigger")
    {
        left = carrent + 1;
    }
    else if (is_correct == "smaller")
    {
        right = carrent - 1;
    }
    else
    {
        Console.WriteLine("Don't understand you");
    }

}