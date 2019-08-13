using System;

namespace DelegateAndEvents2
{
    class Program
    {

        public delegate int WorkedPerformedHandler(int hours, WorkType wt);

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            WorkedPerformedHandler del1 = new WorkedPerformedHandler(WorkedPerformed1);
            WorkedPerformedHandler del2 = new WorkedPerformedHandler(WorkedPerformed2);
            WorkedPerformedHandler del3 = new WorkedPerformedHandler(WorkedPerformed3);

            //del1(5, WorkType.Golf);
            //del2(10, WorkType.GenerateReports);

            del1 += del2 + del3;


            int finalHours = del1(10, WorkType.GenerateReports);

            Console.WriteLine(finalHours);


            doWork(del1);
        }

        static void doWork(WorkedPerformedHandler del)
        {

            del(4, WorkType.GoToMeetings);
        }

        static int WorkedPerformed1(int hours, WorkType wt)
        {

            Console.WriteLine("WorkedPerformed1 called " + hours);

            return hours + 1;
      
        }

        static int WorkedPerformed2(int hours, WorkType wt)
        {

            Console.WriteLine("WorkedPerformed2 called " + hours);
            return hours + 2;
        }

        static int WorkedPerformed3(int hours, WorkType wt)
        {

            Console.WriteLine("WorkedPerformed3 called " + hours);
            return hours + 3;
        }
    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports
    }
}
