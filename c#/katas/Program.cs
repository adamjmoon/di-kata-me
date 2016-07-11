using System;

namespace Katas
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
