using AlphaReconReverse.Interfaces;
using System;

namespace AlphaReconReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            IMethods method = new Methods();
            var reverseWord = method.ReverseString("word reverse");
            Console.WriteLine(reverseWord);
        }
    }
}
