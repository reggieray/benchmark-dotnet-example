using System.Text;
using BenchmarkDotNet.Attributes;

public class StringConcatBenchmark
{
    private const int N = 10000;

    [Benchmark]
    public string Concat()
    {
        var sb = new StringBuilder();
        for (int i = 0; i < N; i++)
        {
            sb.Append("Hello ");
            sb.Append("World");
        }
        return sb.ToString();
    }

    [Benchmark]
    public string Interpolation()
    {
        var sb = new StringBuilder();
        for (int i = 0; i < N; i++)
        {
            sb.Append($"Hello {i}");
        }
        return sb.ToString();
    }
}