using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ArrayList = Homework.ArrayList;


namespace Homework.Tests
{
    [TestFixture]
    class ArrayListTests
    {

        [TestCase(new int[] { 1, 1, 6, 3, 6, 5, 6 }, 5, new int[] { 1, 1, 6, 3, 6, 5, 6, 5 })]
        [TestCase(new int[] { 1, 345, 76878 }, 12, new int[] { 1, 345, 76878, 12 })]
        [TestCase(new int[] { }, 0, new int[] { 0 })]
        public void AddEndTest(int[] source, int val, int[] expected)
        {
            ArrayList al = new ArrayList(source);

            al.AddEnd(val);

            int[] actual = al.Arr;

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 1, 42, new int[] { 1, 42, 2, 3, 4, 5, 6, 7 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 0, 42, new int[] { 42, 1, 2, 3, 4, 5, 6, 7 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 5, 42, new int[] { 1, 2, 3, 4, 5, 42, 6, 7 })]
        public void AddByIdxTest(int[] source, int idx, int val, int[] expected)
        {
            ArrayList al = new ArrayList(source);

            al.AddByIdx(idx, val);

            int[] actual = al.Arr;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2 }, new int[] { 3, 4, 5}, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, new int[] { 8, 9, 10 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        public void AddAllEndTest(int[] source, int[] vals, int[] expected)
        {
            ArrayList al = new ArrayList(source);

            al.AddAllEnd(vals);

            int[] actual = al.Arr;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 7 }, 4, new int[] { 5, 6 }, new int[] { 1, 2, 3, 4, 5, 6, 7 })]
        public void AddAllByIdxTest(int[] source, int idx, int[] vals, int[] expected)
        {
            ArrayList al = new ArrayList(source);

            al.AddAllByIdx(idx, vals);

            int[] actual = al.Arr;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 1, 6, 3, 6, 5, 6 }, 6, 720)]
        public void RemoveIdxTest(int[] source, int idx, int expected)
        {
            ArrayList al = new ArrayList(source);
            al.RemoveIdx(idx);

            int[] actual = al.Arr;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 1, 6, 3, 6, 5, 6 }, 6, new int[] { 1, 1, 6, 3, 6, 5, 6 })]
        public void RemoveValTest(int[] source, int val, int[] expected)
        {
            ArrayList al = new ArrayList(source);

            al.RemoveVal(val);

            int[] actual = al.Arr;

            Assert.AreEqual(expected, actual);

        }

        [TestCase(new int[] { 1, 1, 6, 3, 6, 5, 6 }, 5, 42, new int[] { 1, 1, 6, 3, 6, 42, 6 })]
        [TestCase(new int[] { 1, 1, 6, 3, 6, 5, 6 }, 0, 42, new int[] { 42, 1, 6, 3, 6, 5, 6 })]
        [TestCase(new int[] { 1, 1, 6, 3, 6, 5, 6 }, 1, 42, new int[] { 1, 42, 6, 3, 6, 5, 6 })]
        public void SetTest(int[] source, int idx, int val, int[] expected)
        {

            ArrayList al = new ArrayList();

            al.Set(idx, val);

            int[] actual = al.Arr;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 1, 6, 3, 6, 5, 6 }, 5, 5)]
        [TestCase(new int[] { 1, 1, 6, 3, 6, 5, 6 }, 1, 1)]
        [TestCase(new int[] { 1, 1, 6, 3, 6, 5, 6 }, 6, 6)]
        public void GetTest(int[] source, int idx, int expected)
        {
            ArrayList al = new ArrayList(source);

            int actual = al.Get(idx);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 1, 6, 3, 6, 5, 6 }, 7)]
        [TestCase(new int[] { 9, 6, 3, 6, 5, 6 }, 6)]
        [TestCase(new int[] { 1, 4, 6, 5, 6 }, 5)]
        [TestCase(new int[] { }, 0)]
        public void SizeTest(int[] source, int expected)
        {
            ArrayList al = new ArrayList(source);
           

            int actual = al.Size();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, false)]
        [TestCase(1, false)]
        [TestCase(6, true)]
        public void ContainsTest(int val, bool expected)
        {
            ArrayList al = new ArrayList();

            al.AddEnd(2);
            al.AddEnd(34);
            al.AddEnd(6);

            bool actual = al.Contains(val);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 1, 6, 3, 6, 5, 6 }, 1, 0)]
        [TestCase(new int[] { 1, 5, 6, 3, 6, 5, 6 }, 5, 1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 7, 6)]
        public void IndexOfTest(int[] source, int val, int expected)
        {
            ArrayList al = new ArrayList(source);

            int actual = al.IndexOf(val);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 1, 6, 3, 6, 5, 6 }, 1, new int[] { 0, 1 })]
        [TestCase(new int[] { 1, 1, 6, 3, 6, 5, 6 }, 5, new int[] { 5 })]
        [TestCase(new int[] { 1, 1, 6, 3, 6, 5, 6 }, 6, new int[] { 2, 4, 6 })]
        public void SearchTest(int[] source, int val, int[] expected)
        {
            ArrayList al = new ArrayList(source);

            int[] actual = al.Search(val);

            Assert.AreEqual(expected, actual);
        }
    }
}
