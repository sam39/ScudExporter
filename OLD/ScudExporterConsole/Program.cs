using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ionic.Zip;
using NHibernate;
using NHibernate.Criterion;
using ScudExporter;
namespace ScudExporterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            SessionFactory.Init();

            ScudExporter.BL.Settings settings = ScudExporter.BL.Settings.read();
            settings.Start_Date = DateTime.Now.AddDays(-1);
            settings.End_Date = DateTime.Now.AddDays(-1);

            string FileName = settings.End_Date.ToString("yyyyMMdd") + "_1000_01.txt";
            string ZipFileName = settings.End_Date.ToString("yyyyMMdd") + "_1000_01.zip";
            
            NHibernate.ISession s = ScudExporter.SessionFactory.GetSession();
            ICriteria crit = s.CreateCriteria(typeof(ScudExporter.BL.Event));
            crit.Add(Expression.Eq("Event32", 32));
            crit.Add(Expression.Gt("Date_event", settings.Start_Date));
            crit.Add(Expression.Le("Date_event", settings.End_Date));
            crit.Add(Expression.Eq("Zone_code", 2));
            crit.Add(Expression.Sql(" HozOrgan = some (select e.Id from pList as e where e.Section not in (" + settings.Excluded + "))"));
            Order ord = new Order("Date_event", false);
            crit.AddOrder(ord);
            System.Collections.IList listEv = crit.List();

            StreamWriter sw = new StreamWriter(settings.Dist_path + FileName, false, System.Text.Encoding.GetEncoding(1251));
            foreach (ScudExporter.BL.Event evnt in listEv)
            {

                int ZoneIndex = 0;
                foreach (ScudExporter.BL.DoorZone dz in settings.DoorZones)
                {
                    if (dz.Door_Index == evnt.Zone_code)
                    {
                        ZoneIndex = dz.Zone_code;
                    }
                }

                sw.WriteLine(evnt.Emp.TabNumber + ";"
                + evnt.Date_event.ToString("dd.MM.yyyy") + ";"
                + evnt.Date_event.ToString("HH:mm:ss") + ";"
                + evnt.Event_code.ToString() + ";"
                + ZoneIndex.ToString() + ";"
                );
            }
            sw.Close();

            using (ZipFile zip = new ZipFile())
            {
                zip.Password = settings.Password;
                zip.AddFile(settings.Dist_path + FileName, "");
                zip.Save(settings.Dist_path + ZipFileName);
            }



            // Выгрузка информации о сотрудниках
            FileName = settings.End_Date.ToString("yyyyMMdd") + "_1000_01_U.txt";
            ZipFileName = settings.End_Date.ToString("yyyyMMdd") + "_1000_01_U.zip";


            NHibernate.IQuery q = s.CreateQuery("from Mark where Start > " + DateTime.Now.AddDays(-2).ToString("dd.MM.yyyy"));
            System.Collections.IList list1 = q.List();

            StreamWriter swU = new StreamWriter(settings.Dist_path + FileName, false, System.Text.Encoding.GetEncoding(1251));
            foreach (ScudExporter.BL.Mark mark in list1)
            {
                if (mark.Owner != null)
                {
                    if (mark.Owner.Division != null)
                    {
                        swU.WriteLine(mark.Owner.TabNumber + ";"
                        + mark.Start.ToString("dd.MM.yyyy") + ";"
                        + mark.Owner.Fio + ";"
                        + mark.Owner.Division.Name + ";"
                        );
                    }
                }
            }
            sw.Close();

            using (ZipFile zip = new ZipFile())
            {
                zip.Password = settings.Password_Usr;
                zip.AddFile(settings.Dist_path + FileName, "");
                zip.Save(settings.Dist_path + ZipFileName);
            }
        }
    }
}
