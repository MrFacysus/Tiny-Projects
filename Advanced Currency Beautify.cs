// just like the old repositiory just more beautiful to see

long X = 0;

X = long.Parse(Console.ReadLine());

if (X < 1000)
{
    Console.WriteLine(X);
}
if (X / 1000 >= 1 && X / 1000000 < 1)
{
    Console.WriteLine($"{Math.Round((double)X / 1000, 2)}k");
}
if (X / 1000000 >= 1 && X / 1000000000 < 1)
{
    Console.WriteLine($"{Math.Round((double)X / 1000000, 2)}M");
}
if (X / 1000000000 >= 1 && X / 1000000000000 < 1)
{
    Console.WriteLine($"{Math.Round((double)X / 1000000000, 2)}B");
}
if (X / 1000000000000 >= 1 && X / 1000000000000000 < 1) 
{
    Console.WriteLine($"{Math.Round((double)X / 1000000000000, 2)}T");
}
