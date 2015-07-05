namespace _05.CountOfOccurences
{
    using System;
    using SingleLinkedList;

    class CountOfOccurences
    {
        static void Main()
        {
            //var listNumbers = TakeInput.ListIntPrepare();

            //var groupSequence = listNumbers
            //    .GroupBy(x => x)
            //    .OrderBy(x => x.Key)
            //    .ToList();

            //foreach (var seq in groupSequence)
            //{
            //    Console.WriteLine("{0} => {1} time{2}",
            //        seq.Key,
            //        seq.Count(),
            //        seq.Count() > 1 ? "s" : "");
            //}

            SingleLinkedList<int> linkedList = new SingleLinkedList<int>();

            linkedList.Add(2);  // 0
            linkedList.Add(5);  // 1
            linkedList.Add(7);  // 2
            linkedList.Add(7);  // 3
            linkedList.Add(13); // 4
            linkedList.Add(19); // 5
            linkedList.Add(21); // 6
            linkedList.Add(34); // 7
            linkedList.Add(13); // 8

            Console.WriteLine(linkedList.LastIndexOf(7));

        }
    }
}
