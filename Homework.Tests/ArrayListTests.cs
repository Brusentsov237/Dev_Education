using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;


namespace Homework.Tests
{
    [TestFixture]
    class ArrayListTests
    {

        [TestCase(5, 120)]
        [TestCase(1, 1)]
        [TestCase(6, 720)]
        public void AddTest(int val, int[] expected)
        {
            ArrayList al = new ArrayList();
            al.Add(val);
            al.

            
            int actual = al.Add(val);
               Assert.AreEqual(expected, actual);

        }

        [TestCase(5, 120)]
        [TestCase(1, 1)]
        [TestCase(6, 720)]
        public void AddTest(int idx, int val, int expected)
        {
            int actual = al.Add(idx, val);
               Assert.AreEqual(expected, actual);

        }

        [TestCase(5, 120)]
        [TestCase(1, 1)]
        [TestCase(6, 720)]
        public void RemoveIdxTest(int idx, int expected)
        {
            int actual = al.RemoveIdx(idx);
               Assert.AreEqual(expected, actual);

        }

        [TestCase(5, 120)]
        [TestCase(1, 1)]
        [TestCase(6, 720)]
        public void RemoveValTest(int val, int expected)
        {
            int actual = al.RemoveVal(val);
            Assert.AreEqual(expected, actual);

        }

        [TestCase(5, 120)]
        [TestCase(1, 1)]
        [TestCase(6, 720)]
        public void RemoveAllTest(int val, int expected)
        {
            int actual = al.RemoveAll(val);
               Assert.AreEqual(expected, actual);

        }

        [TestCase(5, 120)]
        [TestCase(1, 1)]
        [TestCase(6, 720)]
        public void SetTest(int idx, int val, int expected)
        {
            int actual = al.Set(idx, val);
            Assert.AreEqual(expected, actual);

        }

        [TestCase(5, 120)]
        [TestCase(1, 1)]
        [TestCase(6, 720)]
        public void GetTest(int idx, int expected) 
        {

            int actual = al.Get(idx);
               Assert.AreEqual(expected, actual);

        }

        [TestCase(5, 120)]
        [TestCase(1, 1)]
        [TestCase(6, 720)]
        public void SizeTest( int expected)
        {
            int[] arr 
            int actual = al.Size();
               Assert.AreEqual(expected, actual);

        }

        [TestCase(5, true)]
        [TestCase(1, true)]
        [TestCase(6, true)]
        public void ContainsTest(int val, bool expected)
        {
            bool actual = al.Contains(val);
               Assert.AreEqual(expected, actual);

        }
        [TestCase(5, 120)]
        [TestCase(1, 1)]
        [TestCase(6, 720)]
        public void AddAllTest(int[] vals, int expected) 
        {
            int actual = al.AddAll(vals);
               Assert.AreEqual(expected, actual);

        }

        [TestCase(5, 120)]
        [TestCase(1, 1)]
        [TestCase(6, 720)]
        public void AddAllTest(int idx, int[] vals, int expected)
        {
            int actual = al.AddAll(idx, vals);
               Assert.AreEqual(expected, actual);

        }

        [TestCase(5, 120)]
        [TestCase(1, 1)]
        [TestCase(6, 720)]
        public void IndexOfTest(int idx, int[] vals, int expected)
        {
            int actual = al.IndexOf(idx, vals);
            Assert.AreEqual(expected, actual);

        }

        [TestCase(new int[] { 5, 120 }, new int[] { 5, 120 })]
        [TestCase(new int[] { 5, 120 }, new int[] { 5, 120 })]
        [TestCase(new int[] { 5, 120 }, new int[] { 5, 120 })]
        public void SearchTest(int[] vals, int[] expected)
        {
            int[] actual = al.Search(vals);

            Assert.AreEqual(expected, actual);

            
        }
    }
}
