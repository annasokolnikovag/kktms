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
            buttonBMI.Text = imt.ToString("N"); //с пом. N сокращаем число до 2 знаков
            trackBarBMI.Value = (int)imt;

        }
    }
}
