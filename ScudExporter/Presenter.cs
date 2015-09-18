using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ScudExporter
{
    public enum Reports
    {
        События,
        Ошибки_пар,
        Рабочее_время
        
    }
    public class Presenter
    {
        private readonly IfrmMain _view;
        private UnitOfWork unitOfWork = new UnitOfWork();


        public Presenter(IfrmMain form)
        {
            _view = form;
            _view.RunReport += _view_EventsReport;
            _view.Search += _view_Search;
            form.DivList = unitOfWork.DivisionRepository.GetAll() as List<BL.Division>;
            form.EmpList = unitOfWork.EmpRepository.GetAll() as List<BL.Emp>;
            form.ReportList = new List<Reports>() {Reports.События, Reports.Ошибки_пар};
        }

        private void _view_Search(object sender, EventArgs e)
        {
            List<BL.Emp> list = unitOfWork.EmpRepository.Get(filter: emp => emp.Name.Contains(_view.SearchSrting)) as List<BL.Emp>;
            list.OrderBy(s => s.Chk);
            _view.EmpList = list;
        }

        private void _view_EventsReport(object sender, EventArgs e)
        {
            var p = _view.SelectedEmp;
            BL.Division ss = unitOfWork.DivisionRepository.GetByID(1);

            if(_view.SelectedReport == Reports.События)
            EventsReport(_view.Start, _view.End, _view.SelectedEmp, _view.ReportPath);
        }

        private void EventsReport(DateTime start, DateTime end, List<BL.Emp> EmpList, String RepDist)
        {
            StreamWriter sw = new StreamWriter(RepDist, false, System.Text.Encoding.GetEncoding(1251));
            foreach (BL.Emp emp in EmpList)
            {
                IEnumerable<BL.ScudEvent> evList = unitOfWork.ScudEventRepository.Get(filter: s => s.HozOrgan == emp.ID 
                & s.TimeVal > start & s.TimeVal < end & s.DoorIndex == 8 & s.Event == 28);

                foreach (BL.ScudEvent evnt in evList)
                {
                    string evntName;
                    if (evnt.Mode == 1) evntName = "Вход";
                    else evntName = "Выход";

                    sw.WriteLine(emp.Name + " " + emp.FirstName + " " + emp.MidName + ";"
                    + evnt.TimeVal.ToString("dd.MM.yyyy") + ";"
                    + evnt.TimeVal.ToString("HH:mm:ss") + ";"
                    + evntName + ";"
                    );


                }
            }
            sw.Close();

        }



        private void Msg()
        {

        }
    }
}
