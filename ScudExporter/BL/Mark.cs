using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScudExporter.BL
{
    // Список паролей
    // таблица pMark
    public class Mark
    {
        // Уникальный идентификатор записи
        // Поле ID
        private Int32 id;
        public virtual  Int32 Id
        {
            get { return id; }
            set { id = value; }
        }

        // Владелец пароля 
        // поле Owner в pMark связь с(pList.ID)
        private BL.Emp owner;
        public virtual BL.Emp Owner
        {
            get { return owner; }
            set { owner = value; }        
        }

        //Дата начала действия пароля
        //поле Start 
        private DateTime start;
        public virtual DateTime Start
        {
            get { return start; }
            set { start = value; }                
        }

    }
}
