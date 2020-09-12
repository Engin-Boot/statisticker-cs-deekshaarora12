using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class StatsComputer
    {
           
            public double average;
            public double max;
            public double min;
            
        
        public StatsComputer CalculateStatistics(List<double> numbers) {
           
           StatsComputer mystatsobj = new StatsComputer();
            
           mystatsobj.average = Double.NaN;
           mystatsobj.max = Double.NaN;
           mystatsobj.min = Double.NaN;
            
          if(numbers.Length!=0)
            {
           double myavg = numbers.Average();
           double mymax = numbers.Max();
           double mymin = numbers.Min();
           
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
