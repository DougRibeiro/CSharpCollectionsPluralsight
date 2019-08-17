using System;
using System.Collections.Generic;
using System.Text;
using static DelegatesAndEvents3.Program;

namespace DelegatesAndEvents3
{
    class WorkePerformedEventArgs : EventArgs
    {
        private Program.WorkType workType1;

        public int Hours { get; set; }
        public WorkType workType { get; set; }

        public WorkePerformedEventArgs(int hours, WorkType wt)
        {
            this.Hours = hours;
            this.workType = wt;
        }

        
    }
}