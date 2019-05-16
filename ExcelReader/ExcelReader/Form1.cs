using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace ExcelReader
{
    public partial class Form1 : Form
    {
        ArrayList listsv = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            bw_load.RunWorkerAsync();
        }
        private void loadDataFromExcel()
        {
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = xlApp.Workbooks.Open(@"E:\DRL HK2 2017-2018.xlsx");
            Worksheet sheet = wb.Sheets[1];
            Range rangeReader = sheet.UsedRange;
            int rowcount = rangeReader.Rows.Count;
            int colcount = rangeReader.Rows.Count;
           // dtgv_data.ColumnCount = colcount;
           // dtgv_data.RowCount = rowcount;

            for (int i = 7; i < rowcount; i++)
            {
                SinhVien sv = new SinhVien();
                
                if (rangeReader.Cells[i, 3] != null && rangeReader.Cells[i, 3].Value2 != null)
                {
                    sv.MSSV = rangeReader.Cells[i, 3].Value2.ToString();                 
                }
                if (rangeReader.Cells[i, 4] != null && rangeReader.Cells[i, 3].Value2 != null)
                {
                    sv.HoTen = rangeReader.Cells[i,4].Value2+" "+ rangeReader.Cells[i, 5].Value2;
                }
                if (rangeReader.Cells[i, 6] != null && rangeReader.Cells[i, 6].Value2 != null)
                {
                    sv.Lop = rangeReader.Cells[i, 6].Value2+"";
                }
                listsv.Add(sv);
                bw_load.ReportProgress(i * 100 / rowcount);
                
            }
                
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:  
            //  never use two dots, all COM objects must be referenced and released individually  
            //  ex: [somthing].[something].[something] is bad  

            //release com objects to fully kill excel process from running in the background  
            Marshal.ReleaseComObject(rangeReader);
            Marshal.ReleaseComObject(sheet);

            //close and release  
            wb.Close();
            Marshal.ReleaseComObject(wb);

            //quit and release  
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }

        private void bw_load_DoWork(object sender, DoWorkEventArgs e)
        {
            loadDataFromExcel();
        }

        private void bw_load_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            bar_loading.Value = e.ProgressPercentage;
        }

        private void bw_load_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dtgv_data.DataSource = listsv;
            bar_loading.Value = 0;
            MessageBox.Show("Loading done");
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            ExportToExcel(dtgv_data);
        }
        public static void ExportToExcel(DataGridView dgView)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = null;
            try
            {
                // instantiating the excel application class
                excelApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook currentWorkbook = excelApp.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel.Worksheet currentWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)currentWorkbook.ActiveSheet;
                currentWorksheet.Columns.ColumnWidth = 18;


                if (dgView.Rows.Count > 0)
                {
                    currentWorksheet.Cells[1, 1] = DateTime.Now.ToString("s");
                    int i = 1;
                    foreach (DataGridViewColumn dgviewColumn in dgView.Columns)
                    {
                        // Excel work sheet indexing starts with 1
                        currentWorksheet.Cells[2, i] = dgviewColumn.Name;
                        ++i;
                    }
                    Microsoft.Office.Interop.Excel.Range headerColumnRange = currentWorksheet.get_Range("A2", "G2");
                    headerColumnRange.Font.Bold = true;
                    headerColumnRange.Font.Color = 0xFF0000;
                    //headerColumnRange.EntireColumn.AutoFit();
                    int rowIndex = 0;
                    for (rowIndex = 0; rowIndex < dgView.Rows.Count; rowIndex++)
                    {
                        DataGridViewRow dgRow = dgView.Rows[rowIndex];
                        for (int cellIndex = 0; cellIndex < dgRow.Cells.Count; cellIndex++)
                        {
                            currentWorksheet.Cells[rowIndex + 3, cellIndex + 1] = dgRow.Cells[cellIndex].Value;
                        }
                    }
                    Microsoft.Office.Interop.Excel.Range fullTextRange = currentWorksheet.get_Range("A1", "G" + (rowIndex + 1).ToString());
                    fullTextRange.WrapText = true;
                    fullTextRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                }
                else
                {
                    string timeStamp = DateTime.Now.ToString("s");
                    timeStamp = timeStamp.Replace(':', '-');
                    timeStamp = timeStamp.Replace("T", "__");
                    currentWorksheet.Cells[1, 1] = timeStamp;
                    currentWorksheet.Cells[1, 2] = "No error occured";
                }
                using (SaveFileDialog exportSaveFileDialog = new SaveFileDialog())
                {
                    exportSaveFileDialog.Title = "Select Excel File";
                    exportSaveFileDialog.Filter = "Microsoft Office Excel Workbook(*.xlsx)|*.xlsx";

                    if (DialogResult.OK == exportSaveFileDialog.ShowDialog())
                    {
                        string fullFileName = exportSaveFileDialog.FileName;
                        // currentWorkbook.SaveCopyAs(fullFileName);
                        // indicating that we already saved the workbook, otherwise call to Quit() will pop up
                        // the save file dialogue box

                        currentWorkbook.SaveAs(fullFileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbook, System.Reflection.Missing.Value, Missing.Value, false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Microsoft.Office.Interop.Excel.XlSaveConflictResolution.xlUserResolution, true, Missing.Value, Missing.Value, Missing.Value);
                        currentWorkbook.Saved = true;
                        MessageBox.Show("Exported successfully", "Exported to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (excelApp != null)
                {
                    excelApp.Quit();
                }
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ArrayList newList = new ArrayList();
            foreach(SinhVien sv in listsv)
            {
                
            
                if(sv!=null&& sv.MSSV!=null&&sv.MSSV.Contains(textBox1.Text))
                    newList.Add(sv);
            }

            dtgv_data.DataSource = newList;
        }
    }
}
