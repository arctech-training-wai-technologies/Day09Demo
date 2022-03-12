namespace Day09Demo.AssignmentSample.Exceptions;

public class DuplicateCodeException : Exception
{
    public int Code { get; }

    public DuplicateCodeException(int code)
    {
        Code = code;
    }
}