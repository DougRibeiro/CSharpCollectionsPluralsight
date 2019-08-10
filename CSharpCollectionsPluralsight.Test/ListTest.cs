using System;
using System.Collections.Generic;
using Xunit;

namespace CSharpCollectionsPluralsight.Test
{
    public class ListTest
    {
        private const string V = "Friday";

        [Fact]
        public void Test1()
        {

                List<String> daysOfTheWeek = new List<string>{

                    "Monday",
                    "Tuesday",
                    "Wednesday",
                    "Thursday",
                    "Friday"
                };

                foreach(string d in daysOfTheWeek){
                System.Diagnostics.Debug.WriteLine(d);
                }
        }
    }
}
