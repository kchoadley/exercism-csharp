using System;

public class BinarySearch
{
    private readonly int[] array;
    public BinarySearch(int[] input)
    {
        array = input;
    }

    public int Find(int value) => array.Length == 0?
        -1:
        FindHelper(0, array.Length - 1, value);

    private int FindHelper(int min, int max, int value) {
        int result = -1;
        int index = (max + min + 1) / 2;
        if (array[index] == value)
        {
            result = index;
        }
        else if (value < array[index])
        {
            if (index != 0)
            {
                result = FindHelper(0, index - 1, value);
            }
        }
        else
        {
            if (index != max)
            {
                result = FindHelper(index + 1, max, value);
            }
        }
        return result;
    }
}