using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace D_Lay
{
    class Calculation
    {
        public float dRatio = 1.5f;

        public float tRatio = 0.6667f;

        public float bpm { get; set; } = 0;
        public int precision { get; set; } = 0;
        public float whole { get; set; }
        public float half { get; set; }
        public float quarter { get; set; }
        public float eigth { get; set; }
        public float sixteenth { get; set; }
        public float thirtysecond { get; set; }
        public float sixtyfourth { get; set; }


        private void setQuarter()
        {
            quarter = 60000 / bpm;
        }

        public void Calculate()
        {
            setQuarter();
            whole = quarter * 4;
            half = quarter * 2;
            eigth = quarter / 2;
            sixteenth = quarter / 4;
            thirtysecond = quarter / 8;
            sixtyfourth = quarter / 16;
        }

    }
}
