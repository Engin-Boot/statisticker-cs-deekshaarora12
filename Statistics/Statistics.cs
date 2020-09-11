using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class StatsComputer
    {
           
            public float average;
            public float max;
            public float min;
            
        
        public StatsComputer CalculateStatistics(List<float> numbers) {
           
           StatsComputer mystatsobj = new StatsComputer();
            
           mystatsobj.average = Single.NaN;
           mystatsobj.max = Single.NaN;
           mystatsobj.min = Single.NaN;
            
          if(numbers.Any())
            {
           float myavg = numbers.Average();
           float mymax = numbers.Max();
           float mymin = numbers.Min();
           
            mystatsobj.average = myavg;
            mystatsobj.max = mymax;
            mystatsobj.min = mymin;
          }
            
            return mystatsobj;
           
        }
       static void Main(string[] args)
       {
          
       }
    }
}
