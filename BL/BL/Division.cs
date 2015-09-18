using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScudExporter.BL
{
    public class Division
    {
        private Int32  id;
        public virtual Int32 Id
        { 
            get {return id;}
            set { id = value;}     
        }

        // Выбор 
        private bool chk;
        public virtual bool Chk
        {
            get { return chk; }
            set { chk = value; }
        }

        private string name;
        public virtual string Name
        {
            get { return name; }
            set { name = value; }  
        }

    }
}
