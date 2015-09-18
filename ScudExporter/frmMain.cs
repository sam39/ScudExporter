using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScudExporter
{
    public interface IfrmMain
    {
        List<BL.Division> DivList { set;}
        List<BL.Emp> EmpList { set; }
        List<BL.Emp> SelectedEmp { get; }
        event EventHandler RunReport;
        event EventHandler Search;
        String SearchSrting { get; }
        Reports SelectedReport { get; }
        List<Reports> ReportList { set; }
        DateTime Start { get; }
        DateTime End { get; }
        String ReportPath { get; }
    }



    public partial class frmMain : Form, IfrmMain
    {
        
        public frmMain()
        {
            InitializeComponent();
            btnEvensRep.Click += BtnEvensRep_Click;
            tbSearch.TextChanged += TbSearch_TextChanged;
            dist_pathTextBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +  "\\" ;
        }

        public event EventHandler RunReport;
        public event EventHandler Search;

        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            if (Search != null) Search(sender, EventArgs.Empty);
        }

        private void BtnEvensRep_Click(object sender, EventArgs e)
        {
            if (RunReport != null)  RunReport(sender, EventArgs.Empty);
        }

        public String ReportPath
        {
            get { return dist_pathTextBox.Text + DateTime.Now.ToString("yyyyMMddhhmmss") + ".txt";}
        }

        public String SearchSrting
        {
            get { return tbSearch.Text; }
        }

        public List<BL.Division> DivList
        {
             set { divisionBindingSource.DataSource = value; }
        }

        public List<BL.Emp> EmpList
        {
            set { empBindingSource.DataSource = value; }
        }

        public List<Reports> ReportList
        {
            set { comboBoxReports.DataSource = value; }
        }

        public List<BL.Emp> SelectedEmp
        {
            get
            {
                List<BL.Emp> selected = new List<BL.Emp>();
                foreach (BL.Emp emp in empBindingSource.DataSource as List<BL.Emp>)
                {
                    if ((Boolean)emp.Chk == true)
                    {
                        selected.Add(emp);
                    }
                }
                return selected;
            }
        }

        public Reports SelectedReport
        {
            get { return (Reports)comboBoxReports.SelectedItem;}
        }

        public DateTime Start
        {
            get { return start_DateDateTimePicker.Value; }
        }

        public DateTime End
        {
            get { return end_DateDateTimePicker.Value; }
        }



        private void frmMain_Load(object sender, EventArgs e)
        {

        }



        private void btnEvensRep_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDstDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.ShowDialog();
            dist_pathTextBox.Text = fd.SelectedPath;
        }

        private void tbCleanSearch_Click(object sender, EventArgs e)
        {
            tbSearch.Text = "";
        }

        private void empDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CalcSelected();
        }

        private void CalcSelected()
        {
            int Count = 0;
            if (empBindingSource.DataSource != null)
            {
                foreach (BL.Emp emp in empBindingSource.DataSource as List<BL.Emp>)
                {
                    if ((Boolean)emp.Chk == true)
                    {
                        Count++;
                    }
                }
                labelSelected.Text = "Выбрано: " + Count;
            }
        }

        private void divisionDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                BL.Division div = divisionBindingSource.Current as BL.Division;

                    foreach (BL.Emp emp in empBindingSource.DataSource as List<BL.Emp>)
                    {
                    if(emp.Division != null)
                        if (emp.Division.ID == div.ID)
                        {
                            if (div.Chk == true)
                                emp.Chk = true;
                            else
                                emp.Chk = false;
                        }
                    }
                empDataGridView.Refresh();
                CalcSelected();
            }

        }
    }

}
