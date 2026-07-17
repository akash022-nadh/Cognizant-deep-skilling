using System;

class Program
{
    static void Main()
    {
        double currentValue = 1000;
        double growthRate = 0.10;
        int years = 3;

        double futureValue = FinancialForecasting.PredictFutureValue(
            currentValue,
            growthRate,
            years
        );

        Console.WriteLine("Predicted Future Value: " + futureValue);
    }
}
