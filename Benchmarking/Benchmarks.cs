using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Benchmarking;

[MemoryDiagnoser()]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn()]
public class Benchmarks
{
  private static readonly ProjectName testClass = new();

  [Params(10, 5000)]
  public int A {get;set;}

  [Params(20,2000)]
  public int B {get;set;}
    

  [Benchmark]
  public int ProjectNameBenchmark1()
  {
    return testClass.SimpleAdd(A, B);
  }

  [Benchmark]
  public int ProjectNameBenchmark2()
  {
    return testClass.SimpleMultiply(A, B);
  }
}


