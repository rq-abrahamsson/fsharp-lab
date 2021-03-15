using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CsharpExamples
{
    public class Part2_2
    {
        public static IEnumerable<int> CreateList()
        {
            return new List<int> {1,2,3,4,5,6,7,8,9,10};
        }

        public static List<int> MultiplyList(IEnumerable<int> l)
        {
            var l2 = new List<int>();
            foreach (var item in l)
            {
                l2.Add(item * item);
            }
            return l2;
        }
        public static List<int> GetEvenNumbers(IEnumerable<int> l)
        {
            var l2 = new List<int>();
            foreach (var item in l)
            {
                if (item % 2 == 0)
                {
                    l2.Add(item);
                }
            }
            return l2;
        }
    }
}