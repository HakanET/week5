Console.WriteLine("enter the current temp");
int currentTemp = Int32.Parse(Console.ReadLine());

if (currentTemp <= 0)
{
    Console.WriteLine("Freezing");
}
else if (currentTemp > 0 && currentTemp < 5)
{
    Console.WriteLine("cold");
}
else if (currentTemp >= 5 && currentTemp < 10)
{
    Console.WriteLine("chilly");
}

else if (currentTemp >= 10 && currentTemp < 15)
{
    Console.WriteLine("cool");
}
else if (currentTemp >= 15 && currentTemp < 28)
{
    Console.WriteLine("warm");
}
else
{
    Console.WriteLine("boiling hot");
}