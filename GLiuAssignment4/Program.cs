using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 Author's name:Guoyang Liu
 Author’s student number: 300966032
 Date last Modified: Jul 26, 2019
 Program description: create a BMI calculator app that allows users to enter their 
 weight and height and whether they are entering these values in Imperial or Metric 
 units, then calculates and displays the user's body mass index (BMI).
 Revision History: Add form, design form, code solution, compress all file.
     */
namespace GLiuAssignment4
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BMICalculator());
        }
    }
}
