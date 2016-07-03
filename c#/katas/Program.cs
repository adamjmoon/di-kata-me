using System;
using Kata.Katas.Add;

namespace Kata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var add = new Add();
            var result = add.Invoke(args);
            Console.WriteLine(result);
        }
    }
}
