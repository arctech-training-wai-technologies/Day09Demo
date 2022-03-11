namespace Day09Demo.AssignmentSample.Utility;

public static class StringExtension
{
    public static string Left(this string str, int size)
    {
        if (str.Length <= size)
            return str;

        return str.Substring(0, 15);
    }

}