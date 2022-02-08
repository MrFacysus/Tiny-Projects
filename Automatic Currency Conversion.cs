string Equality = "";
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
