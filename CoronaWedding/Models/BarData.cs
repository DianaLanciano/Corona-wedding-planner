using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaWedding.Models
{
    public class BarData
    {
        public string name { get; set; }
        public double value { get; set; }
    }

    public class BarChart
    {
        public IList<BarData> dataPoints { get; set; }
    }

    public class PieDataPoint
    {
        public string Name { get; set; }
        public int Value { get; set; }
    }

    public class PieChart
    {
        public IList<PieDataPoint> dataPoints { get; set; }
    }


    public class StatisticsViewModel
    {
        public BarChart barChart { get; set; }
        public PieChart pieChart { get; set; }
    }
}

