using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    public partial class BMICalculator : Form
    {
        public float MyHeight { get; set; }
        public float MyWeight { get; set; }
        public float MyBMI { get; set; }

        public BMICalculator()
        {
            InitializeComponent();
        }


        private void BMICalculatorForm_Load(object sender, EventArgs e)
        {
            ClearForm();
        }

        //Switch I & M

        private void ImperialButton_CheckedChanged_1(object sender, EventArgs e)
        {
            ClearForm();
            ImperialTableLayoutPanel.Visible = true;
            MetricTableLayoutPanel.Visible = false;
        }

        private void MetricButton_CheckedChanged_1(object sender, EventArgs e)
        {
            ClearForm();
            MetricTableLayoutPanel.Visible = true;
            ImperialTableLayoutPanel.Visible = false;
        }


        // Events handle for Imperial


        private void ImperialWeightTextBox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                float.Parse(ImperialWeightTextBox.Text);
                BMIButton.Enabled = true;
            }
            catch
            {
                BMIButton.Enabled = false;
            }
        }

        private void ImperialHeightTextBox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                float.Parse(ImperialHeightTextBox.Text);
                BMIButton.Enabled = true;
            }
            catch
            {
                BMIButton.Enabled = false;
            }
        }


        // Events handle for Metric


        private void MetricWeightTextBox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                float.Parse(MetricWeightTextBox.Text);
                BMIButton.Enabled = true;
            }
            catch
            {
                BMIButton.Enabled = false;
            }
        }

        private void MetricHeightTextBox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                float.Parse(MetricHeightTextBox.Text);
                BMIButton.Enabled = true;
            }
            catch
            {
                BMIButton.Enabled = false;
            }
        }


        // Events handle for BMI click


        private void BMIButton_Click_1(object sender, EventArgs e)
        {
            if (ImperialTableLayoutPanel.Visible == true)
            {
                MyHeight = float.Parse(ImperialHeightTextBox.Text);
                MyWeight = float.Parse(ImperialWeightTextBox.Text);
                MyBMI = (MyWeight * 703) / (MyHeight * MyWeight);
            }
            else
            {
                MyHeight = float.Parse(MetricHeightTextBox.Text);
                MyWeight = float.Parse(MetricWeightTextBox.Text);
                MyBMI = MyWeight / (MyHeight * MyWeight);
            }
            MyBMI = (float)Math.Round(MyBMI, 2);
            ResultTextBox.Text = MyBMI.ToString();
            ResultTextBox.BackColor = Color.LightSeaGreen;
        }

        private void ClearForm()
        {
            ImperialHeightTextBox.Text = "";
            ImperialWeightTextBox.Text = "";
            ImperialHeightTextBox.Text = "";
            ImperialWeightTextBox.Text = "";
            BMIButton.Enabled = false;
            ResultTextBox.Clear();
            ResultTextBox.BackColor = Color.White;
        }

        private void ResetButton_Click_1(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ResultLabel_Click(object sender, EventArgs e)
        {

        }

        private void CalculatorButtonTableLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ResultTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }
    }
}
