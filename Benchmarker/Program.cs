using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Exporters;
using BenchmarkDotNet.Running;
using Methods;

namespace Benchmarker
{
	[RPlotExporter, RankColumn]
	public class ExceptionPerformanceTest
	{
		[Benchmark]
		public void WithLoop_100PercentNotFound()
		{
			for (int i = 0; i < 10; i++)
				MethodsUnderTest.ContainsValue_WithLoop("not_existing");
		}

		[Benchmark]
		public void WithLoop_50PercentNotFound()
		{
			for (int i = 0; i < 10; i++)
			{
				if (i % 2 == 0)
				{
					MethodsUnderTest.ContainsValue_WithLoop("not_existing");
				}
				else
				{
					MethodsUnderTest.ContainsValue_WithLoop("name_100");
				}
			}
		}

		[Benchmark]
		public void WithLoop_10PercentNotFound()
		{
			for (int i = 0; i < 10; i++)
			{
				if (i == 0)
				{
					MethodsUnderTest.ContainsValue_WithLoop("not_existing");
				}
				else
				{
					MethodsUnderTest.ContainsValue_WithLoop("name_100");
				}
			}
		}
		
		[Benchmark]
		public void WithLoop_AllFound()
		{
			for (int i = 0; i < 10; i++)
				MethodsUnderTest.ContainsValue_WithLoop("name_100");
		}

		[Benchmark]
		public void WithException_100PercentNotFound()
		{
			for (int i = 0; i < 10; i++)
				MethodsUnderTest.ContainsField_WithException("not_existing");
		}

		[Benchmark]
		public void WithException_50PercentNotFound()
		{
			for (int i = 0; i < 10; i++)
			{
				if (i % 2 == 0)
				{
					MethodsUnderTest.ContainsField_WithException("not_existing");
				}
				else
				{
					MethodsUnderTest.ContainsField_WithException("name_100");
				}
			}
		}

		[Benchmark]
		public void WithException_10PercentNotFound()
		{
			for (int i = 0; i < 10; i++)
			{
				if (i == 0)
				{
					MethodsUnderTest.ContainsField_WithException("not_existing");
				}
				else
				{
					MethodsUnderTest.ContainsField_WithException("name_100");
				}
			}
		}
		
		[Benchmark]
		public void WithException_AllFound()
		{
			for (int i = 0; i < 10; i++)
				MethodsUnderTest.ContainsField_WithException("name_100");
		}
	}

	public class Program
	{
		public static void Main(string[] args)
		{
			var summary = BenchmarkRunner.Run<ExceptionPerformanceTest>();
		}
	}
}