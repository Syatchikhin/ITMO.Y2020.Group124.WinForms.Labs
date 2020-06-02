using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace ITMO._2020.WF.SyatcM.ExamTask.GasProp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            //--Air----------------------------------
            //string path1 = @"c:\temp\source1.xlsx";
            //GasComposition myGas1 = new GasComposition();
            //GasComposition myGas1Composition = GasComposition.ReadExcelFile(ref path1, ref myGas1);
            //GasComposition myGas1NormalizedComposition = GasComposition.Normalize(ref myGas1Composition);
            //GasComposition myGas1Calculated = GasComposition.CalculateProperties(ref myGas1NormalizedComposition);
            //GasComposition.OutputGasComposition(myGas1Composition);
            //GasComposition.PrintResults(myGas1Calculated);
            //GasComposition.SaveResultsToExcel(ref path1, ref myGas1Calculated);




        }
    }
}
