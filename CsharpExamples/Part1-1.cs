using System.Collections.Generic;

namespace CsharpExamples
{
    public class Part1_1
    {
        public static List<int> CreateList()
        {
            return new List<int> {1,2,3,4,5,6,7,8,9,10};
        }

        public static List<int> MultiplyList(List<int> l)
        {
            for (var i = 0; i < l.Count; i++)
            {
                l[i] = l[i] * l[i];
            }
            return l;
        }
        public static List<int> GetEvenNumbers(List<int> l)
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