using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

/**

 *

 * Name: Jack Fendley

 * Teacher: Mr. Hardman

 * Assignment #2 Program #2

 * Date Last Modified:October 18th,2016

 *
 */
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            double FirstNum = Convert.ToDouble(txtFirstNum.Text);
            double SecondNum = Convert.ToDouble(txtSecondNum.Text);
            double ThirdNum = Convert.ToDouble(txtThirdNum.Text);
            double FourthNum = Convert.ToDouble(txtFourthNum.Text);
            double FifthNum = Convert.ToDouble(txtFifthNum.Text);

            double Average = (FirstNum + SecondNum + ThirdNum + FourthNum + FifthNum) / 5.0;

            lblDisplayAverage.Text = String.Format("{0,11}{1,11}{2,11}{3,11}{4,11}{5,11}{6,11}{7,11}{8,11}{9,11}{10,11}{11,11}",
                "\n" + "Grade 1:", FirstNum,
                "\n" + "Grade 2:", SecondNum,
                "\n" + "Grade 3:", ThirdNum,
                "\n" + "Grade 4:", FourthNum,
                "\n" + "Grade 5:", FifthNum,
                
                "\n" + "Average:", Average);
          
        }
    }
}
