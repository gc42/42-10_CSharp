using System;
using System.Collections.Generic;
using System.Linq;
namespace QuickDate
{
    public class EmptyClass
    {
        public EmptyClass()
        {
        }
    

        public static void Main(string[] args)
        {
            // _words is a string array that we'll sort alphabetically
            string[] words = {
                "the",
                "quick",
                "brown",
                "fox",
                "jumps"
            };

            //string[] morewords = {
            //    "over",
            //    "the",
            //    "lazy",
            //    "dog"
            //};

            IEnumerable<string> query = from word in words
                                        orderby word.Length
                                        select word;

            foreach (string str in query)
            {
                Console.WriteLine(str);
            }
        }
    }
}
