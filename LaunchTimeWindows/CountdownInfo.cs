using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchTimeWindows
{
    public class CountdownInfo
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public bool CountdownEnd { get { return (DateTime.Now.Hour >= Hour && DateTime.Now.Minute >= Minute); } }

        public CountdownInfo()
        {
            Hour = 12;
            Minute = 00;
        }

        public override string ToString()
        {
            return Hour + ":" + Minute;
        }
    }
}
