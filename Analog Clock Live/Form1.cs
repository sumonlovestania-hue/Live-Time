using System;
using System.Globalization;
using System.Windows.Forms;

namespace Analog_Clock_Live
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var culture = new CultureInfo("bn-BD");
            DateTime now = DateTime.Now;

            string period = now.Hour >= 12 ? "PM" : "AM";
            string bengaliPeriod = "";
            if (now.Hour < 6) bengaliPeriod = "রাত";
            else if (now.Hour < 12) bengaliPeriod = "সকাল";
            else if (now.Hour < 16) bengaliPeriod = "দুপুর";
            else if (now.Hour < 18) bengaliPeriod = "বিকাল";
            else bengaliPeriod = "রাত";

            lblTime.Text = $"{bengaliPeriod} {now.ToString("h:mm:ss", culture)} {period}";
            lblDate.Text = now.ToString("dddd, dd MMMM, yyyy", culture);
        }
    }
}