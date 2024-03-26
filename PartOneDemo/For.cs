namespace PartOneDemo;
internal class For
{
    readonly int[] list = [1, 2, 3, 4, 5, 6, 7, 8, 9];
    public int DoSimple()
    {
        var count = 0;
        foreach (var item in list)
        {
            var j = item + 2;
            if (j > 3)
                count++;
        }
        return count;
    }

    public int DoWithPipeline()
    {
        return list.Select(x => x + 2)
            .Where(x => x > 3)
            .Count();
    }

}
