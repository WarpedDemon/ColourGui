using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ColourGui
{
    public partial class Form1 : Form
    {
        Panel colourPanel;
        public Label colourLabel;
        List<ColourClass> ColourList;
        int Pointer;
        int MaxPoint;
        public Form1()
        {
            InitializeComponent();
            //Initialize Variables....
            colourPanel = this.SimpleColourPanel;
            colourLabel = this.ColourLabel;
            //Load Json Data from File.
            string dataText = System.IO.File.ReadAllText(@"c:\data.txt");
            ColourList = JsonConvert.DeserializeObject<List<ColourClass>>(dataText);
            Pointer = 0;
            MaxPoint = ColourList.Count-1;

            //Start off with first colour.
            colourPanel.BackColor = ColorTranslator.FromHtml(ColourList[Pointer].hexValue);
            colourLabel.Text = "Current Colour - " + ColourList[Pointer].name;

        }

        private void previous_Click(object sender, EventArgs e)
        {
            if (Pointer == 0)
            {
                Pointer = MaxPoint;
            }
            else
            {
                Pointer -= 1;
            }

            Random rnd = new Random();
            int chance = rnd.Next(1, 2);
            if (chance == 1)
            {
                colourPanel.BackColor = System.Drawing.ColorTranslator.FromHtml(ColourList[Pointer].hexValue);
            }
            else
            {
                colourPanel.BackColor = Color.FromArgb(ColourList[Pointer].r, ColourList[Pointer].g, ColourList[Pointer].b);

            }

            colourLabel.Text = "Current Colour - " + ColourList[Pointer].name;
        }

        private void next_Click(object sender, EventArgs e)
        {
            if(Pointer == MaxPoint)
            {
                Pointer = 0;
            } else
            {
                Pointer += 1;
            }
            Random rnd = new Random();
            int chance = rnd.Next(1, 2);
            if (chance == 1)
            {
                colourPanel.BackColor = System.Drawing.ColorTranslator.FromHtml(ColourList[Pointer].hexValue);
            } else
            {
                colourPanel.BackColor = Color.FromArgb(ColourList[Pointer].r, ColourList[Pointer].g, ColourList[Pointer].b);

            }

            colourLabel.Text = "Current Colour - " + ColourList[Pointer].name;
        }
    }
}
