using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriceAcc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int countRepit = 200;

        private void button1_Click(object sender, EventArgs e)
        {
           
            decimal result = 0;
            decimal priceMail = 0;
            decimal countMBGood = 0;
            decimal countMBBad = 0;
            decimal priceMb = 0;
            decimal percentGoodReg = 0;
            decimal percentGoodLive = 0;
            if (cbPriceMail1.SelectedItem == null)
            {
                if (!String.IsNullOrEmpty(cbPriceMail1.Text))
                {
                    priceMail = decimal.Parse(cbPriceMail1.Text);
                }
            }
            else
            {
                priceMail = decimal.Parse(cbPriceMail1.SelectedItem.ToString().Split(' ')[2]);
            }
            if (cbBadMb1.SelectedItem == null)
            {
                if (!String.IsNullOrEmpty(cbBadMb1.Text))
                {
                    countMBBad = decimal.Parse(cbBadMb1.Text);
                }
            }
            else
            {
                countMBBad = decimal.Parse(cbBadMb1.SelectedItem.ToString());
            }
            if (cbGoodMb1.SelectedItem == null)
            {
                if (!String.IsNullOrEmpty(cbGoodMb1.Text))
                {
                    countMBBad = decimal.Parse(cbGoodMb1.Text);
                }
            }
            else
            {
                countMBGood = decimal.Parse(cbGoodMb1.SelectedItem.ToString());
            }
            try
            {
                priceMb = decimal.Parse(tbStoimostMb1.Text);
            }
            catch { }
            percentGoodReg = decimal.Parse(tbPercentGoodReg1.Text) / 100;
            percentGoodLive = decimal.Parse(tbPercentLive1.Text) / 100;

            result = (priceMail / percentGoodReg + countMBGood * priceMb + countMBBad * priceMb * ((1 / percentGoodReg) - 1)) / percentGoodLive;
            tbResult1.Text = Decimal.Round(result, 2).ToString();
            countRepit = int.Parse(textBox11.Text);
            tb1.Text = Decimal.Round(countRepit * percentGoodLive * percentGoodReg).ToString();
            textBox1.Text = Decimal.Round(countRepit * percentGoodLive * percentGoodReg * (Decimal.Parse(tbPriceAcc.Text) - result), 2).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal result = 0;
            decimal priceMail = 0;
            decimal countMBGood = 0;
            decimal countMBBad = 0;
            decimal priceMb = 0;
            decimal percentGoodReg = 0;
            decimal percentGoodLive = 0;
            if (cbPriceMail2.SelectedItem == null)
            {
                if (!String.IsNullOrEmpty(cbPriceMail2.Text))
                {
                    priceMail = decimal.Parse(cbPriceMail2.Text);
                }
            }
            else
            {
                priceMail = decimal.Parse(cbPriceMail2.SelectedItem.ToString().Split(' ')[2]);
            }
            if (cbBadMb2.SelectedItem == null)
            {
                if (!String.IsNullOrEmpty(cbBadMb2.Text))
                {
                    countMBBad = decimal.Parse(cbBadMb2.Text);
                }
            }
            else
            {
                countMBBad = decimal.Parse(cbBadMb2.SelectedItem.ToString());
            }
            if (cbGoodMb2.SelectedItem == null)
            {
                if (!String.IsNullOrEmpty(cbGoodMb2.Text))
                {
                    countMBBad = decimal.Parse(cbGoodMb2.Text);
                }
            }
            else
            {
                countMBGood = decimal.Parse(cbGoodMb2.SelectedItem.ToString());
            }
            try
            {
                priceMb = decimal.Parse(tbStoimostMb2.Text);
            }
            catch { }
            percentGoodReg = decimal.Parse(tbPercentGoodReg2.Text) / 100;
            percentGoodLive = decimal.Parse(tbPercentLive2.Text) / 100;

            result = (priceMail / percentGoodReg + countMBGood * priceMb + countMBBad * priceMb * ((1 / percentGoodReg) - 1)) / percentGoodLive;
            tbResult2.Text = Decimal.Round(result, 2).ToString();
            countRepit = int.Parse(textBox12.Text);
            tb2.Text = Decimal.Round(countRepit * percentGoodLive * percentGoodReg).ToString();
            textBox2.Text = Decimal.Round(countRepit * percentGoodLive * percentGoodReg * (Decimal.Parse(tbPriceAcc.Text) - result), 2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal result = 0;
            decimal priceMail = 0;
            decimal countMBGood = 0;
            decimal countMBBad = 0;
            decimal priceMb = 0;
            decimal percentGoodReg = 0;
            decimal percentGoodLive = 0;
            if (cbPriceMail3.SelectedItem == null)
            {
                if (!String.IsNullOrEmpty(cbPriceMail3.Text))
                {
                    priceMail = decimal.Parse(cbPriceMail3.Text);
                }
            }
            else
            {
                priceMail = decimal.Parse(cbPriceMail3.SelectedItem.ToString().Split(' ')[2]);
            }
            if (cbBadMb3.SelectedItem == null)
            {
                if (!String.IsNullOrEmpty(cbBadMb3.Text))
                {
                    countMBBad = decimal.Parse(cbBadMb3.Text);
                }
            }
            else
            {
                countMBBad = decimal.Parse(cbBadMb3.SelectedItem.ToString());
            }
            if (cbGoodMb3.SelectedItem == null)
            {
                if (!String.IsNullOrEmpty(cbGoodMb3.Text))
                {
                    countMBBad = decimal.Parse(cbGoodMb3.Text);
                }
            }
            else
            {
                countMBGood = decimal.Parse(cbGoodMb3.SelectedItem.ToString());
            }
            try
            {
                priceMb = decimal.Parse(tbStoimostMb3.Text);
            }
            catch { }
            percentGoodReg = decimal.Parse(tbPercentGoodReg3.Text) / 100;
            percentGoodLive = decimal.Parse(tbPercentLive3.Text) / 100;

            result = (priceMail / percentGoodReg + countMBGood * priceMb + countMBBad * priceMb * ((1 / percentGoodReg) - 1)) / percentGoodLive;
            tbResult3.Text = Decimal.Round(result, 2).ToString();
            countRepit = int.Parse(textBox13.Text);
            tb3.Text = Decimal.Round(countRepit * percentGoodLive * percentGoodReg).ToString();
            textBox3.Text = Decimal.Round(countRepit * percentGoodLive * percentGoodReg * (Decimal.Parse(tbPriceAcc.Text) - result), 2).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal result = 0;
            decimal priceMail = 0;
            decimal countMBGood = 0;
            decimal countMBBad = 0;
            decimal priceMb = 0;
            decimal percentGoodReg = 0;
            decimal percentGoodLive = 0;
            if (cbPriceMail4.SelectedItem == null)
            {
                if (!String.IsNullOrEmpty(cbPriceMail4.Text))
                {
                    priceMail = decimal.Parse(cbPriceMail4.Text);
                }
            }
            else
            {
                priceMail = decimal.Parse(cbPriceMail4.SelectedItem.ToString().Split(' ')[2]);
            }
            if (cbBadMb4.SelectedItem == null)
            {
                if (!String.IsNullOrEmpty(cbBadMb4.Text))
                {
                    countMBBad = decimal.Parse(cbBadMb4.Text);
                }
            }
            else
            {
                countMBBad = decimal.Parse(cbBadMb4.SelectedItem.ToString());
            }
            if (cbGoodMb4.SelectedItem == null)
            {
                if (!String.IsNullOrEmpty(cbGoodMb4.Text))
                {
                    countMBBad = decimal.Parse(cbGoodMb4.Text);
                }
            }
            else
            {
                countMBGood = decimal.Parse(cbGoodMb4.SelectedItem.ToString());
            }
            try
            {
                priceMb = decimal.Parse(tbStoimostMb4.Text);
            }
            catch { }
            percentGoodReg = decimal.Parse(tbPercentGoodReg4.Text) / 100;
            percentGoodLive = decimal.Parse(tbPercentLive4.Text) / 100;

            result = (priceMail / percentGoodReg + countMBGood * priceMb + countMBBad * priceMb * ((1 / percentGoodReg) - 1)) / percentGoodLive;
            tbResult4.Text = Decimal.Round(result, 2).ToString();
            countRepit = int.Parse(textBox14.Text);
            tb4.Text = Decimal.Round(countRepit * percentGoodLive * percentGoodReg).ToString();
            textBox4.Text = Decimal.Round(countRepit * percentGoodLive * percentGoodReg * (Decimal.Parse(tbPriceAcc.Text) - result), 2).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            decimal result = 0;
            decimal priceMail = 0;
            decimal countMBGood = 0;
            decimal countMBBad = 0;
            decimal priceMb = 0;
            decimal percentGoodReg = 0;
            decimal percentGoodLive = 0;
            if (cbPriceMail5.SelectedItem == null)
            {
                if (!String.IsNullOrEmpty(cbPriceMail5.Text))
                {
                    priceMail = decimal.Parse(cbPriceMail5.Text);
                }
            }
            else
            {
                priceMail = decimal.Parse(cbPriceMail5.SelectedItem.ToString().Split(' ')[2]);
            }
            if (cbBadMb5.SelectedItem == null)
            {
                if (!String.IsNullOrEmpty(cbBadMb5.Text))
                {
                    countMBBad = decimal.Parse(cbBadMb5.Text);
                }
            }
            else
            {
                countMBBad = decimal.Parse(cbBadMb5.SelectedItem.ToString());
            }
            if (cbGoodMb5.SelectedItem == null)
            {
                if (!String.IsNullOrEmpty(cbGoodMb5.Text))
                {
                    countMBBad = decimal.Parse(cbGoodMb5.Text);
                }
            }
            else
            {
                countMBGood = decimal.Parse(cbGoodMb5.SelectedItem.ToString());
            }
            try
            {
                priceMb = decimal.Parse(tbStoimostMb5.Text);
            }
            catch { }
            percentGoodReg = decimal.Parse(tbPercentGoodReg5.Text) / 100;
            percentGoodLive = decimal.Parse(tbPercentLive5.Text) / 100;

            result = (priceMail / percentGoodReg + countMBGood * priceMb + countMBBad * priceMb * ((1 / percentGoodReg) - 1)) / percentGoodLive;
            tbResult5.Text = Decimal.Round(result, 2).ToString();
            countRepit = int.Parse(textBox15.Text);
            tb5.Text = Decimal.Round(countRepit * percentGoodLive * percentGoodReg).ToString();
            textBox5.Text = Decimal.Round(countRepit * percentGoodLive * percentGoodReg * (Decimal.Parse(tbPriceAcc.Text) - result), 2).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            decimal result = 0;
            decimal priceMail = 0;
            decimal countMBGood = 0;
            decimal countMBBad = 0;
            decimal priceMb = 0;
            decimal percentGoodReg = 0;
            decimal percentGoodLive = 0;
            if (cbPriceMail6.SelectedItem == null)
            {
                if (!String.IsNullOrEmpty(cbPriceMail6.Text))
                {
                    priceMail = decimal.Parse(cbPriceMail6.Text);
                }
            }
            else
            {
                priceMail = decimal.Parse(cbPriceMail6.SelectedItem.ToString().Split(' ')[2]);
            }
            if (cbBadMb6.SelectedItem == null)
            {
                if (!String.IsNullOrEmpty(cbBadMb6.Text))
                {
                    countMBBad = decimal.Parse(cbBadMb6.Text);
                }
            }
            else
            {
                countMBBad = decimal.Parse(cbBadMb6.SelectedItem.ToString());
            }
            if (cbGoodMb6.SelectedItem == null)
            {
                if (!String.IsNullOrEmpty(cbGoodMb6.Text))
                {
                    countMBBad = decimal.Parse(cbGoodMb6.Text);
                }
            }
            else
            {
                countMBGood = decimal.Parse(cbGoodMb6.SelectedItem.ToString());
            }
            try
            {
                priceMb = decimal.Parse(tbStoimostMb6.Text);
            }
            catch { }
            percentGoodReg = decimal.Parse(tbPercentGoodReg6.Text) / 100;
            percentGoodLive = decimal.Parse(tbPercentLive6.Text) / 100;

            result = (priceMail / percentGoodReg + countMBGood * priceMb + countMBBad * priceMb * ((1 / percentGoodReg) - 1)) / percentGoodLive;
            tbResult6.Text = Decimal.Round(result, 2).ToString();
            countRepit = int.Parse(textBox16.Text);
            tb6.Text = Decimal.Round(countRepit * percentGoodLive * percentGoodReg).ToString();
            textBox6.Text = Decimal.Round(countRepit * percentGoodLive * percentGoodReg * (Decimal.Parse(tbPriceAcc.Text) - result), 2).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            decimal result = 0;
            decimal priceMail = 0;
            decimal countMBGood = 0;
            decimal countMBBad = 0;
            decimal priceMb = 0;
            decimal percentGoodReg = 0;
            decimal percentGoodLive = 0;
            if (cbPriceMail7.SelectedItem == null)
            {
                if (!String.IsNullOrEmpty(cbPriceMail7.Text))
                {
                    priceMail = decimal.Parse(cbPriceMail7.Text);
                }
            }
            else
            {
                priceMail = decimal.Parse(cbPriceMail7.SelectedItem.ToString().Split(' ')[2]);
            }
            if (cbBadMb7.SelectedItem == null)
            {
                if (!String.IsNullOrEmpty(cbBadMb7.Text))
                {
                    countMBBad = decimal.Parse(cbBadMb7.Text);
                }
            }
            else
            {
                countMBBad = decimal.Parse(cbBadMb7.SelectedItem.ToString());
            }
            if (cbGoodMb7.SelectedItem == null)
            {
                if (!String.IsNullOrEmpty(cbGoodMb7.Text))
                {
                    countMBBad = decimal.Parse(cbGoodMb7.Text);
                }
            }
            else
            {
                countMBGood = decimal.Parse(cbGoodMb7.SelectedItem.ToString());
            }
            try
            {
                priceMb = decimal.Parse(tbStoimostMb7.Text);
            }
            catch { }
            percentGoodReg = decimal.Parse(tbPercentGoodReg7.Text) / 100;
            percentGoodLive = decimal.Parse(tbPercentLive7.Text) / 100;

            result = (priceMail / percentGoodReg + countMBGood * priceMb + countMBBad * priceMb * ((1 / percentGoodReg) - 1)) / percentGoodLive;
            tbResult7.Text = Decimal.Round(result, 2).ToString();
            countRepit = int.Parse(textBox17.Text);
            tb7.Text = Decimal.Round(countRepit * percentGoodLive * percentGoodReg).ToString();
            textBox7.Text = Decimal.Round(countRepit * percentGoodLive * percentGoodReg * (Decimal.Parse(tbPriceAcc.Text) - result), 2).ToString();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            decimal result = 0;
            decimal priceMail = 0;
            decimal countMBGood = 0;
            decimal countMBBad = 0;
            decimal priceMb = 0;
            decimal percentGoodReg = 0;
            decimal percentGoodLive = 0;
            if (cbPriceMail8.SelectedItem == null)
            {
                if (!String.IsNullOrEmpty(cbPriceMail8.Text))
                {
                    priceMail = decimal.Parse(cbPriceMail8.Text);
                }
            }
            else
            {
                priceMail = decimal.Parse(cbPriceMail8.SelectedItem.ToString().Split(' ')[2]);
            }
            if (cbBadMb8.SelectedItem == null)
            {
                if (!String.IsNullOrEmpty(cbBadMb8.Text))
                {
                    countMBBad = decimal.Parse(cbBadMb8.Text);
                }
            }
            else
            {
                countMBBad = decimal.Parse(cbBadMb8.SelectedItem.ToString());
            }
            if (cbGoodMb8.SelectedItem == null)
            {
                if (!String.IsNullOrEmpty(cbGoodMb8.Text))
                {
                    countMBBad = decimal.Parse(cbGoodMb8.Text);
                }
            }
            else
            {
                countMBGood = decimal.Parse(cbGoodMb8.SelectedItem.ToString());
            }
            try
            {
                priceMb = decimal.Parse(tbStoimostMb8.Text);
            }
            catch { }
            percentGoodReg = decimal.Parse(tbPercentGoodReg8.Text) / 100;
            percentGoodLive = decimal.Parse(tbPercentLive8.Text) / 100;

            result = (priceMail / percentGoodReg + countMBGood * priceMb + countMBBad * priceMb * ((1 / percentGoodReg) - 1)) / percentGoodLive;
            tbResult8.Text = Decimal.Round(result, 2).ToString();
            countRepit = int.Parse(textBox18.Text);
            tb8.Text = Decimal.Round(countRepit * percentGoodLive * percentGoodReg).ToString();
            textBox8.Text = Decimal.Round(countRepit * percentGoodLive * percentGoodReg * (Decimal.Parse(tbPriceAcc.Text) - result), 2).ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            decimal result = 0;
            decimal priceMail = 0;
            decimal countMBGood = 0;
            decimal countMBBad = 0;
            decimal priceMb = 0;
            decimal percentGoodReg = 0;
            decimal percentGoodLive = 0;
            if (cbPriceMail9.SelectedItem == null)
            {
                if (!String.IsNullOrEmpty(cbPriceMail9.Text))
                {
                    priceMail = decimal.Parse(cbPriceMail9.Text);
                }
            }
            else
            {
                priceMail = decimal.Parse(cbPriceMail9.SelectedItem.ToString().Split(' ')[2]);
            }
            if (cbBadMb9.SelectedItem == null)
            {
                if (!String.IsNullOrEmpty(cbBadMb9.Text))
                {
                    countMBBad = decimal.Parse(cbBadMb9.Text);
                }
            }
            else
            {
                countMBBad = decimal.Parse(cbBadMb9.SelectedItem.ToString());
            }
            if (cbGoodMb9.SelectedItem == null)
            {
                if (!String.IsNullOrEmpty(cbGoodMb9.Text))
                {
                    countMBBad = decimal.Parse(cbGoodMb9.Text);
                }
            }
            else
            {
                countMBGood = decimal.Parse(cbGoodMb9.SelectedItem.ToString());
            }
            try
            {
                priceMb = decimal.Parse(tbStoimostMb9.Text);
            }
            catch { }
            percentGoodReg = decimal.Parse(tbPercentGoodReg9.Text) / 100;
            percentGoodLive = decimal.Parse(tbPercentLive9.Text) / 100;

            result = (priceMail / percentGoodReg + countMBGood * priceMb + countMBBad * priceMb * ((1 / percentGoodReg) - 1)) / percentGoodLive;
            tbResult9.Text = Decimal.Round(result, 2).ToString();
            countRepit = int.Parse(textBox19.Text);
            tb9.Text = Decimal.Round(countRepit * percentGoodLive * percentGoodReg).ToString();
            textBox9.Text = Decimal.Round(countRepit * percentGoodLive * percentGoodReg * (Decimal.Parse(tbPriceAcc.Text) - result), 2).ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            decimal result = 0;
            decimal priceMail = 0;
            decimal countMBGood = 0;
            decimal countMBBad = 0;
            decimal priceMb = 0;
            decimal percentGoodReg = 0;
            decimal percentGoodLive = 0;
            if (cbPriceMail10.SelectedItem == null)
            {
                if (!String.IsNullOrEmpty(cbPriceMail10.Text))
                {
                    priceMail = decimal.Parse(cbPriceMail10.Text);
                }
            }
            else
            {
                priceMail = decimal.Parse(cbPriceMail10.SelectedItem.ToString().Split(' ')[2]);
            }
            if (cbBadMb10.SelectedItem == null)
            {
                if (!String.IsNullOrEmpty(cbBadMb10.Text))
                {
                    countMBBad = decimal.Parse(cbBadMb10.Text);
                }
            }
            else
            {
                countMBBad = decimal.Parse(cbBadMb10.SelectedItem.ToString());
            }
            if (cbGoodMb10.SelectedItem == null)
            {
                if (!String.IsNullOrEmpty(cbGoodMb10.Text))
                {
                    countMBBad = decimal.Parse(cbGoodMb10.Text);
                }
            }
            else
            {
                countMBGood = decimal.Parse(cbGoodMb10.SelectedItem.ToString());
            }
            try
            {
                priceMb = decimal.Parse(tbStoimostMb10.Text);
            }
            catch { }
            percentGoodReg = decimal.Parse(tbPercentGoodReg10.Text) / 100;
            percentGoodLive = decimal.Parse(tbPercentLive10.Text) / 100;

            result = (priceMail / percentGoodReg + countMBGood * priceMb + countMBBad * priceMb * ((1 / percentGoodReg) - 1)) / percentGoodLive;
            tbResult10.Text = Decimal.Round(result, 2).ToString();
            countRepit = int.Parse(textBox20.Text);
            tb10.Text = Decimal.Round(countRepit * percentGoodLive * percentGoodReg).ToString();
            textBox10.Text = Decimal.Round(countRepit * percentGoodLive * percentGoodReg * (Decimal.Parse(tbPriceAcc.Text) - result), 2).ToString();
        }
    }
}
