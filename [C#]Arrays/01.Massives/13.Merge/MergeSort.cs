using System;

//* Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).

class MergeSort
{
    //Това с класовете и методите съм го прегледал и ред по ред съм го писал
    //Ако нещо съм объркал се извинявам но това е нова материя за мен
    static public void doMerge(int[] array, int left, int mid, int right)
    {
        int[] temp = new int[25];
        int i, left_end, num_elements, temp_position;

        left_end = (mid - 1);
        temp_position = left;
        num_elements = (right - left + 1);

        while ((left <= left_end) && (mid <= right))
        {
            if (array[left] <= array[mid])
            {
                temp[temp_position++] = array[left++];
            }
            else
            {
                temp[temp_position++] = array[mid++];
            }
        }

        while (left <= left_end)
        {
            temp[temp_position++] = array[left++];
        }
        while (mid <= right)
        {
            temp[temp_position++] = array[mid++];
        }
        for (i = 0; i < num_elements; i++)
        {
            array[right] = temp[right];
            right--;
        }
    }

    static public void MergeSort_(int[] numbers, int left, int right)
    {
        int mid;

        if (right > left)
        {
            mid = (right + left) / 2;
            MergeSort_(numbers, left, mid);
            MergeSort_(numbers, (mid + 1), right);

            doMerge(numbers, left, (mid + 1), right);
        }
    }


    static void Main()
    {
        int[] array = new int[9];
        int len = 9;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        MergeSort_(array, 0, len - 1);
        for (int i = 0; i < 9; i++)
        {
            Console.WriteLine(array[i]);
            {

            }
        }
    }
}