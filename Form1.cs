using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace D_Lay
{
    public partial class MainUI : Form
    {
        Calculation calculator = new Calculation();
        public MainUI()
        {
            InitializeComponent();
            tBPM.Text = calculator.bpm.ToString();
        }

        private void bCalculate_Click(object sender, EventArgs e)
        {
            bool num = Int32.TryParse(tBPM.Text, out int result);
            
            if (!num)
            {
                MessageBox.Show("Enter numbers only please", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                calculator.bpm = result;
            }
            calculator.Calculate();
            PrintNormal();
            PrintDotted();
            PrintTriplet();

        }

        private void PrintNormal()
        {
            nWhole.Text = Math.Round(calculator.whole, calculator.precision).ToString();
            nHalf.Text = Math.Round(calculator.half, calculator.precision).ToString();
            nQuarter.Text = Math.Round(calculator.quarter, calculator.precision).ToString();
            nEighth.Text = Math.Round(calculator.eigth, calculator.precision).ToString();
            nSixteenth.Text = Math.Round(calculator.sixteenth, calculator.precision).ToString();
            nThirtysecond.Text = Math.Round(calculator.thirtysecond, calculator.precision).ToString();
            nSixtyfourth.Text = Math.Round(calculator.sixtyfourth, calculator.precision).ToString();
        }
        private void PrintDotted()
        {
            dWhole.Text = Math.Round(calculator.whole * calculator.dRatio, calculator.precision).ToString();
            dHalf.Text = Math.Round(calculator.half * calculator.dRatio, calculator.precision).ToString();
            dQuarter.Text = Math.Round(calculator.quarter * calculator.dRatio, calculator.precision).ToString();
            dEighth.Text = Math.Round(calculator.eigth * calculator.dRatio, calculator.precision).ToString();
            dSixteenth.Text = Math.Round(calculator.sixteenth * calculator.dRatio, calculator.precision).ToString();
            dThirtysecond.Text = Math.Round(calculator.thirtysecond * calculator.dRatio, calculator.precision).ToString();
            dSixtyfourth.Text = Math.Round(calculator.sixtyfourth * calculator.dRatio, calculator.precision).ToString();
        }
        private void PrintTriplet()
        {
            tWhole.Text = Math.Round(calculator.whole * calculator.tRatio, calculator.precision).ToString();
            tHalf.Text = Math.Round(calculator.half * calculator.tRatio, calculator.precision).ToString();
            tQuarter.Text = Math.Round(calculator.quarter * calculator.tRatio, calculator.precision).ToString();
            tEighth.Text = Math.Round(calculator.eigth * calculator.tRatio, calculator.precision).ToString();
            tSixteenth.Text = Math.Round(calculator.sixteenth * calculator.tRatio, calculator.precision).ToString();
            tThirtysecond.Text = Math.Round(calculator.thirtysecond * calculator.tRatio, calculator.precision).ToString();
            tSixtyfourth.Text = Math.Round(calculator.sixtyfourth * calculator.tRatio, calculator.precision).ToString();
        }
    }
}
