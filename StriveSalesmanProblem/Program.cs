using System;
using System.Diagnostics;

namespace StriveSalesmanProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solving your TSP problem..");

            TspSolver solver = new TspSolver();
            Stopwatch timer = new Stopwatch();
            timer.Start();

            Path optimalSolution = solver.Solve();

            timer.Stop();

            Console.WriteLine($"\nOptimal solution found for {solver.NumberOfCitiesConsidered} cities:\n{optimalSolution.Description}");

            Console.WriteLine($"That took {timer.ElapsedMilliseconds:#,0}ms");
        }
    }
}
