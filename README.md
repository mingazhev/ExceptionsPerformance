# ExceptionsPerformance
Benchmarking of using exceptions to control code flow.
There are two ways to get the value from list of strings (in this solution), one is searching for string using loop and another is using exceptions to tell code that value is not found.
These ways are created to simulate behaviour of ADO .NET DataReader class, where are two ways to get whether data row contains field or not.
They are:
- GetOrdinal - getting index by field name. Throws exception when field not found.
- Loop with GetFieldName. No exceptions are thrown.

Start Benchmarker project from your IDE and look at results. These are results from my laptop:


                               Method |            Mean |        StdErr |         StdDev | Rank |
    --------------------------------- |---------------- |-------------- |--------------- |----- |
          WithLoop_100PercentNotFound |   5,301.9258 ns |    53.0328 ns |    339.5758 ns |    4 |
           WithLoop_50PercentNotFound |   6,160.5118 ns |    72.6483 ns |    355.9023 ns |    5 |
           WithLoop_10PercentNotFound |   4,097.5560 ns |    40.5199 ns |    249.7812 ns |    3 |
                    WithLoop_AllFound |   3,048.1326 ns |    30.3764 ns |    163.5820 ns |    2 |
     WithException_100PercentNotFound | 157,972.4183 ns | 1,694.8235 ns | 11,619.1246 ns |    8 |
      WithException_50PercentNotFound |  78,544.0070 ns |   784.2743 ns |  5,319.2074 ns |    7 |
      WithException_10PercentNotFound |  15,873.0764 ns |   122.1438 ns |    440.3958 ns |    6 |
               WithException_AllFound |     530.6526 ns |     6.0316 ns |     25.5897 ns |    1 |

