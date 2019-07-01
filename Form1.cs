using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherChecker
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> cityNames;

        public Form1()
        {
            InitializeComponent();

            this.cityNames = new Dictionary<string, string>();

            this.cityNames.Add("東京都", "3");
            this.cityNames.Add("大阪府", "1");
            this.cityNames.Add("愛知県", "2");
            this.cityNames.Add("福岡県", "10");

            foreach (KeyValuePair<string, string> data in this.cityNames)
            {
                areaBox.Items.Add(data.key);
            }
        }

        private void CitySelected(object sender, EventArgs e)
        {

        }
    }
}
