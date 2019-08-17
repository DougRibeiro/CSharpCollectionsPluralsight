using System;
using System.Collections.Generic;
using System.Text;
using static DelegatesAndEvents3.Program;

namespace DelegatesAndEvents3
{

    //public delegate int WorkPerformedHandler(object sender,WorkePerformedEventArgs e );
    class Worker
    {

        public event EventHandler<WorkePerformedEventArgs> WorkPerformed;
        public event EventHandler WorkCompleted;

        //WorkPerformed(8, WorkType.GenerateReports);

        public void DoWork(int hours, WorkType workType)
        {

            for (int i = 0; i < hours; i++)
            {
                System.Threading.Thread.Sleep(1500);
                OnWorkPerformed(i + 1, workType);
            }
            OnWorkCompleted();
        }

        protected virtual void OnWorkPerformed(int hours, WorkType workType)
        {
            var del = WorkPerformed as EventHandler<WorkePerformedEventArgs>;
            if (del != null)
            {
                del(this, new WorkePerformedEventArgs(hours, workType));
            }
        }

        protected virtual void OnWorkCompleted()
        {
            var del = WorkCompleted as EventHandler;
            if (del != null)
            {
                del(this, EventArgs.Empty);
            }
        }
    }
}