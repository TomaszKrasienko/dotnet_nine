var value = new[] {6, 9, 4, 20};

var last = value[^1];
var secondToLast = value[^2];

var example = new Example()
{
    Array =
    {
        [^4] = 6,
        [^3] = 9,
        [^2] = 4,
        [^1] = 20,
    }
};

class Example
{
    public int[] Array = new int[5];
}