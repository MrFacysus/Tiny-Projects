// Really rounds them up, there is another repositiory with better rounding

long X = 0;

X = long.Parse(Console.ReadLine());

if (X < 1000)
{
    Console.WriteLine(X);
}
if (X / 1000 >= 1 && X / 1000000 < 1)
{
    Console.WriteLine($"{Math.Floor((double)X / 1000)}k");
}
if (X / 1000000 >= 1 && X / 1000000000 < 1)
{
    Console.WriteLine($"{Math.Floor((double)X / 1000000)}M");
}
if (X / 1000000000 >= 1 && X / 1000000000000 < 1)
{
    Console.WriteLine($"{Math.Floor((double)X / 1000000000)}B");
}
if (X / 1000000000000 >= 1 && X / 1000000000000000 < 1) 
{
    Console.WriteLine($"{Math.Floor((double)X / 1000000000000)}T");
}
