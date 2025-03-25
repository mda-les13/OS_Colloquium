using System;
using System.Collections.Generic;

public class FibonacciCalculator
{
    public List<int> GetFibonacciNumbers(int n)
    {
        if (n <= 0)
            throw new ArgumentException("The number must be a natural number.");

        List<int> fibonacciNumbers = new List<int>();
        int a = 0, b = 1;

        for (int i = 0; i < n; i++)
        {
            fibonacciNumbers.Add(a);
            int temp = a;
            a = b;
            b = temp + b;
        }

        return fibonacciNumbers;
    }
}
