using Day09Demo.AssignmentSample.Models;

namespace Day09Demo.AssignmentSample.Interfaces;

public interface ISubjectCollection
{
    bool TryGetStudent(int subjectCode, out Subject subject);
}