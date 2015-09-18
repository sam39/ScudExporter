using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScudExporter.BL
{
    public class Period
    {
        // Дата и время Начала
        private DateTime date_start;
        public bool date_start_assigned;
        public virtual DateTime Date_start
        {
            get { return date_start; }
            set { date_start = value;
            date_start_assigned = true;
            }
        }

        // Дата и время окончания
        private DateTime date_end;
        public bool date_end_assigned;
        public virtual DateTime Date_end
        {
            get { return date_end; }
            set { date_end = value;
            date_end_assigned = true;
            }
        }

        public Period()
        {
            date_start_assigned = false;
            date_end_assigned = false;

        }

        public Period(DateTime stDate, DateTime endDate)
        {
            Date_start = stDate;
            Date_end = endDate;
        }

    }
}
