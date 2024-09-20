using NUnit.Framework;

[assembly: Parallelizable(ParallelScope.Fixtures)]
[assembly: LevelOfParallelism(2)] // Adjust the level of parallelism as needed
