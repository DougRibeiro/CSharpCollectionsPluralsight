using System;

namespace DelegatesAndEvents
{
    class Program
    {

        public delegate void WorkedPerformedHandler(int hours, WorkType wt);

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            WorkedPerformedHandler del1 = new WorkedPerformedHandler(WorkedPerformed1);
            WorkedPerformedHandler del2 = new WorkedPerformedHandler(WorkedPerformed2);
            WorkedPerformedHandler del3 = new WorkedPerformedHandler(WorkedPerformed3);

            //del1(5, WorkType.Golf);
            //del2(10, WorkType.GenerateReports);

            del1 += del2 + del3;

            doWork(del1);
        }

        static void doWork(WorkedPerformedHandler del)
        {
            del(4, WorkType.GoToMeetings);
        }

        static void WorkedPerformed1(int hours, WorkType wt)
        {
            Console.WriteLine("WorkedPerformed1 called " + hours);
        }

        static void WorkedPerformed2(int hours, WorkType wt)
        {
            Console.WriteLine("WorkedPerformed2 called " + hours);
        }

        static void WorkedPerformed3(int hours, WorkType wt)
        {
            Console.WriteLine("WorkedPerformed3 called " + hours);
        }
    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports
    }
}