namespace exceptions_net8;

public class Example
{
    public int MyFlakyMethod(int times)
    {
        var random = new Random(69);
        var count = 0;
        for (var i = 0; i < times; i++)
        {
            try
            {
                if (random.Next(1, 10) >= 5)
                {
                    throw new Exception("Pew");
                }
            }
            catch
            {
                count++;
            }
        }
        return count;
    }
    
    public int MyGoodMethod(int times)
    {
        var random = new Random(69);
        var count = 0;
        for (var i = 0; i < times; i++)
        {
            try
            {
                if (random.Next(1, 10) >= 5)
                {
                    count++;
                }
            }
            catch
            {
                count++;
            }
        }
        return count;
    }
}