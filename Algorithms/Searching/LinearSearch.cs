namespace Algorithms.Searching;

public static class LinearSearch<T>
{
    public static int Search(T[] array, T key)
    {
        for (int count = 0; count < array.Length; count++)
        {
            if (array[count].Equals(key))
                return count;
        }

        return -1;
    }

    public static int RecursiveSearch(T[] array, int size, T key)
    {
        if (size == 0)
            return -1;

        if (array[size - 1].Equals(key))
            return size - 1;

        return RecursiveSearch(array, size - 1, key);
    }
}
