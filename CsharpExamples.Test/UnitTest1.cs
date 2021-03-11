using System.Collections.Generic;
using CsharpApplication;
using CsharpExamples;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void TestPassing()
        {
            var list1 = Part1_1.MultiplyList(Part1_1.CreateList());
            var list2 = Part1_1.GetEvenNumbers(Part1_1.CreateList());
            Assert.AreEqual(list1, new List<int> {1, 4, 9, 16, 25, 36, 49, 64, 81, 100});
            Assert.AreEqual(list2, new List<int> {2, 4, 6, 8, 10});
        }
        [Test]
        public void TestFailing()
        {
            var list = Part1_1.CreateList();
            var list1 = Part1_1.MultiplyList(list);
            var list2 = Part1_1.GetEvenNumbers(list);
            Assert.AreEqual(list1, new List<int> {1, 4, 9, 16, 25, 36, 49, 64, 81, 100});
            Assert.AreEqual(list2, new List<int> {2, 4, 6, 8, 10});
        }
        [Test]
        public void TestPassing2()
        {
            var list1 = Part1_2.MultiplyList(Part1_2.CreateList());
            var list2 = Part1_2.GetEvenNumbers(Part1_2.CreateList());
            Assert.AreEqual(list1, new List<int> {1, 4, 9, 16, 25, 36, 49, 64, 81, 100});
            Assert.AreEqual(list2, new List<int> {2, 4, 6, 8, 10});
        }
        [Test]
        public void TestPassing3()
        {
            var list = Part1_2.CreateList();
            var list1 = Part1_2.MultiplyList(list);
            var list2 = Part1_2.GetEvenNumbers(list);
            Assert.AreEqual(list1, new List<int> {1, 4, 9, 16, 25, 36, 49, 64, 81, 100});
            Assert.AreEqual(list2, new List<int> {2, 4, 6, 8, 10});
        }
    }
}