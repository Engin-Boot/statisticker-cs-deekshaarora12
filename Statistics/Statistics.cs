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
            
          if(numbers.Any())
            {
           float myavg = numbers.Average();
           float mymax = numbers.Max();
           float mymin = numbers.Min();
           
            mystatsobj.average = myavg;
            mystatsobj.max = mymax;
            mystatsobj.min = mymin;
          }
            
          
           mystatsobj.average = float.NaN;
           mystatsobj.max = float.NaN;
           mystatsobj.min = float.NaN;    
            
            return mystatsobj;
           
        }
    }
}
