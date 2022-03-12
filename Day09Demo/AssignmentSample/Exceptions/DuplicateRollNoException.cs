namespace Day09Demo.AssignmentSample.Exceptions;

public class DuplicateRollNoException : Exception
{
    public int RollNo { get; set; }

    public DuplicateRollNoException(int rollNo)
    {
        RollNo = rollNo;
    }
}