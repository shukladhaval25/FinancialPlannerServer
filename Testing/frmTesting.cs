using System;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace FinancialPlannerServer.Testing
{
    public partial class frmTesting : Form
    {
        public frmTesting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileExcel;
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\Review data required Template Format.xlsx", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            fileExcel = FileName; // @"C:\Users\shukl\Downloads\Ascent Finance Solution\Review data required Template Format.xlsx";
            //Excel.Application xlapp;
            //Excel.Workbook xlworkbook;
            //xlapp = new Excel.Application();

            //xlworkbook = xlapp.Workbooks.Open(fileExcel, 0, false, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);

            //xlapp.Visible = true;

            var MyApp = new Excel.Application();
            MyApp.Visible = false;
            //proper way:
            var xlBook = MyApp.Workbooks.Open(fileExcel);

            var xlSheet = (Excel.Worksheet)xlBook.Worksheets.get_Item(1); // Explicit cast is not required here
                                                                      // Check and change sheet name to 'Sheet1'
            if (xlSheet.Name != "Sheet1")
                xlSheet.Name = "Sheet1";
            //you don't need to save a workbook now
            //as i mentioned above, you can do it later by using SaveAs method
            //xlBook.Save();
            int rowIndex = 19;
            int colIndex = 3;
            for (int i= 1; i <=3; i++)
            {
                string stmp = (string)xlSheet.Cells[rowIndex , colIndex].Value;
                //if (stmp == "yesterday")
                if (i == 1)
                    xlSheet.Cells[rowIndex, colIndex].Value = "Mr. Dhaval Shukla";
                else if (i==2)
                    xlSheet.Cells[rowIndex, colIndex].Value = "Mrs. Chhaya Shukla";
                else if (i==3)
                    xlSheet.Cells[rowIndex, colIndex].Value = "Mr. Svarna Shukla";

                colIndex = colIndex + 1;
            }
            

            string sNewFileName = Path.Combine(Path.GetDirectoryName(fileExcel),
    string.Concat(Path.GetFileNameWithoutExtension(fileExcel), "_", DateTime.Today.ToString("yyyyMMdd"), ".xslx"));
            xlBook.SaveAs(sNewFileName);
            MyApp.Visible = true;
            //if (stmp.Contains("-"))
            //xlSheet.Cells[2, 1].Value = stmp.Remove(ind, ind);
        }
    }
}
