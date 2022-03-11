﻿namespace Day09Demo.AssignmentSample
{
    public interface IMenuActions
    {
        void AddStudent();
        void AddSubject();

        void EditStudent();
        void EditSubject();

        void GetAllStudents();
        void GetAllSubjects();

        void GetAnyStudent();
        void GetAnySubject();

        void ShowStudentMarks();
    }
}