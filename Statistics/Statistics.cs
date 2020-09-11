using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<double> numbers) {
           struct mysats
           {
               double average;
               double max;
               double min;
           }
           
           mystats mystatsobj;
           mystatsobj.average = Double.NaN;
           mystatsobj.max = Double.NaN;
           mystatsobj.min = Double.NaN;
            
           double my_avg = Queryable.Average(numbers.AsQueryable());
           double my_max = numbers.Max();
           double my_min = numbers.Min();
           
            mystatsobj.average = my_avg;
            mystatsobj.max = my_max;
            mystatsobj.min = my_min;
            
            return mystatsobj;
           
        }
    }
}
