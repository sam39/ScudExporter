using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScudExporter.BL
{
    //События входа(выхода)
    //таблица pLogData
    public class Event
    {
        //колонка GUID 
        private string id;
        public virtual string Id
        {
            get { return id; }
            set { id = value; }
        }

        // Сотрудник
        // колонка HozOrgan
        private BL.Emp emp;
        public virtual BL.Emp Emp
        {
            get { return emp; }
            set { emp = value; }         
        }

        // Дата и время записи
        // колонка TimeVal
        private DateTime date_event;
        public virtual DateTime Date_event
        {
            get { return date_event; }
            set { date_event = value; }             
        }

        //«Код события» – вход (значение 1) или выход (значение 2);
        // колонка Mode
        private int event_code;
        public virtual int Event_code
        {
            get { return event_code; }
            set { event_code = value;}  
        }

        //	«Идентификатор помещения» – код зоны доступа 
        //(1 – периметр Банка; 2 – зона для курения, если есть, 3 – столовая, если есть). 
        // Необходимы данные только по этим зонам.
        // Par3
        private int zone_code;
        public virtual int Zone_code
        {
            get { return zone_code; }
            set { zone_code = value; }
        }


        //	«Вид события» – нужен только для отбора
        //(32 – проход)
        private int m_event;
        public virtual int Event32
        {
            get { return m_event; }
            set { m_event = value; }
        }
    }
}
