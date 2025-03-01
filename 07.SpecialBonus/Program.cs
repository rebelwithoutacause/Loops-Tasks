int stopNumber = int.Parse(Console.ReadLine());
int previousNumber = 0;
while (true) 
{
int currentNumber = int.Parse(Console.ReadLine());
    if (currentNumber == stopNumber) 
    {
        Console.WriteLine(previousNumber * 1.2);
    break;
    }
    previousNumber = currentNumber;
}