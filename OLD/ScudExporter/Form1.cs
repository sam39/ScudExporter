using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ionic.Zip;
using NHibernate;
using NHibernate.Criterion;

namespace ScudExporter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SessionFactory.Init();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BL.Settings settings = (BL.Settings)settingsBindingSource.DataSource;

            string FileName = settings.End_Date.ToString("yyyyMMdd") + "_1000_01.txt";
            string ZipFileName = settings.End_Date.ToString("yyyyMMdd") + "_1000_01.zip";

            NHibernate.ISession s = SessionFactory.GetSession();
            ICriteria crit = s.CreateCriteria(typeof(BL.Event));
                crit.Add(Expression.Eq("Event32", 32));
                crit.Add(Expression.Gt("Date_event", settings.Start_Date));
                crit.Add(Expression.Le("Date_event", settings.End_Date ));
                crit.Add(Expression.Eq("Zone_code", 2));
                crit.Add(Expression.Sql(" HozOrgan = some (select e.Id from pList as e where e.Section not in (" + settings.Excluded + "))"));
                Order ord = new Order("Date_event", false);
                crit.AddOrder(ord);
            System.Collections.IList listEv = crit.List();

            StreamWriter sw = new StreamWriter(dist_pathTextBox.Text + FileName, false, System.Text.Encoding.GetEncoding(1251));
            foreach (BL.Event evnt in listEv)
            {
                int ZoneIndex = 0;
                foreach (BL.DoorZone dz in settings.DoorZones)
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
                zip.AddFile(dist_pathTextBox.Text + FileName, "");
                zip.Save(dist_pathTextBox.Text + ZipFileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Выгрузка информации о сотрудниках
            BL.Settings settings = (BL.Settings)settingsBindingSource.DataSource;
            string FileName = settings.End_Date.ToString("yyyyMMdd") + "_1000_01_U.txt";
            string ZipFileName = settings.End_Date.ToString("yyyyMMdd") + "_1000_01_U.zip";

            NHibernate.ISession s = SessionFactory.GetSession();
            //NHibernate.IQuery q = s.CreateQuery(" from Mark where Start > " + settings.End_Date.ToString("dd.MM.yyyy") + " and Owner = some (select e.Id from pList as e where e.Section not in (" + settings.Excluded + "))" );
            
            ICriteria crit = s.CreateCriteria(typeof(BL.Mark));
            crit.Add(Expression.Between("Start",settings.Start_Date, settings.End_Date));
            crit.Add(Expression.Sql(" Owner = some (select e.Id from pList as e where e.Section not in (" + settings.Excluded + "))"));

            System.Collections.IList list1 = crit.List();

            StreamWriter sw = new StreamWriter(dist_pathTextBox.Text + FileName, false, System.Text.Encoding.GetEncoding(1251));
            foreach (BL.Mark mark in list1)
            {
                if (mark.Owner != null)
                {
                    if (mark.Owner.Division != null)
                    {
                        sw.WriteLine(mark.Owner.TabNumber + ";"
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
                zip.AddFile(dist_pathTextBox.Text + FileName, "");
                zip.Save(dist_pathTextBox.Text + ZipFileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            BL.Settings settings = BL.Settings.read();
            settings.Start_Date = DateTime.Now.AddDays(-1);
            settings.End_Date = DateTime.Now.AddDays(-1);
            settingsBindingSource.DataSource = settings;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            settingsBindingSource.EndEdit();
            BL.Settings settings = (BL.Settings)settingsBindingSource.DataSource;
            settings.save();
        }

        private void btnDstDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.ShowDialog();
            dist_pathTextBox.Text = fd.SelectedPath;
        }

        private void end_DateDateTimePicker_Leave(object sender, EventArgs e)
        {
            DateTime dt = end_DateDateTimePicker.Value;
            dt = dt.AddHours(23 - dt.Hour).AddMinutes(59 - dt.Minute).AddSeconds(59 - dt.Second);
            end_DateDateTimePicker.Value = dt;
        }

        private void start_DateDateTimePicker_Leave(object sender, EventArgs e)
        {
            DateTime dt = start_DateDateTimePicker.Value;
            dt = dt.AddHours(-dt.Hour).AddMinutes(-dt.Minute).AddSeconds(-dt.Second);
            start_DateDateTimePicker.Value = dt;
        }

    }
}
