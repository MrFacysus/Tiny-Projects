string Equality = "";
string input = "";
List<Tuple<string, float>> WhatEquals = new List<Tuple<string, float>>();

Equality = Console.ReadLine();

foreach (string line in Equality.Split(','))
{
    string LeftEquality = line.Split('=')[0];
    string RightEquality = line.Split('=')[1];

    float LeftEqualityCount = float.Parse(LeftEquality.Split(' ')[0]);
    float RightEqualityCount = float.Parse(RightEquality.Split(' ')[0]);

    string LeftEqualityItem = LeftEquality.Split(' ')[1];
    string RightEqualityItem = RightEquality.Split(' ')[1];

    if (WhatEquals.Any(x => x.Item1 == LeftEqualityItem))
    {
        WhatEquals.Add(Tuple.Create(RightEqualityItem, WhatEquals.Where(x => x.Item1 == LeftEqualityItem).ToList()[0].Item2 / RightEqualityCount));
    }
    else
    {
        WhatEquals.Add(Tuple.Create(LeftEqualityItem, LeftEqualityCount));
        WhatEquals.Add(Tuple.Create(RightEqualityItem, LeftEqualityCount / RightEqualityCount));
    }
}

Console.WriteLine();
WhatEquals.ForEach(x => Console.WriteLine($"{x.Item1} = {x.Item2} {WhatEquals.First().Item1}"));
Console.WriteLine("\nWhat would you like to know the worth of?: ");

input = Console.ReadLine();

float LeftInputCount = float.Parse(input.Split(' ')[0]);

string LeftInputItem = input.Split(' ')[1];

if (WhatEquals.Any(x => x.Item1 == LeftInputItem))
{
    foreach (Tuple<string, float> y in WhatEquals)
    {
        Console.WriteLine($"{LeftInputCount} {LeftInputItem} = {(LeftInputCount * WhatEquals.Where(k => k.Item1 == LeftInputItem).ToList()[0].Item2) / y.Item2} {y.Item1}");
    }
}
else
{
    Console.WriteLine("You are not using a defined currency!");
}
