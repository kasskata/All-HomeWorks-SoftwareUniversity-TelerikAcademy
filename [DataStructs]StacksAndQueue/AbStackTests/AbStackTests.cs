namespace AbStackTests
{
    using AbStack;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    //AbStack Library is fully testet - Covarage: 100%

    [TestClass]
    public class AbStackTests
    {
        AbStack<int> abStack = new AbStack<int>();
        [TestMethod]
        public void FillStackWithElementsExpectProperCountAndCapacity()
        {
            PushStack();
            Assert.AreEqual(17, this.abStack.Count);
            Assert.AreEqual(32, this.abStack.Capacity);
            this.abStack = new AbStack<int>();
        }

        [TestMethod]
        public void PopStackExpectProperCountAndCapacityReturnLastElement()
        {
            this.PushStack();
            this.PopStack();

            Assert.AreEqual(0, this.abStack.Count);
            Assert.AreEqual(16, this.abStack.Capacity);
            this.abStack = new AbStack<int>();
        }

        [TestMethod]
        public void StackConvertToArrayExpectProperCountAndCapacityReturnLastElement()
        {
            this.PushStack();

            int[] arr = this.abStack.ToArray();
            int[] compare = abStack.TrimExcess();

            for (int i = compare.Length - 1; i >= 0; i--)
            {
                Assert.AreEqual(compare[i], arr[i]);
            }

            this.abStack = new AbStack<int>();
        }

        [TestMethod]
        public void ToStringMethodExpectProperCountAndCapacityReturnLastElement()
        {
            this.PushStack();

            string toString = this.abStack.ToString();

            Assert.AreEqual("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17", toString);

            this.abStack = new AbStack<int>();
        }

        private void PopStack()
        {
            this.abStack.Pop();
            this.abStack.Pop();
            this.abStack.Pop();
            this.abStack.Pop();
            this.abStack.Pop();
            this.abStack.Pop();
            this.abStack.Pop();
            this.abStack.Pop();
            this.abStack.Pop();
            this.abStack.Pop();
            this.abStack.Pop();
            this.abStack.Pop();
            this.abStack.Pop();
            this.abStack.Pop();
            this.abStack.Pop();
            this.abStack.Pop();
            this.abStack.Pop();
        }

        private void PushStack()
        {
            this.abStack.Push(1);
            this.abStack.Push(2);
            this.abStack.Push(3);
            this.abStack.Push(4);
            this.abStack.Push(5);
            this.abStack.Push(6);
            this.abStack.Push(7);
            this.abStack.Push(8);
            this.abStack.Push(9);
            this.abStack.Push(10);
            this.abStack.Push(11);
            this.abStack.Push(12);
            this.abStack.Push(13);
            this.abStack.Push(14);
            this.abStack.Push(15);
            this.abStack.Push(16);
            this.abStack.Push(17);
        }
    }
}
