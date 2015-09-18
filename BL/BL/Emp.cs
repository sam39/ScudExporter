using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ScudExporter.BL
{
    /// Сотрудники
    /// Таблица pList
    public class Emp
    {

        // Выбор сотрудника
        private bool chk;
        public virtual bool Chk
        {
            get { return chk; }
            set { chk = value; }
        }

        // Уникальный идентификатор сотрудника
        // поле ID
        private Int32 id;
        public virtual Int32 Id
        {
            get { return id; }
            set { id = value; }
        }

        /// Табельный номер сотрудника
        /// колонка TabNumber
        private string tabnumber;
        public virtual string TabNumber
        {
            get { return tabnumber; }
            set { tabnumber = value; }
        }

        public virtual string Fio
        {
            get { return name + " " + firstname + " " + midname; }
        }

        public virtual string ToString
        {
            
            get {
                    if (Division != null)
                    {
                        return name + " " + firstname + " " + midname + " " + Division.Name;
                    }
                    else
                    { 
                        return name + " " + firstname + " " + midname;                
                    }
                }
            
        }

        // Фамилия
        // поле Name
        private string name;
        public virtual string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Имя
        // поле FirsName
        private string firstname;
        public virtual string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }

        // Отчество
        // поле MidName
        private string midname;
        public virtual string MidName
        {
            get { return midname; }
            set { midname = value; }
        }

        // Подразделение
        // поле Section
        // таблица pDivision
        private BL.Division division;
        public virtual BL.Division Division
        {
            get { return division; }
            set { division = value; }
        }

        public virtual TimeSpan WorkedTime(DateTime stDate, DateTime endDate)
        {
            NHibernate.ISession s = SessionFactory.GetSession();
            ICriteria crit = s.CreateCriteria(typeof(BL.Event));
            crit.Add(Expression.Eq("Event32", 28));
            crit.Add(Expression.Gt("Date_event", stDate));
            crit.Add(Expression.Le("Date_event", endDate));
            crit.Add(Expression.Eq("Emp.Id", Id));
            crit.Add(Expression.Eq("Zone_code", 8));
            //crit.Add(Expression.Sql(" HozOrgan = some (select e.Id from pList as e where e.Section not in (" + settings.Excluded + "))"));
            Order ord = new Order("Date_event", true);
            crit.AddOrder(ord);
            //System.Collections.IList listEv = crit.List();
            IList<BL.Event> l1 = crit.List<BL.Event>();

            //int res;
            if (l1.Count > 0) //Если есть события входа и выхода за данный период
            {
                //TimeSpan wt = l1.First().Date_event - l1.Last().Date_event;

                int wtMinutes;

                List<Period> PeriodList = new List<Period>();
                Period Period = new Period();
                foreach (Event ev in l1)
                {

                    if (ev.Event_code == 1) //Если событие вход
                    {
                        if (Period.date_start_assigned == false)
                        { 
                            Period.Date_start = ev.Date_event;
                        }
                    }

                    else // Событие выход
                    {
                        if (Period.date_start_assigned == true & Period.date_end_assigned == false)
                        {
                            Period.Date_end = ev.Date_event;
                        }
                    }

                    if (Period.date_start_assigned == true & Period.date_end_assigned == true)
                    {
                        PeriodList.Add(new Period(Period.Date_start, Period.Date_end));
                        Period.date_start_assigned = false;
                        Period.date_end_assigned = false;                    
                    }

                }

                TimeSpan wtAll = new TimeSpan();
                TimeSpan wtPer = new TimeSpan(); 
                //TimeSpan wtPer1 = new TimeSpan(); //Промежуточная переменная

                foreach (Period per in PeriodList)
                {

                    wtPer = per.Date_end - per.Date_start;
                    if (wtPer.Duration().Hours < 16 & wtPer.Duration().Days < 1)
                    {
                        wtAll = wtAll.Duration().Add(wtPer.Duration());
                    }
                    else
                    { 
                    }

                }
                return wtAll;
            }
            else // Если событий нет возвращаем 0
            {
                return new TimeSpan();
            }
        }

        public virtual List<Period> Pairs(DateTime stDate, DateTime endDate)
        {
            NHibernate.ISession s = SessionFactory.GetSession();
            ICriteria crit = s.CreateCriteria(typeof(BL.Event));
            crit.Add(Expression.Eq("Event32", 28));
            crit.Add(Expression.Gt("Date_event", stDate));
            crit.Add(Expression.Le("Date_event", endDate));
            crit.Add(Expression.Eq("Emp.Id", Id));
            crit.Add(Expression.Eq("Zone_code", 8));
            //crit.Add(Expression.Sql(" HozOrgan = some (select e.Id from pList as e where e.Section not in (" + settings.Excluded + "))"));
            Order ord = new Order("Date_event", true);
            crit.AddOrder(ord);
            //System.Collections.IList listEv = crit.List();
            IList<BL.Event> l1 = crit.List<BL.Event>();

                List<Period> PeriodList = new List<Period>();
                Period Period = new Period();
                foreach (Event ev in l1)
                {

                    if (ev.Event_code == 1) //Если событие вход
                    {
                        if (Period.date_start_assigned == false)
                        {
                            Period.Date_start = ev.Date_event;
                        }
                    }

                    else // Событие выход
                    {
                        if (Period.date_start_assigned == true & Period.date_end_assigned == false)
                        {
                            Period.Date_end = ev.Date_event;
                        }
                    }

                    if (Period.date_start_assigned == true & Period.date_end_assigned == true)
                    {
                        PeriodList.Add(new Period(Period.Date_start, Period.Date_end));
                        Period.date_start_assigned = false;
                        Period.date_end_assigned = false;
                    }

                }

                return PeriodList;

        }

        public virtual bool PairsError(DateTime stDate, DateTime endDate)
        {
            NHibernate.ISession s = SessionFactory.GetSession();
            ICriteria crit = s.CreateCriteria(typeof(BL.Event));
            crit.Add(Expression.Eq("Event32", 28));
            crit.Add(Expression.Gt("Date_event", stDate));
            crit.Add(Expression.Le("Date_event", endDate));
            crit.Add(Expression.Eq("Emp.Id", Id));
            crit.Add(Expression.Eq("Zone_code", 8));
            //crit.Add(Expression.Sql(" HozOrgan = some (select e.Id from pList as e where e.Section not in (" + settings.Excluded + "))"));
            Order ord = new Order("Date_event", true);
            crit.AddOrder(ord);
            //System.Collections.IList listEv = crit.List();
            IList<BL.Event> l1 = crit.List<BL.Event>();

            List<Period> PeriodList = new List<Period>();
            Period Period = new Period();

            bool PairsError = false;
            bool InBank = false;

            foreach (Event ev in l1)
            {

                if (ev.Event_code == 1) //Если событие вход
                {
                    if (InBank == true)
                    {
                        PairsError=true;
                    }
                    InBank = true;
                }

                else // Событие выход
                {
                    if (InBank == false)
                    {
                        PairsError = true;
                    }
                    InBank = false;
                }


            }

            if (InBank == true) PairsError = true;  
            return PairsError;

        }


    }
}
