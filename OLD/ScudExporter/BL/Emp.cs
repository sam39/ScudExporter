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
    }
}
