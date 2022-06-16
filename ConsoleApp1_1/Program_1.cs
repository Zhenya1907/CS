Random Random = new Random();

int number = Random.Next(1, 101);
int attempt = 0;
int user_answer;

Console.WriteLine("Enter a number from 1 to 100: ");

while (attempt != 10)
{
    Console.WriteLine($"Attempt {attempt + 1}");
    user_answer = Convert.ToInt16(Console.ReadLine());
    attempt++;

    if (user_answer == number)
    {
        Console.WriteLine("\nYou win!");
        break;
    }
    else if (user_answer > number)
    {
        Console.WriteLine("Your number is bigger\n");
    }
    else
    {
        Console.WriteLine("Your number is smaller\n");
    }

}

if (attempt == 10)
{
    Console.WriteLine($"You lose. It was {number}");
}

Console.ReadLine();