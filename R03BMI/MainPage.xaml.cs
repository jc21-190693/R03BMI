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
            double w, h, BMI;
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
                     w = w / 100;
                }
                BMI = (w / (h * h));
                BMI = Math.Round(1,5);
                result.Text = "BMI値 =" + BMI;
            }catch (FormatException ex){
                 // NumberFormatExceptionが投げられたらここで捕まえる．
                result.Text =（"数字を入力してください。");
            }
        }
    }
}
