namespace Day09Demo.AssignmentSample.Utility;

public static class StringExtension
{
    public static string Left(this string str, int size)
    {
        return str.Length <= size ? str : str[..15];
    }

}