using System;

namespace DelegatesAndEvents3
{
    class Program
    {

        public delegate int WorkedPerformedHandler(int hours, WorkType wt);

        static void Main(string[] args)
        {
            var worker = new Worker();
            // worker.WorkPerformed += new EventHandler<WorkePerformedEventArgs>(worker_WorkPerformed);
            // worker.WorkCompleted += new EventHandler(worker_Completed);

            worker.WorkPerformed += worker_WorkPerformed;
            worker.WorkCompleted += new EventHandler(worker_Completed);

            worker.WorkCompleted -= new EventHandler(worker_Completed);

            worker.DoWork(8, WorkType.GenerateReports);

        }

        private static void worker_WorkPerformed(object sender, WorkePerformedEventArgs e)
        {
            Console.WriteLine("Hours Worked " +e.Hours + " " + e.workType);
        }

        private static void worker_Completed(object sender, EventArgs e)
        {
            Console.WriteLine("Worker is done!");
        }

        public enum WorkType
        {
            GoToMeetings,
            Golf,
            GenerateReports
        }
    }
}