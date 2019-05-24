# ExceptionsPerformance
Benchmarking of using exceptions to control code flow.
There are two ways to get the value from list of strings (in this solution), one is searching for string using loop and another is using exceptions to tell code that value is not found.
These ways are created to simulate behaviour of ADO .NET DataReader class, where are two ways to get whether data row contains field or not.
They are:
- GetOrdinal - getting index by field name. Throws exception when field not found.
- Loop with GetFieldName. No exceptions are thrown.

Start Benchmarker project from your IDE and look at results. These are results from my laptop:


                              Method |        Mean |    StdErr |    StdDev |      Median | Rank |
    -------------------------------- |------------ |---------- |---------- |------------ |----- |
                WithLoop_AllNotFound |   7.7013 us | 0.0764 us | 0.3150 us |   7.6298 us |    3 |
          WithLoop_50PercentNotFound |   4.1775 us | 0.0405 us | 0.1517 us |   4.1141 us |    2 |
          WithLoop_10PercentNotFound |   3.6960 us | 0.0370 us | 0.3002 us |   3.5944 us |    1 |
           WithException_AllNotFound | 149.9131 us | 1.7090 us | 9.2035 us | 147.4496 us |    6 |
     WithException_50PercentNotFound |  78.3309 us | 0.7745 us | 3.8725 us |  77.8322 us |    5 |
     WithException_10PercentNotFound |  15.6316 us | 0.1526 us | 0.6104 us |  15.6592 us |    4 |
