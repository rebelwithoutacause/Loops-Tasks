int number = int.Parse(Console.ReadLine());
bool isSpecial = true;
int copyOfNumber = number;
while (number > 0) 
{
    int lastDigit = number % 10;
    
    if (copyOfNumber % lastDigit != 0) 
    {
        isSpecial = false;
        break;
    }
    number /= 10;
}
string message = $"{copyOfNumber} is special";
if (!isSpecial) 
{
    message = $"{copyOfNumber} is not special";
}
Console.WriteLine(message);
