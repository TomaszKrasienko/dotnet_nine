using System.Collections;

var sum = SumNumbers(1,2,3,4,5,6,7,8,9,10,11);
var sumSpan = SumNumbers(1,2,3,4,5,6,7,8,9,10,11);

Console.WriteLine(sum);
Console.WriteLine(sumSpan);

int SumNumbers(params CustomNumberColletion numbers)
{
    return numbers.Sum();
}

int SumSpanNumber(params ReadOnlySpan<int> numbers)
{
    var sum = 0;
    var length = numbers.Length;
    for (int i = 0; i < length; i++)
    {
        sum += numbers[i];
    }
    return sum;
}

public class CustomNumberColletion : IEnumerable<int>
{
    private readonly List<int> _numbers = new();
    
    public IEnumerator<int> GetEnumerator()
    {
        return _numbers.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    
    //requries this method
    public void Add(int number)
        => _numbers.Add(number);
}