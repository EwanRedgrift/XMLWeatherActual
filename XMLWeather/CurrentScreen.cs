using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public static string Location = "Stratford,CA";

        public void DisplayCurrent()
        {
            cityOutput.Text = Form1.days[0].location;

            dayOutput.Text = DateTime.Now.ToString("dddd");

            tempOutput.Text = Form1.days[0].currentTemp + "°";

            highOutput.Text = "H: " + Form1.days[0].tempHigh + "°";
            lowOutput.Text = "L: " + Form1.days[0].tempLow + "°";
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Location = searchBox.Text;

                    Form1.ExtractCurrent(Location);
                    Form1.ExtractForecast(Location);

                    DisplayCurrent();

                    searchBox.Text = "Search City...";

                    this.Focus();
                }
                catch
                {
                    searchBox.Text = "SDF";
                }
               
            }

        }
    }
}
