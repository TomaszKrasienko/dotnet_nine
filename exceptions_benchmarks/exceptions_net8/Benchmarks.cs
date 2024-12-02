using BenchmarkDotNet.Attributes;

namespace exceptions_net8;

[MemoryDiagnoser]
public class Benchmarks
{
    private readonly Example _example = new();

    [Benchmark]
    public int MthodThatWontFail()
    {
        return _example.MyGoodMethod(1000);
    }

    [Benchmark]
    public int MthodThatMightFail()
    {
        return _example.MyFlakyMethod(1000);
    }
}