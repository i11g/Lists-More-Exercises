﻿List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

double sum = 0;

    for (int i = 0; i < numbers.Count - 1; i++)
    {
        if (numbers[i] == numbers[i + 1])
        {
            sum = numbers[i] + numbers[i + 1];
            numbers[i] = sum;
            numbers.Remove(numbers[i + 1]);
            i = -1;
        }
    }
  


Console.WriteLine(string.Join(" ", numbers));