using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ScudExporter.BL
{
    public class Report
    {
        private void Report1(DateTime start, DateTime end, string path,List<Emp> empList)
        {
            //Процедура формирования отчета по времени по дням
            //BL.Settings settings = (BL.Settings)settingsBindingSource.DataSource;
            TimeSpan per = end - start;

            string FileName = "TimeByDayReport.txt";

            System.Collections.IList empLst = empList;
            //System.Collections.IList empLst = (System.Collections.IList)empDataGridView.DataSource;
            StreamWriter sw = new StreamWriter(path + FileName, false, System.Text.Encoding.GetEncoding(1251));

            foreach (Emp emp in empLst)
            {
                if (emp.Chk == true) //Если сотрудник отмечен
                {
                    if (emp.Section != null)
                    {
                        string str = "";
                        for (int i = 0; i < per.Days; i++)
                        {
                            DateTime stDay = start.AddDays(i);
                            DateTime endDay = stDay.AddHours(23).AddMinutes(58);
                            str = str + ";";

                            str = str + emp.WorkedTime(stDay, endDay).TotalHours.ToString("....");
                        }
                        sw.WriteLine(emp.Name + ";" + str);
                    }
                }
            }

            sw.Close();



        }
    }
}
