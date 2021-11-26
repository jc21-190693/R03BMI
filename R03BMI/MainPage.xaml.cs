using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R03BMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            creater.Text = "JK3A39 渡辺　夏輝";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double weight, height, BMI;
            weight = double.Parse(weighit.Text);
            height = double.Parse(heighit.Text);
            BMI = (weight / (height * height));
            result.Text = "BMI値l =" + BMI.ToString();
        }
    }
}
