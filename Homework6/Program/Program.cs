// See https://aka.ms/new-console-template for more information
using System.Numerics;

ShowCharacter("New York", 2);
CalculateRetail();

for (int i = 80; i < 101; i++) {
    Console.WriteLine($"F: {i} | C: {Celsius(i)}");
}

for (int i = -10; i < 10; i++)
{
    Console.WriteLine($"{i} {(IsPrime(i) ? "is prime" : "not prime")}");
}

Console.Write($"Enter a number:");
Console.WriteLine(IsPrime(int.Parse(Console.ReadLine())) ? "Is prime" : "Is not prime");

char ShowCharacter(String text,int index)
{
    Console.WriteLine(text[index - 1]);
    return text[index - 1];
}

(double, double, double) CalculateRetail() {
    Console.WriteLine("Initial price: ");
    double initial = Double.Parse(Console.ReadLine());
    Console.WriteLine("Markup percent: ");
    double markup = Double.Parse(Console.ReadLine());
    double final = initial * (markup * .01) + initial;
    Console.WriteLine($"Final: {final}");
    Console.WriteLine($"Wholesale: {initial}, Markup: {markup}, Final: {final}");
    return (initial, markup, final);
}

double Celsius(Double temp)
{
    return Math.Round((double)5 / 9 * (temp - 32), 2);
}

bool IsPrime(int num)
{
    num = Math.Abs(num);
    if (num == 0) return false;
    if (num == 1 || num == 2 || num == 3) return true;
    for (int i = 2; i <= Math.Sqrt(num); i++) {
        if (num % i == 0) return false;
    }
    return true;
}
