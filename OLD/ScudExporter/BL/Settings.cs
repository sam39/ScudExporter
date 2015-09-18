using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ScudExporter.BL
{
    public class Settings
    {
        public Settings()
        {

        }

        /// каталог выгрузки
        /// используемый только для сохранения конечных результатов работы процедур выгрузки
        private string dist_path;
        public string Dist_path
        {
            get { return dist_path; }
            set { dist_path = value; }
        }

        /// Пароль для создания архива , удовлетворяющий требованиям порядка обращения 
        /// с паролями доступа к компьютерным системам ОАО "Россельхозбанк" 
        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        /// Пароль для создания архива идентификаторов карт , удовлетворяющий требованиям порядка обращения 
        /// с паролями доступа к компьютерным системам ОАО "Россельхозбанк" 
        private string password_usr;
        public string Password_Usr
        {
            get { return password_usr; }
            set { password_usr = value; }
        }



        /// дата начала выгрузки
        /// 
        private DateTime start_date;
        public virtual DateTime Start_Date
        {
            get { return start_date; }
            set {
                start_date = value.AddHours(-value.Hour).AddMinutes(-value.Minute).AddSeconds(-value.Second);           
                }
        }

        /// дата окончания выгрузки
        /// 
        private DateTime end_date;
        public virtual DateTime End_Date
        {
            get { return end_date; }
            set {
                end_date = value.AddHours(23 - value.Hour).AddMinutes(59 - value.Minute).AddSeconds(59 - value.Second);
                }
        }

        //отделы исключенные из 
        //выгрузки событий входа и выхода
        private string excluded;
        public string Excluded
        {
            get { return excluded; }
            set { excluded = value;}
        }

        //отделы исключенные из 
        //выгрузки событий входа и выхода
        private List<DoorZone> doorzones;
        public List<DoorZone> DoorZones
        {
            get { return doorzones; }
            set { doorzones = value; }
        }

        public void save()
        {
            XmlSerializer ser = new XmlSerializer(typeof(BL.Settings));
            TextWriter writer = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\config.xml", false, Encoding.GetEncoding(1251));
            ser.Serialize(writer, this);
            writer.Close();
        }

        public static BL.Settings read()
        {
            string fPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\config.xml";
            BL.Settings s = new Settings();
            if (File.Exists(fPath))
            {
                XmlSerializer mySerializer = new XmlSerializer(typeof(BL.Settings));
                FileStream myFileStream = new FileStream(fPath, FileMode.Open);
                s = (BL.Settings)mySerializer.Deserialize(myFileStream);
                myFileStream.Close();
            }
            return s;
        }
    }

    public class DoorZone
    {
        //	«Идентификатор замка» – код зоны доступа 
        //(1 – периметр Банка; 2 – зона для курения, если есть, 3 – столовая, если есть). 
        // Необходимы данные только по этим зонам.
        // Par3
        private int door_index;
        public virtual int Door_Index
        {
            get { return door_index; }
            set { door_index = value;}
        }

        // «Идентификатор помещения» – код зоны доступа 
        //(1 – периметр Банка; 2 – зона для курения, если есть, 3 – столовая, если есть). 
        // Необходимы данные только по этим зонам.
        // Par3
        private int zone_code;
        public virtual int Zone_code
        {
            get { return zone_code; }
            set { zone_code = value; }
        }
    }
}
