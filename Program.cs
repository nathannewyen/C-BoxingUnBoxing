using System;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var objList = new List<object>
            {
                7,
                28,
                -1,
                true,
                "chair"
            };
            foreach (var obj in objList)
            {
                Console.WriteLine(obj);
            }

            int sum = 0;
            foreach (var obj in objList)
                if (obj is int)
                {
                    {
                        sum += (int)obj;
                    }
                }

            Console.WriteLine(sum);
        }
    }
}
