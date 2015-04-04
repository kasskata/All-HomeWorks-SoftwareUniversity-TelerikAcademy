namespace CustomLinkedList.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void AddingNewStringInLinkedListMustReturnAddedElementAndCheckCountMustBePlusAllElements()
        {
            var list = CreateListString();
            list.Add("New element");
            list.Add("New elementNew elementNew elementNew elementNew element%@#!$%!@^%%$&23525235261");
            list.Add(string.Empty);
            list.Add(string.Format("{0}{1}{2}", "Come", "To", "21/12/2001 23:30"));
            list.Add("New element");
            list.Add("New element");
            list.Add("New element");
            Console.WriteLine(list.Count);
        }

        [TestMethod]
        public void AddingNewDecimalInLinkedListMustReturnAddedElementAndCheckCountMustBePlusAllElements()
        {
            var list = CreateListDecimal();
            list.Add(123124.54213123124213M);
            list.Add(decimal.MaxValue);
            list.Add(decimal.MinusOne);
            list.Add(decimal.MinValue);
            Console.WriteLine(list.Count);
        }

        [TestMethod]
        public void AddingNewIntInLinkedListMustReturnAddedElementAndCheckCountMustBePlusAllElements()
        {
            var list = CreateListInt();
            list.Add(213);
            list.Add(int.MaxValue);
            list.Add(int.MinValue);
            list.Add(2138646412);
            list.Add(-1231412553);
            Console.WriteLine(list.Count);
        }

        private DynamicList<string> CreateListString()
        {
            return new DynamicList<string>();
        }

        private DynamicList<int> CreateListInt()
        {
            return new DynamicList<int>();
        }

        private DynamicList<Decimal> CreateListDecimal()
        {
            return new DynamicList<decimal>();
        }

        [TestMethod]
        public void LinkedListIndexingReturnIndexElements()
        {
            var list = CreateListInt();
            list.Add(213);
            list.Add(int.MaxValue);
            Console.WriteLine(list[1]);
            Console.WriteLine(list[0]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "ArgumentOutOfRangeException Didn't throw")]
        public void IndexOutOfRangeExceptionsReturnCorrectException()
        {
            var list = CreateListInt();
            list.Add(213);
            Console.WriteLine(list[2]);
            Console.WriteLine(list[1]);
            Console.WriteLine(list[-1]);
            Console.WriteLine(list.Count - 1);
            list[1] = list[0];
            list[2] = 123;
            list[3] = 123455 + int.Parse("213");
            list = new DynamicList<int>();
            list[1] = list[2];
        }

        [TestMethod]
        public void AtRemoveAtMethodExcpectremoveItems()
        {
            var list = CreateListInt();
            list.Add(213);
            list.Add(int.MaxValue);

            list.RemoveAt(list.Count - 1);
            list.RemoveAt(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "ArgumentOutOfRangeException Didn't throw")]
        public void ArgumentOutOfRangeExceptionAtRemoveAtMethodExcpectExceptions()
        {
            var list = CreateListInt();
            list.Add(213);
            list.Add(int.MaxValue);

            list.RemoveAt(list[0]);
            list.RemoveAt(list[0]);
            list.RemoveAt(list[0]);
            list.RemoveAt(list[0]);
            list.RemoveAt(list[0]);
        }

        [TestMethod]
        public void RemoveMethodReturnTheIndex()
        {
            var list = CreateListInt();
            list.Add(123);
            list.Add(123);
            Assert.AreEqual(0, list.Remove(123));


        }
        [TestMethod]
        public void RemoveMethodCheckWheaterWhenDontHaveThatElementMustReturnMinus1()
        {
            var list = CreateListInt();

            list.Add(123);
            list.Add(13);
            list.Add(12123);

            Assert.AreEqual(-1, list.Remove(52143654));
        }
        [TestMethod]
        public void IndexOfMethodCheckReturnsIndexOfElementIsContainsOrReturnMinus1()
        {
            var list = CreateListInt();

            list.Add(123);
            list.Add(13);
            list.Add(12123);

            Assert.AreEqual(0,list.IndexOf(123));
            Assert.AreEqual(1, list.IndexOf(13));
            Assert.AreEqual(2, list.IndexOf(12123));

            Assert.AreEqual(-1, list.IndexOf(9999));
        }

        [TestMethod]
        public void ContainMethodCheckForBooleanIfContainElementElseFalse()
        {
            var list = CreateListInt();

            list.Add(123);
            list.Add(13);
            list.Add(12123);

            Assert.AreEqual(true, list.Contains(123));
            Assert.AreEqual(true, list.Contains(13));
            Assert.AreEqual(true, list.Contains(12123));

            Assert.AreEqual(false, list.Contains(9999));
        }
    }
}
