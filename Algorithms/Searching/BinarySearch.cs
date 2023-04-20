namespace Algorithms.Searching;

public class BinarySearch<T> where T : IComparable<T>
{
    public static int Search(T[] array, T target)
    {
        int lowIndex = 0;
        int highIndex = array.Length - 1;

        while (lowIndex <= highIndex)
        {
            var middleIndex = lowIndex + (highIndex - lowIndex) / 2;

            if (target.CompareTo(array[middleIndex]) < 0)
            {
                highIndex = middleIndex - 1;
                continue;
            }

            if (target.CompareTo(array[middleIndex]) > 0)
            {
                lowIndex = middleIndex + 1;
                continue;
            }

            return middleIndex;
        }

        return -1;
    }
}
