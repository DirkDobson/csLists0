using System;
using System.Collections.Generic;

namespace csLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4, };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6 ,7 });

            foreach ( var i in numbers)
                System.Console.WriteLine(i);

            System.Console.WriteLine();
            Console.WriteLine(numbers.IndexOf(1));
            Console.WriteLine(numbers.LastIndexOf(1));

            System.Console.WriteLine("Count" + numbers.Count);

            
            for( var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                    numbers.Remove(numbers[i]);
            }
            foreach ( var i in numbers)
                System.Console.WriteLine(i);

            numbers.Clear();
            System.Console.WriteLine("Count" + numbers.Count);
        }
    }
}
