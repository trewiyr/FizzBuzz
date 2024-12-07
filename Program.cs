void fizzBuzz()
{
    Console.Write("input a number : ");
    int number = int.Parse(Console.ReadLine()!);

    if (number % 2 ==0 && number % 3 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if(number % 2 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if(number % 3 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(number);
    }
}

fizzBuzz();