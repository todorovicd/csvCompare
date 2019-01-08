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
using System.Diagnostics;

namespace inactiveUsersReport
{

    public partial class frmHome : Form
    {
        public static List<String> fileOne = new List<string>();
        public static List<String> fileTwo = new List<string>();
        public static List<String> fileThree = new List<string>();

        public static string fileOnePath;
        public static string fileTwoPath;

        public static int fileThreeCounter = 0;

        public frmHome()
        {
            InitializeComponent();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            try
            {
                string line;
                StreamReader sr = new StreamReader(fileOnePath);
                StreamReader sr2 = new StreamReader(fileTwoPath);

                while (sr.Peek() >= 0)
                {
                    line = sr.ReadLine();
                    if (line != "")
                    {
                        fileOne.Add(line);
                    }
                }

                sr.Close();

                while (sr2.Peek() >= 0)
                {
                    line = sr2.ReadLine();
                    if (line != "")
                    {
                        fileTwo.Add(line);
                    }
                }

                sr2.Close();

                foreach (var item in fileTwo)
                {
                    string item1 = item;
                    compareItems(item1);
                }

                string dateTime = DateTime.Now.ToString(@"yyyy-MM-dd" + "_" + "hh-mm-ss");

                string fileThreeName = "inactiveUsersReport_" + dateTime;

                StreamWriter sw = new StreamWriter(@"C://Temp/" + fileThreeName + ".csv");

                sw.WriteLine("Full Name" + "," + "Email Address" + "," + "Account Disabled" + "," + "Last Google Activity" + "," + "Last AD Activity");

                foreach (var z in fileThree)
                {
                    sw.WriteLine(z);
                }

                MessageBox.Show("Report Completed. Total number of rows matching: " + fileThreeCounter);

                Process.Start(@"C://Temp/" + fileThreeName + ".csv");

                sw.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }         
        }

        private void compareItems(string item1)
        {
            string item1Part = item1.Substring(0, item1.IndexOf(',')).ToString().Replace("\"", "").ToLower();

            foreach (var item in fileOne)
            {
                string item2 = item;
                string item2Part = item.Substring(0, item.IndexOf(',')).ToString().Replace("\"", "").ToLower();

                if (item1Part == item2Part)
                {
                    fileThree.Add(item2 + ", " + item1.Split(',')[1].ToString().Replace("\"", ""));
                    fileThreeCounter++;
                }
            }
        }
        
        private void lstBoxAD_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void lstBoxAD_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            foreach (string file in files)
            {
                lstBoxAD.Items.Add(file);
                fileTwoPath = file;
            }
        }

        private void lstBoxGoogle_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void lstBoxGoogle_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            foreach (string file in files)
            {
                lstBoxGoogle.Items.Add(file);
                fileOnePath = file;
            }
        }

        private void btnCloseHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }   
}
