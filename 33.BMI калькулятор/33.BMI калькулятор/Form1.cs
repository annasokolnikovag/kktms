using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _33.BMI_калькулятор
{
    public partial class Form1 : Form
    {
        float h;
        float w;
        float imt;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            h = float.Parse(textBoxHeight.Text); 
            w = float.Parse(textBoxWeight.Text);
            h = h / 100; //перевод роста в метры
            imt = w / (h * h);
            label1BMI.Text = imt.ToString("N"); //с пом. N сокращаем число до 2 знаков
            trackBarBMI.Value = (int)imt;

            labelves.Visible = true;
            if (imt < 18.5)
                labelves.Text = "Недостаточный вес";
            if ((imt > 18.5) & (imt < 24.9))
                labelves.Text = "Здоровый вес";
            if ((imt > 24.9) & (imt < 29.9))
                labelves.Text = "Избыточный вес";
            if (imt > 30)
                labelves.Text = "Ожирение вес";
        }

        private void pictureBoxWoman_Click(object sender, EventArgs e)
        {
            pictureBoxWoman.BorderStyle = BorderStyle.Fixed3D;
            if (pictureBoxWoman.BorderStyle == BorderStyle.Fixed3D)
                pictureBoxMan.BorderStyle = BorderStyle.None;
        }

        private void pictureBoxMan_Click(object sender, EventArgs e)
        {
            pictureBoxMan.BorderStyle = BorderStyle.Fixed3D;
            if (pictureBoxMan.BorderStyle == BorderStyle.Fixed3D)
                pictureBoxWoman.BorderStyle = BorderStyle.None;
        }

        private void buttonOtmena_Click(object sender, EventArgs e)
        {
            textBoxHeight.Clear();
            textBoxWeight.Clear();
            label1BMI.Text = " ";
            labelves.Text = " ";
        }
    }
}
