using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChartUpdateExample
{
    public class Record
    {
        public int Value { get; set; }
        public object Argument { get; set; }
        public object Series { get; set; }
        public Record(int value, object argument, object series)
        {
            this.Value = value;
            this.Argument = argument;
            this.Series = series;
        }
    }
}
