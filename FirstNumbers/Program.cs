using System.ComponentModel.Design;

Console.WriteLine("Hello");
Console.WriteLine("Lets check prime numbers ");
Console.WriteLine();

int a = 0;
int b = 0;

while (b <= 100)
{
    int divisors = 0;
    for (int d = 1; d <= b; d++)
    {
    if (b%d == 0)
        {
            divisors++;
        }
    }
    if (divisors == 2)
    {
        a++;
    }
    b++;
}
Console.WriteLine($"you have got {a} Prime Numbers from 0 to 100. Have a nice day");

   





