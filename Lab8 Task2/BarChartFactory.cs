using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Task2
{
    class BarChartFactory : GraphFactory
    {
        public override Chart CreateChart()
        {
            return new BarChart();
        }
    }
}
