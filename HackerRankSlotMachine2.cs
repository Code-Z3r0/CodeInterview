static int SlotWheels(List<string> history)
{
    var arr = history.First().ToCharArray();
    var cols = new List<int>();

    var castList = history.Select(his => his.ToCharArray().Select(x => int.Parse(x.ToString())).ToList()).ToList();

    for (var i = 0; i < arr.Length; i++)
    {
        var currentMax = 0;
        foreach (var his in castList)
        {
            var max = his.Max();
            if (max >= currentMax)
            {
                currentMax = max;
            }
            his.Remove(max);
        }
        cols.Add(currentMax);
    }
    return cols.Sum();
}

var historyList = new List<string>()
{
    "137",
    "364",
    "115",
    "724"
};
Console.WriteLine("count: " + SlotWheels(historyList));
