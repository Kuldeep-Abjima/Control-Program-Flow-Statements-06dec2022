using System;
using WiredBrainCoffeeSurveys.Reports;

namespace WiredBrainCoffeeSurveys.Report
{
    class program
    {
        static void Main(String[] args)
        {
            double responseRate;
            double unansweredCounts;
            responseRate = Q1Results.serviceScore + Q1Results.Coffee;
            Console.WriteLine($"Resoponse rate is = {responseRate}");
        }
    }
}
