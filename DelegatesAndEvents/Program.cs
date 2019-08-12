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


            // del1(5, WorkType.Golf);
            //del2(10, WorkType.GenerateReports);
            doWork(del2);


        }

        static void doWork(WorkedPerformedHandler del) {

            del(4, WorkType.GoToMeetings);
        }

        static void WorkedPerformed1(int hours, WorkType wt) {

            Console.WriteLine("WorkedPerformed1 called "+hours);
        }

        static void WorkedPerformed2(int hours, WorkType wt)
        {

            Console.WriteLine("WorkedPerformed2 called " + hours);
        }
    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports

    }
}