using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class StatsComputer
    {
        public struct mystats
           {
               public double average;
               public double max;
               public double min;
           };  mystats mystatsobj;
        
        public mystats CalculateStatistics(List<double> numbers) {
            
           mystatsobj.average = Double.NaN;
           mystatsobj.max = Double.NaN;
           mystatsobj.min = Double.NaN;
            
           double myavg = Queryable.Average(numbers.AsQueryable());
           double mymax = numbers.Max();
           double mymin = numbers.Min();
           
            mystatsobj.average = myavg;
            mystatsobj.max = mymax;
            mystatsobj.min = mymin;
            
            return mystatsobj;
           
        }
       static void Main(string[] args)
       {
          
       }
    }
}
