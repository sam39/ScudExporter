using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScudExporter.BL
{
    public partial class Emp
    {
        public Boolean Chk { get; set; }

        public string DivName
        {
            get
            {
                if (this.Division != null)
                    return this.Division.Name;
                else return "";
            }
        }

        public TimeSpan WorkedTime(DateTime stDay, DateTime endDay)
        {
            TimeSpan WorkedTime = new TimeSpan();
            return WorkedTime;

        }
    }
}
