using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        public struct CalculateStatistics(List<double> numbers) {
           public struct mysats
           {
               public double average;
               public double max;
               public double min;
           }
           
           mystats mystatsobj;
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
    }
}
