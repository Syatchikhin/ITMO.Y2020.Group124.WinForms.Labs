using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace ITMO._2020.WF.SyatcM.ExamTask.GasProp
{
    public partial class MainForm : Form
    {
        public string path;
        public string savePath;

        public MainForm()
        {
            InitializeComponent();
        }

        List<GasComposition> myGas = new List<GasComposition>();

        //public Excel.Application ObjWorkExcel = new Excel.Application(); //Open Excel //**2stage 


        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        public void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //--clean previous data----
            CleanScreenNoMessage();
            //-----------------
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\temp";
            // openFileDialog1.Filter = "xlsx files (*.xlsx)|*.xlsx|All Files(*.*)|*.*";
            openFileDialog1.Filter = "xlsx files (*.xlsx)|*.xlsx";
            openFileDialog1.FilterIndex = 2;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        path = openFileDialog1.FileName;
                        savePath = path;
                        GasComposition myGas1 = new GasComposition();
                        GasComposition myGas1Composition = GasComposition.ReadExcelFile(ref path, ref myGas1);

                        gasNameTextBox.Text = myGas1Composition.gasName;//gas name

                        MainForm mainmenu = new MainForm();//fill the screen
                        for (int j = 0; j < myGas1Composition.size; j++)// по всем строкам
                        {
                            ListViewItem newItem = gasListView.Items.Add((j + 1).ToString());
                            //newItem = gasListView.Items.Add((j + 1).ToString());
                            newItem.SubItems.Add(myGas1Composition.componentName[j]);
                            newItem.SubItems.Add(myGas1Composition.componentFormula[j]);
                            newItem.SubItems.Add(myGas1Composition.componentData[j, 0].ToString());
                            newItem.SubItems.Add(myGas1Composition.componentData[j, 1].ToString());
                            newItem.SubItems.Add((myGas1Composition.componentWeight[j].ToString()));
                        }

                        myGas.Add(myGas1); //send gas to collection
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk:" + ex.Message);
                }

            }

        }

        public void рассчитатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gasNameTextBox.Text != "") //protection from empty calculation
            {
                GasComposition myTempGas = myGas[0]; //extract gas from collection
                GasComposition myGas1NormalizedComposition = GasComposition.Normalize(ref myTempGas); //normalize
                GasComposition myGas1Calculated = GasComposition.CalculateProperties(ref myGas1NormalizedComposition); //calc prop
                                                                                                                       // send RO and R to screen
                dencityTextBox.Text = myGas1Calculated.mixtureDencity.ToString();
                gasConstantTextBox.Text = myGas1Calculated.mixtureR.ToString();
            }
            else
            {
                MessageBox.Show("Нет данных для расчета", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CleanScreen();
        }

        private void записатьРезультатToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (gasConstantTextBox.Text != "" && dencityTextBox.Text != "") //if any data to save
            {
                GasComposition dataForSaving = myGas[0]; //extract gas from collection
                GasComposition.SaveResultsToExcel(ref savePath, ref dataForSaving);
            }
            else
            {
                MessageBox.Show("Нет данных для сохранения", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void saveFileDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "xlsx files (*.xlsx)|*.xlsx";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                saveFileDialog1.FileName.Length > 0)
            {
                saveFileDialog1.FileName = savePath;
                GasComposition dataForSaving = myGas[0]; //extract gas from collection
                GasComposition.SaveResultsToExcel(ref savePath, ref dataForSaving);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //--clean previous data----
            CleanScreenNoMessage();
            //-----------------
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\temp";
            // openFileDialog1.Filter = "xlsx files (*.xlsx)|*.xlsx|All Files(*.*)|*.*";
            openFileDialog1.Filter = "xlsx files (*.xlsx)|*.xlsx";
            openFileDialog1.FilterIndex = 2;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        path = openFileDialog1.FileName;
                        savePath = path;
                        GasComposition myGas1 = new GasComposition();
                        GasComposition myGas1Composition = GasComposition.ReadExcelFile(ref path, ref myGas1);

                        gasNameTextBox.Text = myGas1Composition.gasName;//gas name

                        MainForm mainmenu = new MainForm();//fill the screen
                        for (int j = 0; j < myGas1Composition.size; j++)// по всем строкам
                        {
                            ListViewItem newItem = gasListView.Items.Add((j + 1).ToString());
                            //newItem = gasListView.Items.Add((j + 1).ToString());
                            newItem.SubItems.Add(myGas1Composition.componentName[j]);
                            newItem.SubItems.Add(myGas1Composition.componentFormula[j]);
                            newItem.SubItems.Add(myGas1Composition.componentData[j, 0].ToString());
                            newItem.SubItems.Add(myGas1Composition.componentData[j, 1].ToString());
                            newItem.SubItems.Add((myGas1Composition.componentWeight[j].ToString()));
                        }

                        myGas.Add(myGas1); //send gas to collection
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk:" + ex.Message);
                }

            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (gasNameTextBox.Text != "") //protection from empty calculation
            {
                GasComposition myTempGas = myGas[0]; //extract gas from collection
                GasComposition myGas1NormalizedComposition = GasComposition.Normalize(ref myTempGas); //normalize
                GasComposition myGas1Calculated = GasComposition.CalculateProperties(ref myGas1NormalizedComposition); //calc prop
                                                                                                                       // send RO and R to screen
                dencityTextBox.Text = myGas1Calculated.mixtureDencity.ToString();
                gasConstantTextBox.Text = myGas1Calculated.mixtureR.ToString();
            }
            else
            {
                MessageBox.Show("Нет данных для расчета", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void toolStripButton4_Click(object sender, EventArgs e)
        {
            CleanScreen();
        }


        public void CleanScreen()
        {
            if (gasConstantTextBox.Text != "" && dencityTextBox.Text != "") //protection from empty cleaning
            {
                gasNameTextBox.Text = gasConstantTextBox.Text = dencityTextBox.Text = "";
                gasListView.Items.Clear(); //clear screen 
                myGas.Clear(); //clear gas 
            }
            else
            {
                MessageBox.Show("Форма уже очищена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void CleanScreenNoMessage()
        {
            if (gasConstantTextBox.Text != "" && dencityTextBox.Text != "") //protection from empty cleaning
            {
                gasNameTextBox.Text = gasConstantTextBox.Text = dencityTextBox.Text = "";
                gasListView.Items.Clear(); //clear screen 
                myGas.Clear(); //clear gas 
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            if (gasConstantTextBox.Text != "" && dencityTextBox.Text != "") //if any data to save
            {
                GasComposition dataForSaving = myGas[0]; //extract gas from collection
                GasComposition.SaveResultsToExcel(ref savePath, ref dataForSaving);
            }
            else
            {
                MessageBox.Show("Нет данных для сохранения", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void содержаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contentForm contentForm1 = new contentForm();
            contentForm1.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void обавтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            authorForm AuthorForm1 = new authorForm();
            AuthorForm1.Show();
        }
    }
}
