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
            double h, w, bmi;
            try 
            {
                h= double.Parse(heighit.Text);
                if (h > 3)
                {
                    h = h /100;
                }
                 w = double.Parse(weighit.Text);
                if (w > 1000)
                {
                     w = w / 1000;
                }
                bmi = (w / (h * h));
                bmi = Math.Round(bmi, 1, MidpointRounding.AwayFromZero);
                result.Text = "BMI値 =" + bmi;
            }catch (FormatException ex){
                 // FormatExceptionが投げられたらここで捕まえる．
                result.Text =("数字を入力してください。");

            }
        }
    }
}
